using GestaoReceitas.XMLHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;

public class Utilizador
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public Utilizador(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public bool Autenticar(string xmlPath, string xsdPath) {
        XMLHandler.CriarXML(xmlPath, xsdPath);
        // Carrega o xml e o xsd
        XmlSchemaSet schemaSet = new XmlSchemaSet();
        schemaSet.Add(XMLHandler.TargetNamespace(xsdPath), xsdPath);

        // Realizar a validação do XML de acordo com o XSD
        XmlReaderSettings settings = new XmlReaderSettings();
        settings.ValidationType = ValidationType.Schema;
        settings.Schemas = schemaSet;
        settings.ValidationEventHandler += (sender, e) => {
        };
        // Procura o utilizador no xml
        XmlReader reader = XmlReader.Create(xmlPath, settings);
        while (reader.ReadToFollowing("utilizador"))
        {
            reader.ReadToDescendant("id");
            int id = reader.ReadElementContentAsInt();
            reader.ReadToNextSibling("nome");
            string nome = reader.ReadElementContentAsString();
            reader.ReadToNextSibling("username");
            string username = reader.ReadElementContentAsString();
            reader.ReadToNextSibling("password");
            string password = reader.ReadElementContentAsString();
            if (username == Username && password == Password)
            {
                Id = id;
                Nome = nome;
                reader.Close();
                return true;
            }
        }
        reader.Close();
        return false;

    }

    public static void Criar(string xmlPath, string xsdPath, string nome, string username, string password)
    {
        // Adiciona um novo utilizador ao xml
        XMLHandler.CriarXML(xmlPath, xsdPath);
        // Carrega o xml e o xsd
        XmlSchemaSet schemaSet = new XmlSchemaSet();
        schemaSet.Add(XMLHandler.TargetNamespace(xsdPath), xsdPath);
        XmlReaderSettings settings = new XmlReaderSettings();
        settings.ValidationType = ValidationType.Schema;
        settings.Schemas = schemaSet;
        settings.ValidationEventHandler += (sender, e) =>
        {
            throw new Exception(e.Message);
        };
        XmlReader reader = XmlReader.Create(xmlPath, settings);
        XmlDocument doc = new XmlDocument();
        doc.Load(xmlPath);
        // Procura o último id
        int id = 0;
        while (reader.ReadToFollowing("utilizador"))
        {


            // Lê o  ultimo id
            reader.ReadToDescendant("id");
            int idTemp = reader.ReadElementContentAsInt();
            if (idTemp > id)
            {
                id = idTemp;
            }

            // Verifica se o utilizador já existe através do username
            reader.ReadToNextSibling("username");
            string usernameTemp = reader.ReadElementContentAsString();
            if (usernameTemp == username)
            {
                reader.Close();
                throw new Exception("O utilizador já existe");
            }

        }
        reader.Close();

        // Cria o novo utilizador
        XmlElement utilizador = doc.CreateElement("utilizador", XMLHandler.TargetNamespace(xsdPath));
        XmlElement idElement = doc.CreateElement("id", XMLHandler.TargetNamespace(xsdPath));
        idElement.InnerText = (id + 1).ToString();
        XmlElement nomeElement = doc.CreateElement("nome", XMLHandler.TargetNamespace(xsdPath));
        nomeElement.InnerText = nome;
        XmlElement usernameElement = doc.CreateElement("username", XMLHandler.TargetNamespace(xsdPath));
        usernameElement.InnerText = username;
        XmlElement passwordElement = doc.CreateElement("password", XMLHandler.TargetNamespace(xsdPath));
        passwordElement.InnerText = password;
        utilizador.AppendChild(idElement);
        utilizador.AppendChild(nomeElement);
        utilizador.AppendChild(usernameElement);
        utilizador.AppendChild(passwordElement);
        doc.DocumentElement.AppendChild(utilizador);
        doc.Save(xmlPath);
    }

    public void AlterarDados(string xmlPath, string xsdPath, int userId, string novoNome, string novaPassword = null)
    {
        // Carrega o xml e o xsd
        XmlSchemaSet schemaSet = new XmlSchemaSet();
        schemaSet.Add(XMLHandler.TargetNamespace(xsdPath), xsdPath);

        // Realizar a validação do XML de acordo com o XSD
        XmlReaderSettings settings = new XmlReaderSettings();
        settings.ValidationType = ValidationType.Schema;
        settings.Schemas = schemaSet;
        settings.ValidationEventHandler += (sender, e) => {
            // Lidar com erros de validação, se necessário
            throw new Exception(e.Message);
        };

        // Procura o utilizador no xml
        XmlDocument doc = new XmlDocument();
        doc.Load(xmlPath);
        XmlNodeList utilizadores = doc.DocumentElement.GetElementsByTagName("utilizador");
        foreach (XmlNode utilizadorNode in utilizadores)
        {
            if (utilizadorNode.ChildNodes[0].InnerText == userId.ToString())
            {
                // Altera o nome do utilizador
                utilizadorNode.ChildNodes[1].InnerText = novoNome;

                // Altera a senha do utilizador, se fornecida
                if (!string.IsNullOrEmpty(novaPassword))
                {
                    utilizadorNode.ChildNodes[3].InnerText = novaPassword;
                }

                // Salva as alterações no XML
                doc.Save(xmlPath);

                // Atualiza as propriedades do objeto Utilizador
                Id = userId;
                Nome = novoNome;
                Password = novaPassword;
                return;
            }   
        }
        doc.Save(xmlPath);
        return;
    }

}


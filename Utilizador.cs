using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

public class Utilizador
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Id { get; set; }
    public string Nome { get; set; }
    public Utilizador(string username, string password)
    {
        Username = username;
        Password = password;
    }

    private static void CriarXML(string xmlPath)
    {
        if (!File.Exists(xmlPath))
        {
            XmlWriter writer = XmlWriter.Create(xmlPath);
            // Escrever o elemento raiz e definir o namespace, se necessário
            writer.WriteStartElement("receitas");
            writer.WriteAttributeString("xmlns", "http://tempuri.org/Receitas.xsd");

            // Finalizar a escrita e fechar o escritor XML
            writer.WriteEndElement();
            writer.Flush();
        }
    }

    public bool Autenticar(string xmlPath, string xsdPath) {
        CriarXML(xmlPath);
        // Carrega o xml e o xsd
        XmlSchemaSet schemaSet = new XmlSchemaSet();
        schemaSet.Add("", xsdPath);

        // Realizar a validação do XML de acordo com o XSD
        XmlReaderSettings settings = new XmlReaderSettings();
        settings.ValidationType = ValidationType.Schema;
        settings.Schemas = schemaSet;
        settings.ValidationEventHandler += (sender, e) => {
            throw new Exception(e.Message);
        };
        // Procura o utilizador no xml
        XmlReader reader = XmlReader.Create(xmlPath, settings);
        while (reader.ReadToFollowing("utilizador"))
        {
            reader.ReadToDescendant("username");
            string username = reader.ReadElementContentAsString();
            reader.ReadToNextSibling("password");
            string password = reader.ReadElementContentAsString();
            if (username == Username && password == Password)
            {
                // Define o id do utilizador
                reader.ReadToNextSibling("id");
                Id = reader.ReadElementContentAsString();
                // Define o nome do utilizador
                reader.ReadToNextSibling("nome");
                Nome = reader.ReadElementContentAsString();
                return true;
            }
        }
        return false;

    }

    public static void Criar(string xmlPath, string xsdPath)
    {
        // Adiciona um novo utilizador ao xml
        CriarXML(xmlPath);
        // Carrega o xml e o xsd
        XmlSchemaSet schemaSet = new XmlSchemaSet();
        schemaSet.Add("", xsdPath);
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
            reader.ReadToDescendant("id");
            int idTemp = int.Parse(reader.ReadElementContentAsString());
            if (idTemp > id)
            {
                id = idTemp;
            }
        }
        // Cria o novo utilizador
        XmlElement utilizador = doc.CreateElement("utilizador");
        XmlElement idElement = doc.CreateElement("id");
        idElement.InnerText = (id + 1).ToString();
        XmlElement usernameElement = doc.CreateElement("username");
        usernameElement.InnerText = Username;
        XmlElement passwordElement = doc.CreateElement("password");
        passwordElement.InnerText = Password;
        utilizador.AppendChild(idElement);
        utilizador.AppendChild(usernameElement);
        utilizador.AppendChild(passwordElement);
        doc.DocumentElement.AppendChild(utilizador);
        doc.Save(xmlPath);
    }

    public void AlterarNomeUtilizador(string xmlPath, string xsdPath)
    {
        // Criar XML
        CriarXML(xmlPath);
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(xmlPath);
        // Alterar o nome do utilizador


    }
}


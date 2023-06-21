using GestaoReceitas.XMLHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

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
            reader.ReadToDescendant("nome");
            string nome = reader.ReadElementContentAsString();
            reader.ReadToDescendant("username");
            string username = reader.ReadElementContentAsString();
            reader.ReadToNextSibling("password");
            string password = reader.ReadElementContentAsString();
            if (username == Username && password == Password)
            {
                Id = id;
                Nome = nome;
                return true;
            }
        }
        return false;

    }

    public static void Criar(string xmlPath, string xsdPath, string nome, string username, string password)
    {
        // Adiciona um novo utilizador ao xml
        XMLHandler.CriarXML(xmlPath, xsdPath);
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
        XmlElement nomeElement = doc.CreateElement("username");
        nomeElement.InnerText = nome;
        XmlElement usernameElement = doc.CreateElement("username");
        usernameElement.InnerText = username;
        XmlElement passwordElement = doc.CreateElement("password");
        passwordElement.InnerText = password;
        utilizador.AppendChild(idElement);
        utilizador.AppendChild(usernameElement);
        utilizador.AppendChild(passwordElement);
        doc.DocumentElement.AppendChild(utilizador);
        doc.Save(xmlPath);
    }

    public void AlterarNomeUtilizador(string xmlPath, string xsdPath)
    {
        // Criar XML
        XMLHandler.CriarXML(xmlPath, xsdPath);
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(xmlPath);
        // Alterar o nome do utilizador


    }
}


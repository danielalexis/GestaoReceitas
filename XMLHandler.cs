using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GestaoReceitas.XMLHandler
{
    public class XMLHandler
    {
        public static void CriarXML(string xmlPath, string xsdPath) {
            // Lê o targetNamespace do xsd
            string targetNamespace = "";

            using (XmlReader reader = XmlReader.Create(xsdPath))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "xs:schema")
                    {
                        targetNamespace = reader.GetAttribute("targetNamespace");
                        break;
                    }
                }
            }


            if (!File.Exists(xmlPath))
            {
                XmlWriter writer = XmlWriter.Create(xmlPath);
                // Obtem o start element do xsd
                string startElement = "";
                using (XmlReader reader = XmlReader.Create(xsdPath))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "xs:element")
                        {
                            startElement = reader.GetAttribute("name");
                            break;
                        }
                    }
                }
                writer.WriteStartDocument();
                writer.WriteStartElement(startElement, TargetNamespace(xsdPath));

                // Finalizar a escrita e fechar o escritor XML
                writer.WriteEndElement();
                writer.WriteEndDocument();

                // Flush and close the writer
                writer.Flush();
                writer.Close();
            }
        }

        public static string TargetNamespace(string xsdPath)
        {
            using (XmlReader reader = XmlReader.Create(xsdPath))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "xs:schema")
                    {
                        if (reader.GetAttribute("targetNamespace") != null)
                        {
                            return reader.GetAttribute("targetNamespace");
                        }
                    }
                }
            }
            return "";
        }
    }
}

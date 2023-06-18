

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Enumeration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Schema;

public class Receitas
{
    public class IngredienteUnidade : Enumeration
    {
        public static IngredienteUnidade Gramas => new(1, "Gramas");
        public static IngredienteUnidade Kilogramas => new(2, "Kilogramas");
        public static IngredienteUnidade Miligramas => new(2, "Kilogramas");
        public static IngredienteUnidade Litros => new(2, "Litros");
        public static IngredienteUnidade Mililitros => new(2, "Mililitros");
        public static IngredienteUnidade ColheresDeCha => new(2, "Colheres de Chá");
        public static IngredienteUnidade ColheresDeSopa => new(2, "Colheres de Sopa");
        public static IngredienteUnidade Xicaras => new(2, "Xícaras");
        public static IngredienteUnidade Unidades => new(2, "Unidades");

        public IngredienteUnidade(int id, string name)
            : base(id, name)
        {
        }
    }

    public struct Ingrediente
    {
        public string Nome { get; set; }
        public float Quantidade { get; set; }
        public IngredienteUnidade Unidade { get; set; }
    }

    public struct Receita
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Dificuldade { get; set; }
        public string Descricao { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
        public string Preparacao { get; set; }
    }

    private void CriarXML(string xmlPath) {
        if (!File.Exists(xmlPath)) {
            using (XmlWriter writer = XmlWriter.Create(xmlPath)) {
                // Definir as configurações do escritor XML
                writer.Settings.Indent = true;

                // Escrever o elemento raiz e definir o namespace, se necessário
                writer.WriteStartElement("receitas");
                writer.WriteAttributeString("xmlns", "", null, "http://www.example.com/receitas");

                // Finalizar a escrita e fechar o escritor XML
                writer.WriteEndElement();
                writer.Flush();
            }
        }
    }

    public List<Receita> ListaReceitas(string xmlPath, string xsdPath)
    {
        List<Receita> receitas = new List<Receita>();

        

        // Carregar o esquema XSD
        XmlSchemaSet schemaSet = new XmlSchemaSet();
        schemaSet.Add("", xsdPath);

        // Realizar a validação do XML de acordo com o XSD
        XmlReaderSettings settings = new XmlReaderSettings();
        settings.ValidationType = ValidationType.Schema;
        settings.Schemas = schemaSet;
        settings.ValidationEventHandler += (sender, e) => {
            throw new Exception(e.Message);
        };

        using (XmlReader reader = XmlReader.Create(xmlPath, settings))
        {
            // Ler as receitas do XML
            while (reader.ReadToFollowing("receita"))
            {
                Receita receita = new Receita();

                reader.ReadToDescendant("nome");
                receita.Nome = reader.ReadElementContentAsString();

                reader.ReadToNextSibling("categoria");
                receita.Categoria = reader.ReadElementContentAsString();

                reader.ReadToNextSibling("dificuldade");
                receita.Dificuldade = reader.ReadElementContentAsString();

                reader.ReadToNextSibling("descrição");
                receita.Descricao = reader.ReadElementContentAsString();

                reader.ReadToNextSibling("ingredientes");
                receita.Ingredientes = new List<Ingrediente>();

                if (reader.ReadToDescendant("ingrediente"))
                {
                    do
                    {
                        Ingrediente ingrediente = new Ingrediente();

                        reader.ReadToDescendant("nome");
                        ingrediente.Nome = reader.ReadElementContentAsString();

                        reader.ReadToNextSibling("quantidade");
                        ingrediente.Quantidade = reader.ReadElementContentAsFloat();

                        reader.ReadToNextSibling("unidade");
                        ingrediente.Unidade = ParseIngredienteUnidade(reader.ReadElementContentAsString());

                        receita.Ingredientes.Add(ingrediente);
                    } while (reader.ReadToNextSibling("ingrediente"));
                }

                reader.ReadToNextSibling("preparação");
                receita.Preparacao = reader.ReadElementContentAsString();

                receitas.Add(receita);
            }
        }

        return receitas;
    }


    private IngredienteUnidade ParseIngredienteUnidade(string unidade)
    {
        return unidade.ToLower() switch
        {
            "gramas" => IngredienteUnidade.Gramas,
            "quilogramas" => IngredienteUnidade.Kilogramas,
            "miligramas" => IngredienteUnidade.Miligramas,
            "litros" => IngredienteUnidade.Litros,
            "mililitros" => IngredienteUnidade.Mililitros,
            "colheres de chá" => IngredienteUnidade.ColheresDeCha,
            "colheres de sopa" => IngredienteUnidade.ColheresDeSopa,
            "xícaras" => IngredienteUnidade.Xicaras,
            "unidades" => IngredienteUnidade.Unidades,
            _ => throw new ArgumentException($"Unidade de ingrediente inválida: {unidade}"),
        };
    }
}

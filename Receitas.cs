

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

        public string Tempo { get; set; }
        public string Descricao { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
        public string Preparacao { get; set; }
    }

    private void CriarXML(string xmlPath) {
        if (!File.Exists(xmlPath)) {
            using (XmlWriter writer = XmlWriter.Create(xmlPath)) {
                // Escrever o elemento raiz e definir o namespace, se necessário
                writer.WriteStartElement("receitas");
                writer.WriteAttributeString("xmlns", "http://tempuri.org/Receitas.xsd");

                // Finalizar a escrita e fechar o escritor XML
                writer.WriteEndElement();
                writer.Flush();
            }
        }
    }

    public List<Receita> ListaReceitas(string xmlPath, string xsdPath)
    {
        CriarXML(xmlPath);
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

                reader.ReadToNextSibling("tempo");
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


    public void AdicionarReceita(string xmlPath, Receita novaReceita)
    {
        // Carregar as receitas existentes do arquivo XML
        List<Receita> receitas = ListaReceitas(xmlPath, "ReceitasSchema.xsd");

        // Adicionar a nova receita à lista
        receitas.Add(novaReceita);

        // Criar um novo XML com as receitas atualizadas
        CriarXML(xmlPath);

        // Adicionar as receitas atualizadas ao XML
        using (XmlWriter writer = XmlWriter.Create(xmlPath))
        {
            writer.WriteStartElement("receitas");
            writer.WriteAttributeString("xmlns", "", null, "http://www.example.com/receitas");

            foreach (Receita receita in receitas)
            {
                writer.WriteStartElement("receita");

                writer.WriteStartElement("nome");
                writer.WriteString(receita.Nome);
                writer.WriteEndElement();

                writer.WriteStartElement("categoria");
                writer.WriteString(receita.Categoria);
                writer.WriteEndElement();

                writer.WriteStartElement("dificuldade");
                writer.WriteString(receita.Dificuldade);
                writer.WriteEndElement();

                writer.WriteStartElement("descrição");
                writer.WriteString(receita.Descricao);
                writer.WriteEndElement();

                writer.WriteStartElement("ingredientes");

                foreach (Ingrediente ingrediente in receita.Ingredientes)
                {
                    writer.WriteStartElement("ingrediente");

                    writer.WriteStartElement("nome");
                    writer.WriteString(ingrediente.Nome);
                    writer.WriteEndElement();

                    writer.WriteStartElement("quantidade");
                    writer.WriteString(ingrediente.Quantidade.ToString());
                    writer.WriteEndElement();

                    writer.WriteStartElement("unidade");
                    writer.WriteString(ingrediente.Unidade.Name);
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();

                writer.WriteStartElement("preparação");
                writer.WriteString(receita.Preparacao);
                writer.WriteEndElement();

                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.Flush();
        }
    }

}

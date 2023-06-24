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
using GestaoReceitas.XMLHandler;
using System.Configuration;

public class Receita
{

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public string Dificuldade { get; set; }
    public decimal Porcoes { get; set; }
    public int    Tempo { get; set; }
    public string Descricao { get; set; }
    public List<Ingrediente> Ingredientes { get; set; }
    public string Preparacao { get; set; }


    public static List<Receita> ListaReceitas(string xmlPath, string xsdPath)
    {
        XMLHandler.CriarXML(xmlPath, xsdPath);
        List<Receita> receitas = new List<Receita>();

        // Carregar o esquema XSD
        XmlSchemaSet schemaSet = new XmlSchemaSet();
        schemaSet.Add(XMLHandler.TargetNamespace(xsdPath), xsdPath);

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

                reader.ReadToDescendant("id");
                receita.Id = reader.ReadElementContentAsInt();

                reader.ReadToNextSibling("nome");
                receita.Nome = reader.ReadElementContentAsString();

                reader.ReadToNextSibling("categoria");
                receita.Categoria = reader.ReadElementContentAsString();

                reader.ReadToNextSibling("dificuldade");
                receita.Dificuldade = reader.ReadElementContentAsString();

                reader.ReadToNextSibling("porcoes");
                receita.Porcoes = reader.ReadElementContentAsDecimal();

                reader.ReadToNextSibling("tempo");
                receita.Tempo = reader.ReadElementContentAsInt();

                reader.ReadToNextSibling("descricao");
                receita.Descricao = reader.ReadElementContentAsString();

                reader.ReadToNextSibling("ingredientes");
                receita.Ingredientes = new List<Ingrediente>();

                if (reader.ReadToDescendant("ingrediente"))
                {
                    do
                    {
                        Ingrediente ingrediente = new Ingrediente();

                        if (reader.ReadToFollowing("nome"))
                        {
                            ingrediente.Nome = reader.ReadElementContentAsString();
                        }

                        if (reader.ReadToFollowing("quantidade"))
                        {
                            ingrediente.Quantidade = reader.ReadElementContentAsDecimal();
                        }

                        if (reader.ReadToFollowing("unidade"))
                        {
                            ingrediente.Unidade = ParseIngredienteUnidade(reader.ReadElementContentAsString());
                        }

                        receita.Ingredientes.Add(ingrediente);

                    } while (reader.ReadToNextSibling("ingrediente"));
                }

                reader.ReadToFollowing("preparacao");
                receita.Preparacao = reader.ReadElementContentAsString();

                receitas.Add(receita);
            }
            reader.Close();
        }

        return receitas;
    }


    public static IngredienteUnidade ParseIngredienteUnidade(string unidade)
    {
        return unidade.ToLower() switch
        {
            "gramas" => IngredienteUnidade.Gramas,
            "kilogramas" => IngredienteUnidade.Kilogramas,
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


    public void AdicionarReceita(string xmlPath, string xsdPath)
    {
        // Criar um novo XML com as receitas atualizadas
        XMLHandler.CriarXML(xmlPath, xsdPath);

        // Obter o último ID da lista de receitas
        int ultimoId;
        try
        {
            ultimoId = (ListaReceitas(xmlPath, xsdPath)).Max(receita => receita.Id);
        } catch (InvalidOperationException)
        {
            ultimoId = 0;
        }
        // Adicionar as receitas atualizadas ao XML
        XmlDocument doc = new XmlDocument();
        doc.Load(xmlPath);


        XmlElement receitaElement = doc.CreateElement("receita", XMLHandler.TargetNamespace(xsdPath));

        XmlElement idElement = doc.CreateElement("id", XMLHandler.TargetNamespace(xsdPath));
        idElement.InnerText = (ultimoId + 1).ToString();

        XmlElement nomeElement = doc.CreateElement("nome", XMLHandler.TargetNamespace(xsdPath));
        nomeElement.InnerText = Nome;

        XmlElement categoriaElement = doc.CreateElement("categoria", XMLHandler.TargetNamespace(xsdPath));
        categoriaElement.InnerText = Categoria;

        XmlElement dificuldadeElement = doc.CreateElement("dificuldade", XMLHandler.TargetNamespace(xsdPath));
        dificuldadeElement.InnerText = Dificuldade;

        XmlElement porcoesElement = doc.CreateElement("porcoes", XMLHandler.TargetNamespace(xsdPath));
        porcoesElement.InnerText = Porcoes.ToString();

        XmlElement tempoElement = doc.CreateElement("tempo", XMLHandler.TargetNamespace(xsdPath));
        tempoElement.InnerText = Tempo.ToString();

        XmlElement descricaoElement = doc.CreateElement("descricao", XMLHandler.TargetNamespace(xsdPath));
        descricaoElement.InnerText = Descricao;

        XmlElement ingredientesElement = doc.CreateElement("ingredientes", XMLHandler.TargetNamespace(xsdPath));

        foreach (Ingrediente ingrediente in Ingredientes)
        {
            XmlElement ingredienteElement = doc.CreateElement("ingrediente", XMLHandler.TargetNamespace(xsdPath));

            XmlElement nomeIngredienteElement = doc.CreateElement("nome", XMLHandler.TargetNamespace(xsdPath));
            nomeIngredienteElement.InnerText = ingrediente.Nome;

            XmlElement quantidadeIngredienteElement = doc.CreateElement("quantidade", XMLHandler.TargetNamespace(xsdPath));
            quantidadeIngredienteElement.InnerText = ingrediente.Quantidade.ToString();

            XmlElement unidadeIngredienteElement = doc.CreateElement("unidade", XMLHandler.TargetNamespace(xsdPath));
            unidadeIngredienteElement.InnerText = ingrediente.Unidade.Name;

            ingredienteElement.AppendChild(nomeIngredienteElement);
            ingredienteElement.AppendChild(quantidadeIngredienteElement);
            ingredienteElement.AppendChild(unidadeIngredienteElement);

            ingredientesElement.AppendChild(ingredienteElement);
        }

        XmlElement preparacaoElement = doc.CreateElement("preparacao", XMLHandler.TargetNamespace(xsdPath));
        preparacaoElement.InnerText = this.Preparacao;

        receitaElement.AppendChild(idElement);
        receitaElement.AppendChild(nomeElement);
        receitaElement.AppendChild(categoriaElement);
        receitaElement.AppendChild(dificuldadeElement);
        receitaElement.AppendChild(porcoesElement);
        receitaElement.AppendChild(tempoElement);
        receitaElement.AppendChild(descricaoElement);
        receitaElement.AppendChild(ingredientesElement);
        receitaElement.AppendChild(preparacaoElement);
        doc.DocumentElement.AppendChild(receitaElement);
        doc.Save(xmlPath);
        Id = ultimoId + 1;
    }

    public static void EliminarReceita(string xmlPath, string xsdPath, int idReceita)
    {
        // Carregar as receitas existentes do arquivo XML
        List<Receita> receitas = ListaReceitas(xmlPath, xsdPath);

        // Procurar a receita com o ID especificado
        Receita receita = receitas.FirstOrDefault(r => r.Id == idReceita);

        // Verificar se a receita foi encontrada
        if (receita != null)
        {
            // Remover a receita da lista
            receitas.Remove(receita);

            try
            {
                File.Delete(xmlPath);

            } catch (IOException)
            {
                throw new IOException("Não foi possível eliminar o arquivo XML.");
            }

            // Criar um novo XML com as receitas atualizadas
            XMLHandler.CriarXML(xmlPath, xsdPath);

            // Criar um novo documento XML
            XmlDocument doc = new XmlDocument();

            // Carregar o arquivo XML existente
            doc.Load(xmlPath);

            // Obter o elemento raiz do documento
            XmlElement rootElement = doc.DocumentElement;

            // Adicionar as receitas atualizadas ao documento
            foreach (Receita receitaLoop in receitas)
            {
                // Criar o elemento "receita"
                XmlElement receitaElement = doc.CreateElement("receita", XMLHandler.TargetNamespace(xsdPath));

                // Adicionar os elementos filhos à receita

                XmlElement idElement = doc.CreateElement("id", XMLHandler.TargetNamespace(xsdPath));
                idElement.InnerText = receitaLoop.Id.ToString();
                receitaElement.AppendChild(idElement);

                XmlElement nomeElement = doc.CreateElement("nome", XMLHandler.TargetNamespace(xsdPath));
                nomeElement.InnerText = receitaLoop.Nome;
                receitaElement.AppendChild(nomeElement);

                XmlElement categoriaElement = doc.CreateElement("categoria", XMLHandler.TargetNamespace(xsdPath));
                categoriaElement.InnerText = receitaLoop.Categoria;
                receitaElement.AppendChild(categoriaElement);

                XmlElement dificuldadeElement = doc.CreateElement("dificuldade", XMLHandler.TargetNamespace(xsdPath));
                dificuldadeElement.InnerText = receitaLoop.Dificuldade;
                receitaElement.AppendChild(dificuldadeElement);

                XmlElement porcoesElement = doc.CreateElement("porcoes", XMLHandler.TargetNamespace(xsdPath));
                porcoesElement.InnerText = receitaLoop.Porcoes.ToString();
                receitaElement.AppendChild(porcoesElement);

                XmlElement tempoElement = doc.CreateElement("tempo", XMLHandler.TargetNamespace(xsdPath));
                tempoElement.InnerText = receitaLoop.Tempo.ToString();
                receitaElement.AppendChild(tempoElement);

                XmlElement descricaoElement = doc.CreateElement("descricao", XMLHandler.TargetNamespace(xsdPath));
                descricaoElement.InnerText = receitaLoop.Descricao;
                receitaElement.AppendChild(descricaoElement);

                XmlElement ingredientesElement = doc.CreateElement("ingredientes", XMLHandler.TargetNamespace(xsdPath));
                foreach (Ingrediente ingrediente in receitaLoop.Ingredientes)
                {
                    XmlElement ingredienteElement = doc.CreateElement("ingrediente", XMLHandler.TargetNamespace(xsdPath));

                    XmlElement nomeIngredienteElement = doc.CreateElement("nome", XMLHandler.TargetNamespace(xsdPath));
                    nomeIngredienteElement.InnerText = ingrediente.Nome;
                    ingredienteElement.AppendChild(nomeIngredienteElement);

                    XmlElement quantidadeElement = doc.CreateElement("quantidade", XMLHandler.TargetNamespace(xsdPath));
                    quantidadeElement.InnerText = ingrediente.Quantidade.ToString();
                    ingredienteElement.AppendChild(quantidadeElement);

                    XmlElement unidadeElement = doc.CreateElement("unidade", XMLHandler.TargetNamespace(xsdPath));
                    unidadeElement.InnerText = ingrediente.Unidade.Name;
                    ingredienteElement.AppendChild(unidadeElement);

                    ingredientesElement.AppendChild(ingredienteElement);
                }
                receitaElement.AppendChild(ingredientesElement);

                XmlElement preparacaoElement = doc.CreateElement("preparacao", XMLHandler.TargetNamespace(xsdPath));
                preparacaoElement.InnerText = receitaLoop.Preparacao;
                receitaElement.AppendChild(preparacaoElement);

                // Adicionar a receita ao elemento raiz
                rootElement.AppendChild(receitaElement);
            }

            // Salvar as alterações no arquivo XML
            doc.Save(xmlPath);

        }
        else
        {
            throw new ArgumentException($"Receita com o ID {idReceita} não encontrada.");
        }
    }
}


public class IngredienteUnidade : Enumeration
{
    public static IngredienteUnidade Gramas => new(1, "Gramas");
    public static IngredienteUnidade Kilogramas => new(2, "Kilogramas");
    public static IngredienteUnidade Miligramas => new(3, "Miligramas");
    public static IngredienteUnidade Litros => new(4, "Litros");
    public static IngredienteUnidade Mililitros => new(5, "Mililitros");
    public static IngredienteUnidade ColheresDeCha => new(6, "Colheres de Chá");
    public static IngredienteUnidade ColheresDeSopa => new(7, "Colheres de Sopa");
    public static IngredienteUnidade Xicaras => new(8, "Xícaras");
    public static IngredienteUnidade Unidades => new(9, "Unidades");

    public IngredienteUnidade(int id, string name)
        : base(id, name)
    {
    }
}

public class Ingrediente
{
    public string Nome { get; set; }
    public decimal Quantidade { get; set; }
    public IngredienteUnidade Unidade { get; set; }
}
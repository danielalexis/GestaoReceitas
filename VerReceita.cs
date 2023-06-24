using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoReceitas
{
    public partial class VerReceita : Form
    {
        private Ingrediente ingrediente = new Ingrediente();
        private List<Ingrediente> ingredienteList = new();
        private Receita receita = new Receita();
        public VerReceita(int? id)
        {
            InitializeComponent();
            if (id != null)
            {
                // Carregar a lista de receitas
                List<Receita> listaReceitas = Receita.ListaReceitas("receitas.xml", "ReceitasSchema.xsd");
                // Procurar a receita com o id
                receita = listaReceitas.Find(x => x.Id == id);
                if (receita == null)
                {
                    MessageBox.Show("Não foi possível encontrar a receita!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ingredienteList = receita.Ingredientes;

                // Preencher os campos
                txtNome.Text = receita.Nome;
                cmbCategoria.Text = receita.Categoria;
                cmbDificuldade.Text = receita.Dificuldade;
                txtPorcoes.Text = receita.Porcoes.ToString();
                numTempo.Value = receita.Tempo;
                txtDescricao.Text = receita.Descricao;
                foreach (Ingrediente ingrediente in receita.Ingredientes)
                {
                    ListViewItem item = new ListViewItem(ingrediente.Nome);
                    item.SubItems.Add(ingrediente.Quantidade.ToString());
                    item.SubItems.Add(ingrediente.Unidade.ToString());
                    lstViewIngredientes.Items.Add(item);
                }
                txtPreparaco.Text = receita.Preparacao;
            }
        }

        private void btnAdiconarIngrediente_Click(object sender, EventArgs e)
        {
            bool valid = decimal.TryParse(txtQuantidadeIngrediente.Text, out decimal quantidade);
            if (!valid)
            {
                MessageBox.Show("A quantidade do ingrediente tem de ser um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtNomeIngrediente.Text) || quantidade <= 0 || string.IsNullOrEmpty(cmbUnidadeIngrediente.Text))
            {
                MessageBox.Show("Por favor preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ingrediente.Nome = txtNomeIngrediente.Text;
            ingrediente.Quantidade = quantidade;
            try
            {
                ingrediente.Unidade = Receita.ParseIngredienteUnidade(cmbUnidadeIngrediente.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ingredienteList.Add(ingrediente);

            // Adicionar à lista
            ListViewItem item = new ListViewItem(ingrediente.Nome);
            item.SubItems.Add(ingrediente.Quantidade.ToString());
            item.SubItems.Add(ingrediente.Unidade.ToString());
            lstViewIngredientes.Items.Add(item);
        }

        private void btnEliminarIngrediente_Click(object sender, EventArgs e)
        {
            // Eliminar da lista de ingredientes
            if (ingredienteList.Count > 0)
            {
                ingredienteList.RemoveAt(lstViewIngredientes.SelectedIndices[0]);
            }

            // Eliminar da lista
            if (lstViewIngredientes.SelectedItems.Count > 0)
            {
                lstViewIngredientes.Items.RemoveAt(lstViewIngredientes.SelectedIndices[0]);
            }

        }

        private void btnGravarReceita_Click(object sender, EventArgs e)
        {
            // Converte porcoes para decimal
            bool valid = decimal.TryParse(txtPorcoes.Text, out decimal porcoes);
            if (!valid)
            {
                MessageBox.Show("O número de porções tem de ser um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar se os campos estão preenchidos
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(cmbCategoria.Text) || string.IsNullOrEmpty(cmbDificuldade.Text) || 
                porcoes <= 0 || numTempo.Value <= 0 || string.IsNullOrEmpty(txtDescricao.Text) || string.IsNullOrEmpty(txtPreparaco.Text) || ingredienteList.Count <= 0)
            {
                MessageBox.Show("Por favor preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Adicionar a receita
            receita.Nome = txtNome.Text;
            receita.Categoria = cmbCategoria.Text;
            receita.Dificuldade = cmbDificuldade.Text;
            receita.Porcoes = porcoes;
            receita.Tempo = (int)numTempo.Value;
            receita.Descricao = txtDescricao.Text;
            receita.Preparacao = txtPreparaco.Text;
            receita.Ingredientes = ingredienteList;
            try
            {
                receita.AdicionarReceita("receitas.xml", "ReceitasSchema.xsd");
                MessageBox.Show("Receita adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Text = receita.Id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

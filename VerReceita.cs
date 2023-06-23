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
        public VerReceita()
        {
            InitializeComponent();
            receita.Ingredientes = ingredienteList;

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
                porcoes > 0 ||  || ingredienteList.Count == 0)
            {
                MessageBox.Show("Por favor preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

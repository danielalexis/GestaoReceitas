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
    public partial class Receita : Form
    {
        private Receitas.Ingrediente ingrediente = new Receitas.Ingrediente();
        private List<Receitas.Ingrediente> ingredienteList = new List<Receitas.Ingrediente>();
        private Receitas.Receita receita = new Receitas.Receita();
        public Receita()
        {
            InitializeComponent();
            receita.Ingredientes = ingredienteList;

        }

        private void btnAdiconarIngrediente_Click(object sender, EventArgs e)
        {
            bool valid = int.TryParse(txtQuantidadeIngrediente.Text, out int quantidade);
            if (!valid)
            {
                MessageBox.Show("A quantidade do ingrediente tem de ser um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (string.IsNullOrEmpty(txtNomeIngrediente.Text) || quantidade <= 0 || string.IsNullOrEmpty(cmbUnidadeIngrediente.Text))
            {
                MessageBox.Show("Por favor preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ingrediente.Quantidade = quantidade;
            ingrediente.Nome = txtNomeIngrediente.Text;
            ingrediente.Unidade = new Receitas().ParseIngredienteUnidade(cmbUnidadeIngrediente.Text);
            ingredienteList.Add(ingrediente);

            // Adicionar à lista
            ListViewItem item = new ListViewItem(ingrediente.Nome);
            item.SubItems.Add(ingrediente.Quantidade.ToString());
            item.SubItems.Add(ingrediente.Unidade.ToString());
            lstViewIngredientes.Items.Add(item);
        }

        private void btnEliminarIngrediente_Click(object sender, EventArgs e)
        {

        }
    }
}

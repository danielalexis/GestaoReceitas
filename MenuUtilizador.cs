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
    public partial class MenuUtilizador : Form
    {
        private Utilizador utilizador { get; set; }
        public MenuUtilizador(Utilizador utilizadorAntigo)
        {
            InitializeComponent();
            txtId.Text = utilizadorAntigo.Id.ToString();
            txtNome.Text = utilizadorAntigo.Nome;
            txtUsername.Text = utilizadorAntigo.Username;
            utilizador = utilizadorAntigo;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                utilizador.AlterarDados("utilizadores.xml","UtilizadoresSchema.xsd", txtNome.Text, txtNovaPassword.Text);
                MessageBox.Show("Utilizador alterado com sucesso! Poderá ter de reniciar a aplicação para que as alterações tomem efeito.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

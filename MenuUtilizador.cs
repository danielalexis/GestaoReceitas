using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
                if (!string.IsNullOrEmpty(txtNovaPassword.Text))
                {
                    SHA256 sha256 = SHA256.Create();
                    byte[] bytes = Encoding.UTF8.GetBytes(txtNovaPassword.Text);
                    byte[] hash = sha256.ComputeHash(bytes);
                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in hash)
                    {
                        sb.Append(b.ToString("X2"));
                    }
                    txtNovaPassword.Text = sb.ToString();
                }
                utilizador.AlterarDados("utilizadores.xml","UtilizadoresSchema.xsd", utilizador.Id ,txtNome.Text, txtNovaPassword.Text);
                MessageBox.Show("Utilizador alterado com sucesso! Poderá ter de reniciar a aplicação para que as alterações tomem efeito.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

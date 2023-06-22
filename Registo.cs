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
    public partial class Registo : Form
    {
        public Registo()
        {
            InitializeComponent();
        }

        private void btnRegisto_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Encriptar a password em SHA256
            SHA256 sha256 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(txtPassword.Text);
            byte[] hash = sha256.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("X2"));
            }
            txtPassword.Text = sb.ToString();
            /*try
            {
                */
            Utilizador.Criar("utilizadores.xml", "UtilizadoresSchema.xsd", txtNome.Text, txtUsername.Text, txtPassword.Text);
            /*} catch (Exception err)
            {
                MessageBox.Show(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}

using System.Xml;

namespace GestaoReceitas
{
    public partial class Login : Form
    {
        private int count = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Verificar se o nome de utilizador está correto
            Utilizador utilizador = new Utilizador(txtUsername.Text, txtPassword.Text);
            bool auth = utilizador.Autenticar("utilizadores.xml", "UtilizadoresSchema.xsd");
            if (auth && count <= 3) {
                Hide();
                new Dashboard(utilizador).ShowDialog();
                Close();
            } else if (count > 3) {
                MessageBox.Show("Número de tentativas excedido. Por favor contacte o IT Helpdesk", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            } else {
                count++;
                MessageBox.Show("Nome de utilizador ou password incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegisto_Click(object sender, EventArgs e)
        {
            new Registo().Show();
        }
    }
}
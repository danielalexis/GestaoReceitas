using System.Xml;

namespace GestaoReceitas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CriarXML(string xmlPath)
        {
            if (!File.Exists(xmlPath))
            {
                using (XmlWriter writer = XmlWriter.Create(xmlPath))
                {
                    // Escrever o elemento raiz e definir o namespace, se necessário
                    writer.WriteStartElement("receitas");
                    writer.WriteAttributeString("xmlns", "http://tempuri.org/Receitas.xsd");

                    // Finalizar a escrita e fechar o escritor XML
                    writer.WriteEndElement();
                    writer.Flush();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Verificar se o nome de utilizador está correto
            Utilizador utilizador = new Utilizador(txtUsername.Text, txtPassword.Text);
            utilizador.Autenticar("utilizadores.xml", "UtilizadoresSchema.xsd");
        }

        private void btnRegisto_Click(object sender, EventArgs e)
        {
            new Registo().Show();
        }



        private bool CheckUsernameExists(string filePath, string username)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    // Passar à frente o header
                    sr.ReadLine();

                    // Ler cada linha do csv
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] values = line.Split(',');

                        if (values.Length >= 1 && values[0] == username)
                        {
                            return true;
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

    }
}
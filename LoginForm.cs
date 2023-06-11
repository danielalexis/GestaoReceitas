namespace GestaoReceitas
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool checkFile()
        {
            string filePath = "users.csv";

            if (!File.Exists(filePath))
            {
                try
                {
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.WriteLine("username,password");
                    sw.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro a criar ficheiro de utilizadores.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string filePath = "users.csv";
            bool userFound = false;

            if (!checkFile()) { return; }

            try
            {
                StreamReader sr = new StreamReader(filePath);
                // Read the headers and check if they match the expected format
                string headerLine = sr.ReadLine();
                if (headerLine == null)
                {
                    MessageBox.Show("Formato CSV inválido. Headers esperados: username, password", "Formato CSV Errado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sr.Close();
                    return;
                }
                string[] headers = headerLine.Split(',');
                if (headers.Length < 2 || headers[0] != "username" || headers[1] != "password")
                {
                    MessageBox.Show("Formato CSV inválido. Headers esperados: username, password", "Formato CSV Errado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sr.Close();
                    return;
                }

                // Read each line of the CSV file
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split(',');


                    if (values.Length >= 2 && values[0] == txtUsername.Text && values[1] == txtPassword.Text)
                    {
                        Utilizador utilizador = new Utilizador(txtUsername.Text, txtPassword.Text);
                        userFound = true;
                        sr.Close();
                        SelectionForm selectionForm = new SelectionForm(utilizador);
                        selectionForm.Show();
                        Hide();
                        break;
                    }
                }

                if (!userFound)
                {
                    MessageBox.Show("Utilizador não encontrado", "Utilizador não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sr.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnRegisto_Click(object sender, EventArgs e)
        {
            string filePath = "users.csv";

            if (!checkFile()) { return; }

            try
            {
                string newUsername = txtUsername.Text.Trim();
                string newPassword = txtPassword.Text;

                if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword))
                {
                    MessageBox.Show("Por favor escreve o teu nome de utilizador e password", "Erro de Registo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (CheckUsernameExists(filePath, newUsername))
                {
                    MessageBox.Show("Nome de Utilizador já existe", "Erro de Registo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine($"{newUsername},{newPassword}");
                    sw.Close();
                }

                MessageBox.Show("Registo com sucesso, por favor inicia sessão", "Registo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                        if (values.Length >= 1 && values[0] == username) {
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
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
    public partial class VerReceitas : Form
    {
        public VerReceitas()
        {
            InitializeComponent();
        }

        private bool checkFile(string filePath)
        {
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

        private void VerReceitas_Load(object sender, EventArgs e)
        {
            string filePathReceitas = "receitas.csv";
            string filePathIngredientes = "ingredientes.csv";
            if (!checkFile(filePathReceitas)) { return; }
        }
    }
}

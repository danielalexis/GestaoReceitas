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
    public partial class SelectionForm : Form
    {
        private Utilizador utilizador { get; set; }
        internal SelectionForm(Utilizador utilizador)
        {
            InitializeComponent();
            this.utilizador = utilizador;
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = lblWelcome.Text + this.utilizador.Username;
        }

        private void btnCriarReceitas_Click(object sender, EventArgs e)
        {

        }


    }
}

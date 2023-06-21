using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace GestaoReceitas
{
    public partial class Dashboard : Form
    {
        private ListViewColumnSorter lvwColumnSorter;
        private Utilizador utilizador { get; set; }
        public Dashboard(Utilizador utilizador)
        {
            InitializeComponent();
            this.utilizador = utilizador;
            // Definir a mensagem de Bem-Vindo
            lstViewReceitas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstViewReceitas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvwColumnSorter = new ListViewColumnSorter();
            lstViewReceitas.ListViewItemSorter = lvwColumnSorter;
            /*ListViewItem item1 = new ListViewItem("Something");
            item1.SubItems.Add("SubItem1a");
            item1.SubItems.Add("SubItem1b");
            item1.SubItems.Add("SubItem1c");

            ListViewItem item2 = new ListViewItem("Something2");
            item2.SubItems.Add("SubItem2a");
            item2.SubItems.Add("SubItem2b");
            item2.SubItems.Add("SubItem2c");

            ListViewItem item3 = new ListViewItem("Something3");
            item3.SubItems.Add("SubItem3a");
            item3.SubItems.Add("SubItem3b");
            item3.SubItems.Add("SubItem3c");
            lstViewReceitas.Items.AddRange(new ListViewItem[] { item1, item2, item3 });*/
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblBemVindo.Text += utilizador.Username;
            Receitas receitas = new Receitas();
            List<Receitas.Receita> listaReceitas = receitas.ListaReceitas("receitas.xml", "ReceitasSchema.xsd");
            foreach (Receitas.Receita receita in listaReceitas)
            {
                ListViewItem item = new ListViewItem(receita.Id.ToString());
                item.SubItems.Add(receita.Nome);
                item.SubItems.Add(receita.Categoria);
                item.SubItems.Add(receita.Dificuldade);
                item.SubItems.Add(receita.Tempo);
                item.SubItems.Add(receita.Descricao);
                lstViewReceitas.Items.Add(item);
            }

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



        private void lstViewReceitas_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            lstViewReceitas.Sort();
        }

        private void lstViewReceitas_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            /*if (lstViewReceitas.SelectedItems.Count == 1) {
                
                ListViewItem.ListViewSubItemCollection items = ((ListViewI)sender).SubItems;
                foreach (ListViewItem item in items)
                {
                    MessageBox.Show(item.ToString());

                }
            } */

            //item.SubItems[];
        }

        private void picUserMenu_Click(object sender, EventArgs e)
        {
            MenuUtilizador menuUtilizador = new MenuUtilizador();
            menuUtilizador.Show();
        }
    }

}

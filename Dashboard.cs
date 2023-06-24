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
            lblBemVindo.Text += utilizador.Nome;
            Receita receita = new Receita();
            List<Receita> listaReceitas = Receita.ListaReceitas("receitas.xml", "ReceitasSchema.xsd");
            foreach (Receita receitaloop in listaReceitas)
            {
                ListViewItem item = new ListViewItem(receitaloop.Id.ToString());
                item.SubItems.Add(receitaloop.Nome);
                item.SubItems.Add(receitaloop.Categoria);
                item.SubItems.Add(receitaloop.Dificuldade);
                item.SubItems.Add(receitaloop.Tempo.ToString());
                item.SubItems.Add(receitaloop.Descricao);
                lstViewReceitas.Items.Add(item);
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
            MenuUtilizador menuUtilizador = new MenuUtilizador(utilizador);
            menuUtilizador.Show();
        }

        private void btnNovaReceita_Click(object sender, EventArgs e)
        {
            new VerReceita().ShowDialog();
            // Reload das receitas
            // Elimitar todas as receitas da listview
            lstViewReceitas.Items.Clear();
            List<Receita> listaReceitas = Receita.ListaReceitas("receitas.xml", "ReceitasSchema.xsd");
            foreach (Receita receita in listaReceitas)
            {
                ListViewItem item = new ListViewItem(receita.Id.ToString());
                item.SubItems.Add(receita.Nome);
                item.SubItems.Add(receita.Categoria);
                item.SubItems.Add(receita.Dificuldade);
                item.SubItems.Add(receita.Tempo.ToString());
                item.SubItems.Add(receita.Descricao);
                lstViewReceitas.Items.Add(item);
            }
        }

        private void btnApagarReceita_Click(object sender, EventArgs e)
        {
            if (lstViewReceitas.SelectedItems.Count > 0)
            {
                // lstViewReceitas.SelectedItems.SelectItemArray[0] é o id da receita
                // Apagar a receita do XML
                bool valid = int.TryParse(lstViewReceitas.SelectedItems[0].Text, out int id);
                if (!valid)
                {
                    MessageBox.Show("Erro ao apagar a receita");
                    return;
                }
                Receita.EliminarReceita("receitas.xml", "ReceitasSchema.xsd", id);

                // Reload das receitas
                // Elimitar todas as receitas da listview
                lstViewReceitas.Items.Clear();
                List<Receita> listaReceitas = Receita.ListaReceitas("receitas.xml", "ReceitasSchema.xsd");
                foreach (Receita receita in listaReceitas)
                {
                    ListViewItem item = new ListViewItem(receita.Id.ToString());
                    item.SubItems.Add(receita.Nome);
                    item.SubItems.Add(receita.Categoria);
                    item.SubItems.Add(receita.Dificuldade);
                    item.SubItems.Add(receita.Tempo.ToString());
                    item.SubItems.Add(receita.Descricao);
                    lstViewReceitas.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma receita para apagar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

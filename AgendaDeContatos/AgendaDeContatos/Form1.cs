using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaDeContatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SalvarECarregarContatos()
        {
            using (StreamWriter writerNomes = new StreamWriter("nomes.txt"))
            using (StreamWriter writerNumeros = new StreamWriter("numeros.txt"))
            {
                foreach (ListViewItem item in listViewContatos.Items)
                {
                    writerNomes.WriteLine(item.Text);
                    writerNumeros.WriteLine(item.SubItems[1].Text);
                }
            }

            if (File.Exists("nomes.txt"))
            {
                string[] nomes = File.ReadAllLines("nomes.txt");
                string[] numeros = File.ReadAllLines("numeros.txt");

                for (int i = 0; i < nomes.Length; i++)
                {
                    ListViewItem item = new ListViewItem(nomes[i]);
                    item.SubItems.Add(numeros[i]);
                    listViewContatos.Items.Add(item);
                }
            }
        }


        private void BtnEditar_Click_1(object sender, EventArgs e)
        {// Editar o contato selecionado no ListBox
            if (listViewContatos.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = (ListViewItem)listViewContatos.SelectedItems[0];
                selectedItem.Text = textBoxNome.Text;
                selectedItem.SubItems[1].Text = textBoxNumero.Text;
            }
        }

        private void BtnExcluir_Click_1(object sender, EventArgs e)
        {
            // Excluir o contato selecionado no ListView
            if (listViewContatos.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = (ListViewItem)listViewContatos.SelectedItems[0];
                listViewContatos.Items.Remove(selectedItem); // Remove o item selecionado
            }
        }
        private void listViewContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewContatos.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = (ListViewItem)listViewContatos.SelectedItems[0];
                textBoxNome.Text = selectedItem.Text;
                textBoxNumero.Text = selectedItem.SubItems[1].Text;
            }
        }

        private void btnSalvarECarregar_Click(object sender, EventArgs e)
        {
            SalvarECarregarContatos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SalvarECarregarContatos();
        }

        private void BtnAdicionar_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNome.Text) && !string.IsNullOrEmpty(textBoxNumero.Text))
            {
                ListViewItem item = new ListViewItem(textBoxNome.Text);
                item.SubItems.Add(textBoxNumero.Text);
                listViewContatos.Items.Add(item);


                textBoxNome.Text = "";
                textBoxNumero.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, preencha o nome e o número do contato.");
            }
        }
    }
}

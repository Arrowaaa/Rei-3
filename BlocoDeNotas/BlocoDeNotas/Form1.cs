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

namespace BlocoDeNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            File.WriteAllText("nota.txt", textBoxNota.Text);
            MessageBox.Show("Nota salva com sucesso!");
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (File.Exists("nota.txt"))
                textBoxNota.Text = File.ReadAllText("nota.txt");
            else
                MessageBox.Show("Nenhuma nota encontrada.");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText("nota.txt", textBoxNota.Text);
            MessageBox.Show("Nota salva com sucesso!");
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("nota.txt"))
                textBoxNota.Text = File.ReadAllText("nota.txt");
            else
                MessageBox.Show("Nenhuma nota encontrada.");
        }
        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }
    }
}

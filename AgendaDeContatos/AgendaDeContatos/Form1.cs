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

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {// Lógica para editar o contato selecionado no ListBox
            if (File.Exists("nome.txt"))
            {
                textBoxNome.Text = File.ReadAllText("nome.txt");
                textBoxNumero.Text = File.ReadAllText("numero.txt");
            }
            else
                MessageBox.Show("Nenhuma Contato encontrada.");
        }

        private void BtnExcluir_Click_1(object sender, EventArgs e)
        {// Lógica para excluir o contato selecionado no ListBox
        // Verifica se os arquivos correspondentes ao contato existem
   if (File.Exists("nome.txt") && File.Exists("numero.txt"))
   {
       // Exclui os arquivos correspondentes ao contato
       File.Delete("nome.txt");
       File.Delete("numero.txt");

       MessageBox.Show("Contato excluído com sucesso!");
   }
   else
   {
       MessageBox.Show("Nenhum contato encontrado.");
   }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            // Lógica para adicionar um novo contato à agenda
            File.WriteAllText("nome.txt", textBoxNome.Text);
            File.WriteAllText("numero.txt", textBoxNumero.Text);
            MessageBox.Show("Contato salva com sucesso!");
        }
    }
}

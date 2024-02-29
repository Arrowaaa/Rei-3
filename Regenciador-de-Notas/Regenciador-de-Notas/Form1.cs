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

namespace Regenciador_de_Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
 
            txbConteudo.Clear();
            txbNomeArquivo.Clear();

            Pasta = PastaDosArquivos; // Inicialize a variável Pasta aqui
            cbxArquivos.Items.Clear();

            CarregarNotas();
        }
        int timer = 2000;

        public string PastaDosArquivos
        {
            get
            {
                string pastaDoAplicativo = Application.StartupPath;
                string pastaDoArquivo = pastaDoAplicativo + "/arquivos/ex1/";
                return pastaDoArquivo;
            }

        }

        string Pasta = "";
        string Arquivo = "";
        private void CarregarNotas()
        {

            // Verifica se o diretório existe, caso contrário, cria-o
            if (!Directory.Exists(Pasta))
            {
                Directory.CreateDirectory(Pasta);
            }

            DirectoryInfo dir = new DirectoryInfo(Pasta);
            FileInfo[] arquivos = dir.GetFiles("*.*");
            foreach (FileInfo fi in arquivos)
            {
                cbxArquivos.Items.Add(fi.Name);
            }

        }

        private void btnSalvarNota_Click(object sender, EventArgs e)
        {
            string nomeDoArquivo = txbNomeArquivo.Text + ".txt";
            Arquivo = Pasta + nomeDoArquivo;

            if (!File.Exists(Arquivo))
            {

                using (StreamWriter sw = File.CreateText(Arquivo))
                {

                    sw.WriteLine(txbConteudo.Text);

                }

                lblAlert.Text = "";

                MessageBox.Show("Nota criada com sucesso!");

            }

            else
            {
                lblAlert.Text = "*Arquivo já existe";
            }

            CarregarNotas();
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            CarregarNotas();
        }

        private void cbxArquivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeDoArquivo = cbxArquivos.Text;
            Arquivo = Pasta + nomeDoArquivo;

            using (StreamReader sr = new StreamReader(Arquivo))
            {

                txbConteudoNota.Text = sr.ReadToEnd();

            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string arquivoAtualizar = cbxArquivos.Text;
            Arquivo = Pasta + arquivoAtualizar;

            if (File.Exists(Arquivo))
            {

                using (StreamWriter sw = File.CreateText(Arquivo))
                {

                    sw.WriteLine(txbConteudoNota.Text);

                }

                MessageBox.Show("Nota atualiza com sucesso!");

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string arquivoAtualizar = cbxArquivos.Text;
            string Arquivo = Pasta + arquivoAtualizar;

            if (File.Exists(Arquivo))
            {

                File.Delete(Arquivo);

                MessageBox.Show("Nota excluida com sucesso!");

            }

            CarregarNotas();
            cbxArquivos.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = timer;
            timer1.Enabled = true;

            Pasta = PastaDosArquivos;


            CarregarNotas();
        }


    }
}

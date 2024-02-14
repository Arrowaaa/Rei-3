using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeNotas
{
    public partial class Form1 : Form
    {
        private List<Nota> notas = new List<Nota>();
        private Nota nota;
        private object formEditarNota;

        public Nota NotaEditada { get; set; }

        public Form1()
        {
            InitializeComponent();
            NotaEditada = nota;
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            // Lógica para adicionar uma nova nota ao ListBox
            Nota novaNota = new Nota();
            notas.Add(novaNota);
            listBoxNotas.Items.Add(novaNota.Titulo);
        }

   

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            // Lógica para excluir a nota selecionada no ListBox
            if (listBoxNotas.SelectedIndex != -1)
            {
                notas.RemoveAt(listBoxNotas.SelectedIndex);
                listBoxNotas.Items.RemoveAt(listBoxNotas.SelectedIndex);
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            // Lógica para pesquisar notas com base em palavras-chave
            string palavraChave = textBoxPesquisa.Text.ToLower();
            listBoxNotas.Items.Clear();
            foreach (Nota nota in notas)
            {
                if (nota.Titulo.ToLower().Contains(palavraChave) || nota.Conteudo.ToLower().Contains(palavraChave))
                {
                    listBoxNotas.Items.Add(nota.Titulo);
                }
            }
        }

        private void BtnNegrito_Click(object sender, EventArgs e)
        {
            // Lógica para aplicar negrito ao texto selecionado no RichTextBox
            if (richTextBoxConteudo.SelectionFont != null)
            {
                richTextBoxConteudo.SelectionFont = new System.Drawing.Font(richTextBoxConteudo.SelectionFont, richTextBoxConteudo.SelectionFont.Style ^ FontStyle.Bold);
            }
        }

        private void BtnItalico_Click(object sender, EventArgs e)
        {
            // Lógica para aplicar itálico ao texto selecionado no RichTextBox
            if (richTextBoxConteudo.SelectionFont != null)
            {
                richTextBoxConteudo.SelectionFont = new System.Drawing.Font(richTextBoxConteudo.SelectionFont, richTextBoxConteudo.SelectionFont.Style ^ FontStyle.Italic);
            }
        }

        private void BtnSublinhado_Click(object sender, EventArgs e)
        {
            // Lógica para aplicar sublinhado ao texto selecionado no RichTextBox
            if (richTextBoxConteudo.SelectionFont != null)
            {
                richTextBoxConteudo.SelectionFont = new System.Drawing.Font(richTextBoxConteudo.SelectionFont, richTextBoxConteudo.SelectionFont.Style ^ FontStyle.Underline);
            }
        }
        public class Nota
        {
            public string Titulo { get; set; }
            public string Conteudo { get; set; }

        }

    }
}
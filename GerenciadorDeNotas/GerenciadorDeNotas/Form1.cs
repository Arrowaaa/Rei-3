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

            textBoxTituloEdicao = new TextBox();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            // Lógica para adicionar uma nova nota ao ListBox
            // Nota novaNota = new Nota();
            // novaNota.Titulo = "Nova Nota"; // Defina o título inicial
            // novaNota.Conteudo = richTextBoxConteudo.Text; // Armazene o conteúdo do RichTextBox
            // notas.Add(novaNota);
            // listBoxNotas.Items.Add(novaNota.Titulo);
            // Lógica para adicionar uma nova nota ao ListBox
            // Lógica para adicionar uma nova nota ao ListBox
            // Lógica para adicionar uma nova nota ao ListBox
            Nota novaNota = new Nota();

            // Divide o texto do richTextBoxConteudo em palavras
            string[] palavras = richTextBoxConteudo.Text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Adiciona a primeira palavra ao título da nova nota
            string titulo = palavras.Length > 0 ? palavras[0] : "Sem Título";

            // Adiciona o conteúdo completo como conteúdo da nota
            novaNota.Conteudo = richTextBoxConteudo.Text;

            // Adiciona a nova nota à lista
            notas.Add(novaNota);

            // Cria um novo item do ListBox com o título e a nota completa
            ListBoxItem itemListBox = new ListBoxItem();
            itemListBox.Titulo = titulo;
            itemListBox.NotaCompleta = novaNota;

            // Adiciona o item ao listBoxNotas
            listBoxNotas.Items.Add(itemListBox);
        }
        public class ListBoxItem
        {
            public string Titulo { get; set; }
            public Nota NotaCompleta { get; set; }

            public override string ToString()
            {
                return Titulo;
            }
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
            /*// Lógica para pesquisar notas com base em palavras-chave
            string palavraChave = textBoxPesquisa.Text.ToLower();
            listBoxNotas.Items.Clear();
            foreach (Nota nota in notas)
            {
                if (nota.Titulo.ToLower().Contains(palavraChave) || nota.Conteudo.ToLower().Contains(palavraChave))
                {
                    // Exibir tanto o título quanto o conteúdo da nota no listBoxNotas
                    listBoxNotas.Items.Add($"Título: {nota.Titulo}");
                    listBoxNotas.Items.Add($"Conteúdo: {nota.Conteudo}");
                    listBoxNotas.Items.Add(""); // Adicionar uma linha em branco para separar as notas
                }
            }*/
            string palavraChave = textBoxPesquisa.Text.ToLower();

            // Limpa a lista de seleção
            listBoxNotas.ClearSelected();

            // Itera sobre cada item na lista de notas
            foreach (ListBoxItem item in listBoxNotas.Items)
            {
                // Verifica se o título ou o conteúdo contêm a palavra-chave (ignorando maiúsculas e minúsculas)
                if (item.Titulo.ToLower().Contains(palavraChave) || item.NotaCompleta.Conteudo.ToLower().Contains(palavraChave))
                {
                    // Seleciona o item que contém a palavra-chave
                    listBoxNotas.SelectedItem = item;
                    break; // Sai do loop após encontrar o primeiro item correspondente
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            // Verifica se um item está selecionado
            if (listBoxNotas.SelectedItem != null)
            {
                // Acessa o item do ListBox
                ListBoxItem itemSelecionado = (ListBoxItem)listBoxNotas.SelectedItem;

                // Acessa a nota completa associada ao item selecionado
                Nota notaSelecionada = itemSelecionado.NotaCompleta;

                // Habilita a edição no richTextBoxConteudo
                richTextBoxConteudo.ReadOnly = false;
                richTextBoxConteudo.Focus(); // Coloca o foco no richTextBoxConteudo
            }
        }


        private TextBox textBoxTituloEdicao;

        private void listBoxNotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Quando uma nota é selecionada, exiba seu conteúdo no RichTextBox
            if (listBoxNotas.SelectedIndex != -1)
            {
                richTextBoxConteudo.Text = notas[listBoxNotas.SelectedIndex].Conteudo;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // Verifica se um item está selecionado
            if (listBoxNotas.SelectedItem != null)
            {
                // Acessa o item do ListBox
                ListBoxItem itemSelecionado = (ListBoxItem)listBoxNotas.SelectedItem;

                // Acessa a nota completa associada ao item selecionado
                Nota notaSelecionada = itemSelecionado.NotaCompleta;

                // Salva o conteúdo editado no richTextBoxConteudo na nota selecionada
                notaSelecionada.Conteudo = richTextBoxConteudo.Text;

                // Atualiza o título da nota tanto no objeto Nota quanto no item do ListBox
                notaSelecionada.Titulo = textBoxTituloEdicao.Text;
                itemSelecionado.Titulo = textBoxTituloEdicao.Text;

                // Atualiza o texto do item selecionado no ListBox para refletir as alterações
                listBoxNotas.Items[listBoxNotas.SelectedIndex] = itemSelecionado;

                // Desabilita a edição no richTextBoxConteudo
                richTextBoxConteudo.ReadOnly = true;
            }// Verifica se um item está selecionado
            if (listBoxNotas.SelectedItem != null)
            {
                // Acessa o item do ListBox
                ListBoxItem itemSelecionado = (ListBoxItem)listBoxNotas.SelectedItem;

                // Acessa a nota completa associada ao item selecionado
                Nota notaSelecionada = itemSelecionado.NotaCompleta;

                // Salva o conteúdo editado no richTextBoxConteudo na nota selecionada
                notaSelecionada.Conteudo = richTextBoxConteudo.Text;

                // Atualiza o título da nota tanto no objeto Nota quanto no item do ListBox
                notaSelecionada.Titulo = textBoxTituloEdicao.Text;
                itemSelecionado.Titulo = textBoxTituloEdicao.Text;

                // Atualiza o texto do item selecionado no ListBox para refletir as alterações
                listBoxNotas.Items[listBoxNotas.SelectedIndex] = itemSelecionado;

                // Desabilita a edição no richTextBoxConteudo
                richTextBoxConteudo.ReadOnly = true;
            }
        }
    }
}
using System;
using System.Windows.Forms;

namespace GerenciadorDeNotas
{
    internal class FormEditarNota
    {
        private Nota notaSelecionada;
        private Form1.Nota nota;

        public FormEditarNota(Nota notaSelecionada)
        {
            this.notaSelecionada = notaSelecionada;
        }

        public FormEditarNota(Form1.Nota nota)
        {
            this.nota = nota;
        }

        public Nota NotaEditada { get; internal set; }

        internal DialogResult ShowDialog()
        {
            throw new NotImplementedException();
        }
        public class Nota
        {
            public string Titulo { get; set; }
            public string Conteudo { get; set; }
            public string Categoria { get; set; }
        }
    }
}
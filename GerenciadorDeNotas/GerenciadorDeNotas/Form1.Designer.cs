namespace GerenciadorDeNotas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.listBoxNotas = new System.Windows.Forms.ListBox();
            this.richTextBoxConteudo = new System.Windows.Forms.RichTextBox();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.BtnSublinhado = new System.Windows.Forms.Button();
            this.BtnItalico = new System.Windows.Forms.Button();
            this.BtnNegrito = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionar.Location = new System.Drawing.Point(3, 341);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(127, 32);
            this.BtnAdicionar.TabIndex = 0;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(148, 341);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(82, 32);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.Red;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(258, 341);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(89, 32);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // listBoxNotas
            // 
            this.listBoxNotas.FormattingEnabled = true;
            this.listBoxNotas.Location = new System.Drawing.Point(7, 25);
            this.listBoxNotas.Name = "listBoxNotas";
            this.listBoxNotas.Size = new System.Drawing.Size(491, 134);
            this.listBoxNotas.TabIndex = 3;
            this.listBoxNotas.SelectedIndexChanged += new System.EventHandler(this.listBoxNotas_SelectedIndexChanged);
            // 
            // richTextBoxConteudo
            // 
            this.richTextBoxConteudo.Location = new System.Drawing.Point(12, 186);
            this.richTextBoxConteudo.Name = "richTextBoxConteudo";
            this.richTextBoxConteudo.Size = new System.Drawing.Size(486, 149);
            this.richTextBoxConteudo.TabIndex = 4;
            this.richTextBoxConteudo.Text = "";
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(524, 78);
            this.textBoxPesquisa.Multiline = true;
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(323, 42);
            this.textBoxPesquisa.TabIndex = 5;
            // 
            // BtnSublinhado
            // 
            this.BtnSublinhado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSublinhado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSublinhado.Location = new System.Drawing.Point(258, 379);
            this.BtnSublinhado.Name = "BtnSublinhado";
            this.BtnSublinhado.Size = new System.Drawing.Size(139, 32);
            this.BtnSublinhado.TabIndex = 9;
            this.BtnSublinhado.Text = "Sublinhado";
            this.BtnSublinhado.UseVisualStyleBackColor = false;
            this.BtnSublinhado.Click += new System.EventHandler(this.BtnSublinhado_Click);
            // 
            // BtnItalico
            // 
            this.BtnItalico.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnItalico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnItalico.Location = new System.Drawing.Point(128, 379);
            this.BtnItalico.Name = "BtnItalico";
            this.BtnItalico.Size = new System.Drawing.Size(102, 32);
            this.BtnItalico.TabIndex = 8;
            this.BtnItalico.Text = "Italico";
            this.BtnItalico.UseVisualStyleBackColor = false;
            this.BtnItalico.Click += new System.EventHandler(this.BtnItalico_Click);
            // 
            // BtnNegrito
            // 
            this.BtnNegrito.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnNegrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNegrito.Location = new System.Drawing.Point(14, 379);
            this.BtnNegrito.Name = "BtnNegrito";
            this.BtnNegrito.Size = new System.Drawing.Size(96, 32);
            this.BtnNegrito.TabIndex = 7;
            this.BtnNegrito.Text = "Negrito";
            this.BtnNegrito.UseVisualStyleBackColor = false;
            this.BtnNegrito.Click += new System.EventHandler(this.BtnNegrito_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.SystemColors.Desktop;
            this.BtnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPesquisar.Location = new System.Drawing.Point(623, 12);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(127, 32);
            this.BtnPesquisar.TabIndex = 10;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Este controle será usado para exibir a lista de notas.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Este controle será usado para exibir o conteúdo da nota selecionada e aplicar for" +
    "matação de texto (negrito, itálico, sublinhado).";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Este controle será usado para inserir palavras-chave para pesquisa.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 423);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnSublinhado);
            this.Controls.Add(this.BtnItalico);
            this.Controls.Add(this.BtnNegrito);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.richTextBoxConteudo);
            this.Controls.Add(this.listBoxNotas);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAdicionar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.ListBox listBoxNotas;
        private System.Windows.Forms.RichTextBox richTextBoxConteudo;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Button BtnSublinhado;
        private System.Windows.Forms.Button BtnItalico;
        private System.Windows.Forms.Button BtnNegrito;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}


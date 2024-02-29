namespace Regenciador_de_Notas
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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txbConteudoNota = new System.Windows.Forms.TextBox();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.cbxArquivos = new System.Windows.Forms.ComboBox();
            this.lblAlert = new System.Windows.Forms.Label();
            this.btnSalvarNota = new System.Windows.Forms.Button();
            this.txbConteudo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNomeArquivo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Yellow;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(383, 259);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(92, 28);
            this.btnAtualizar.TabIndex = 24;
            this.btnAtualizar.Text = "Atualizar nota";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnExcluir.Location = new System.Drawing.Point(481, 258);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(92, 28);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "Excluir nota";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txbConteudoNota
            // 
            this.txbConteudoNota.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txbConteudoNota.Location = new System.Drawing.Point(307, 80);
            this.txbConteudoNota.Multiline = true;
            this.txbConteudoNota.Name = "txbConteudoNota";
            this.txbConteudoNota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbConteudoNota.Size = new System.Drawing.Size(266, 174);
            this.txbConteudoNota.TabIndex = 22;
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRecarregar.FlatAppearance.BorderSize = 0;
            this.btnRecarregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecarregar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRecarregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRecarregar.Location = new System.Drawing.Point(470, 25);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(70, 31);
            this.btnRecarregar.TabIndex = 21;
            this.btnRecarregar.Text = "Buscar";
            this.btnRecarregar.UseVisualStyleBackColor = false;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // cbxArquivos
            // 
            this.cbxArquivos.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cbxArquivos.FormattingEnabled = true;
            this.cbxArquivos.Location = new System.Drawing.Point(333, 27);
            this.cbxArquivos.Name = "cbxArquivos";
            this.cbxArquivos.Size = new System.Drawing.Size(119, 29);
            this.cbxArquivos.TabIndex = 20;
            this.cbxArquivos.SelectedIndexChanged += new System.EventHandler(this.cbxArquivos_SelectedIndexChanged);
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.Tomato;
            this.lblAlert.Location = new System.Drawing.Point(108, 265);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(0, 17);
            this.lblAlert.TabIndex = 18;
            // 
            // btnSalvarNota
            // 
            this.btnSalvarNota.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvarNota.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSalvarNota.Location = new System.Drawing.Point(9, 259);
            this.btnSalvarNota.Name = "btnSalvarNota";
            this.btnSalvarNota.Size = new System.Drawing.Size(92, 28);
            this.btnSalvarNota.TabIndex = 17;
            this.btnSalvarNota.Text = "Salvar nota";
            this.btnSalvarNota.UseVisualStyleBackColor = false;
            this.btnSalvarNota.Click += new System.EventHandler(this.btnSalvarNota_Click);
            // 
            // txbConteudo
            // 
            this.txbConteudo.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txbConteudo.Location = new System.Drawing.Point(9, 80);
            this.txbConteudo.Multiline = true;
            this.txbConteudo.Name = "txbConteudo";
            this.txbConteudo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbConteudo.Size = new System.Drawing.Size(275, 174);
            this.txbConteudo.TabIndex = 16;
            this.txbConteudo.Text = "Conteúdo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 15;
            // 
            // txbNomeArquivo
            // 
            this.txbNomeArquivo.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txbNomeArquivo.Location = new System.Drawing.Point(12, 27);
            this.txbNomeArquivo.Name = "txbNomeArquivo";
            this.txbNomeArquivo.Size = new System.Drawing.Size(130, 29);
            this.txbNomeArquivo.TabIndex = 14;
            this.txbNomeArquivo.Text = "Nome da nota";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(-1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 25;
            this.button1.Text = "*";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(355, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ler nota";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 299);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txbConteudoNota);
            this.Controls.Add(this.btnRecarregar);
            this.Controls.Add(this.cbxArquivos);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.btnSalvarNota);
            this.Controls.Add(this.txbConteudo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNomeArquivo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txbConteudoNota;
        private System.Windows.Forms.Button btnRecarregar;
        private System.Windows.Forms.ComboBox cbxArquivos;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Button btnSalvarNota;
        private System.Windows.Forms.TextBox txbConteudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txbNomeArquivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}


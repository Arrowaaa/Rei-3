namespace AgendaDeContatos
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
            this.textBoxNome = new System.Windows.Forms.ComboBox();
            this.textBoxNumero = new System.Windows.Forms.ComboBox();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.listViewContatos = new System.Windows.Forms.ListBox();
            this.btnSalvarECarregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.FormattingEnabled = true;
            this.textBoxNome.Location = new System.Drawing.Point(45, 152);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(152, 21);
            this.textBoxNome.TabIndex = 1;
            this.textBoxNome.Text = "Nome";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.FormattingEnabled = true;
            this.textBoxNumero.Location = new System.Drawing.Point(45, 197);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(152, 21);
            this.textBoxNumero.TabIndex = 4;
            this.textBoxNumero.Text = "Número";
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionar.Location = new System.Drawing.Point(51, 426);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(111, 41);
            this.BtnAdicionar.TabIndex = 5;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click_1);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(188, 426);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(77, 43);
            this.BtnEditar.TabIndex = 6;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click_1);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(304, 433);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(87, 36);
            this.BtnExcluir.TabIndex = 7;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click_1);
            // 
            // listViewContatos
            // 
            this.listViewContatos.FormattingEnabled = true;
            this.listViewContatos.Location = new System.Drawing.Point(132, 105);
            this.listViewContatos.Name = "listViewContatos";
            this.listViewContatos.Size = new System.Drawing.Size(219, 251);
            this.listViewContatos.TabIndex = 8;
            this.listViewContatos.SelectedIndexChanged += new System.EventHandler(this.listViewContatos_SelectedIndexChanged);
            // 
            // btnSalvarECarregar
            // 
            this.btnSalvarECarregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvarECarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarECarregar.Location = new System.Drawing.Point(132, 371);
            this.btnSalvarECarregar.Name = "btnSalvarECarregar";
            this.btnSalvarECarregar.Size = new System.Drawing.Size(179, 49);
            this.btnSalvarECarregar.TabIndex = 9;
            this.btnSalvarECarregar.Text = "Salvar/Carregar";
            this.btnSalvarECarregar.UseVisualStyleBackColor = false;
            this.btnSalvarECarregar.Click += new System.EventHandler(this.btnSalvarECarregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgendaDeContatos.Properties.Resources.Captura_de_tela_2024_02_26_095129;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(457, 499);
            this.Controls.Add(this.btnSalvarECarregar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.listViewContatos);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox textBoxNome;
        private System.Windows.Forms.ComboBox textBoxNumero;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.ListBox listViewContatos;
        private System.Windows.Forms.Button btnSalvarECarregar;
    }
}


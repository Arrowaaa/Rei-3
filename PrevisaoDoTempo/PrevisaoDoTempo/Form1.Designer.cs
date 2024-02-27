namespace PrevisaoDoTempo
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
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.comboBoxCidades = new System.Windows.Forms.ComboBox();
            this.labelPrevisao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxIcone = new System.Windows.Forms.PictureBox();
            this.labelTempMax = new System.Windows.Forms.Label();
            this.labelTempMin = new System.Windows.Forms.Label();
            this.labelUmidade = new System.Windows.Forms.Label();
            this.labelInfoAdicional = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Location = new System.Drawing.Point(127, 312);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(86, 42);
            this.buttonConsultar.TabIndex = 0;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // comboBoxCidades
            // 
            this.comboBoxCidades.FormattingEnabled = true;
            this.comboBoxCidades.Location = new System.Drawing.Point(12, 33);
            this.comboBoxCidades.Name = "comboBoxCidades";
            this.comboBoxCidades.Size = new System.Drawing.Size(159, 21);
            this.comboBoxCidades.TabIndex = 1;
            this.comboBoxCidades.SelectedIndexChanged += new System.EventHandler(this.comboBoxCidades_SelectedIndexChanged);
            // 
            // labelPrevisao
            // 
            this.labelPrevisao.AutoSize = true;
            this.labelPrevisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrevisao.Location = new System.Drawing.Point(5, 171);
            this.labelPrevisao.Name = "labelPrevisao";
            this.labelPrevisao.Size = new System.Drawing.Size(77, 20);
            this.labelPrevisao.TabIndex = 2;
            this.labelPrevisao.Text = "Previsão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione a Cidade/Estado que deseja Consultar o Clima";
            // 
            // pictureBoxIcone
            // 
            this.pictureBoxIcone.Location = new System.Drawing.Point(112, 60);
            this.pictureBoxIcone.Name = "pictureBoxIcone";
            this.pictureBoxIcone.Size = new System.Drawing.Size(113, 90);
            this.pictureBoxIcone.TabIndex = 6;
            this.pictureBoxIcone.TabStop = false;
            // 
            // labelTempMax
            // 
            this.labelTempMax.AutoSize = true;
            this.labelTempMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempMax.Location = new System.Drawing.Point(6, 248);
            this.labelTempMax.Name = "labelTempMax";
            this.labelTempMax.Size = new System.Drawing.Size(78, 16);
            this.labelTempMax.TabIndex = 10;
            this.labelTempMax.Text = "Tem. Máx.";
            // 
            // labelTempMin
            // 
            this.labelTempMin.AutoSize = true;
            this.labelTempMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempMin.Location = new System.Drawing.Point(83, 272);
            this.labelTempMin.Name = "labelTempMin";
            this.labelTempMin.Size = new System.Drawing.Size(74, 16);
            this.labelTempMin.TabIndex = 11;
            this.labelTempMin.Text = "Tem. Min.";
            // 
            // labelUmidade
            // 
            this.labelUmidade.AutoSize = true;
            this.labelUmidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUmidade.Location = new System.Drawing.Point(177, 293);
            this.labelUmidade.Name = "labelUmidade";
            this.labelUmidade.Size = new System.Drawing.Size(70, 16);
            this.labelUmidade.TabIndex = 12;
            this.labelUmidade.Text = "Umidade";
            // 
            // labelInfoAdicional
            // 
            this.labelInfoAdicional.AutoSize = true;
            this.labelInfoAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoAdicional.Location = new System.Drawing.Point(5, 207);
            this.labelInfoAdicional.Name = "labelInfoAdicional";
            this.labelInfoAdicional.Size = new System.Drawing.Size(89, 20);
            this.labelInfoAdicional.TabIndex = 13;
            this.labelInfoAdicional.Text = "Descrição";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrevisaoDoTempo.Properties.Resources.Capturar;
            this.ClientSize = new System.Drawing.Size(345, 354);
            this.Controls.Add(this.labelInfoAdicional);
            this.Controls.Add(this.labelUmidade);
            this.Controls.Add(this.labelTempMin);
            this.Controls.Add(this.labelTempMax);
            this.Controls.Add(this.pictureBoxIcone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPrevisao);
            this.Controls.Add(this.comboBoxCidades);
            this.Controls.Add(this.buttonConsultar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.ComboBox comboBoxCidades;
        private System.Windows.Forms.Label labelPrevisao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxIcone;
        private System.Windows.Forms.Label labelTempMax;
        private System.Windows.Forms.Label labelTempMin;
        private System.Windows.Forms.Label labelUmidade;
        private System.Windows.Forms.Label labelInfoAdicional;
    }
}


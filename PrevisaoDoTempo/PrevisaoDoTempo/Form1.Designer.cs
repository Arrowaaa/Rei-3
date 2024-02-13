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
            this.comboBoxCidades = new System.Windows.Forms.ComboBox();
            this.labelPrevisaoTempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCidades
            // 
            this.comboBoxCidades.FormattingEnabled = true;
            this.comboBoxCidades.Location = new System.Drawing.Point(16, 78);
            this.comboBoxCidades.Name = "comboBoxCidades";
            this.comboBoxCidades.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCidades.TabIndex = 0;
            // 
            // labelPrevisaoTempo
            // 
            this.labelPrevisaoTempo.AutoSize = true;
            this.labelPrevisaoTempo.Location = new System.Drawing.Point(13, 45);
            this.labelPrevisaoTempo.Name = "labelPrevisaoTempo";
            this.labelPrevisaoTempo.Size = new System.Drawing.Size(101, 13);
            this.labelPrevisaoTempo.TabIndex = 1;
            this.labelPrevisaoTempo.Text = "Previsão Do Tempo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPrevisaoTempo);
            this.Controls.Add(this.comboBoxCidades);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCidades;
        private System.Windows.Forms.Label labelPrevisaoTempo;
    }
}


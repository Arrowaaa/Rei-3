namespace qrcode
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
            this.BTNGERAR = new System.Windows.Forms.Button();
            this.LB1 = new System.Windows.Forms.Label();
            this.lBLESCREVA = new System.Windows.Forms.Label();
            this.PIC_CODE = new System.Windows.Forms.PictureBox();
            this.TXT1 = new System.Windows.Forms.TextBox();
            this.BTNRESETAR = new System.Windows.Forms.Button();
            this.BTNSAIR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNGERAR
            // 
            this.BTNGERAR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNGERAR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNGERAR.Location = new System.Drawing.Point(409, 191);
            this.BTNGERAR.Name = "BTNGERAR";
            this.BTNGERAR.Size = new System.Drawing.Size(149, 82);
            this.BTNGERAR.TabIndex = 0;
            this.BTNGERAR.Text = "QRCODE";
            this.BTNGERAR.UseVisualStyleBackColor = false;
            this.BTNGERAR.Click += new System.EventHandler(this.BTNGERAR_Click);
            // 
            // LB1
            // 
            this.LB1.AutoSize = true;
            this.LB1.BackColor = System.Drawing.Color.DarkGreen;
            this.LB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB1.Location = new System.Drawing.Point(210, 9);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(176, 46);
            this.LB1.TabIndex = 1;
            this.LB1.Text = "QRCode";
            // 
            // lBLESCREVA
            // 
            this.lBLESCREVA.AutoSize = true;
            this.lBLESCREVA.BackColor = System.Drawing.Color.DarkGreen;
            this.lBLESCREVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLESCREVA.Location = new System.Drawing.Point(213, 104);
            this.lBLESCREVA.Name = "lBLESCREVA";
            this.lBLESCREVA.Size = new System.Drawing.Size(145, 29);
            this.lBLESCREVA.TabIndex = 2;
            this.lBLESCREVA.Text = "PREENCHA";
            // 
            // PIC_CODE
            // 
            this.PIC_CODE.Location = new System.Drawing.Point(12, 209);
            this.PIC_CODE.Name = "PIC_CODE";
            this.PIC_CODE.Size = new System.Drawing.Size(374, 315);
            this.PIC_CODE.TabIndex = 3;
            this.PIC_CODE.TabStop = false;
            // 
            // TXT1
            // 
            this.TXT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT1.Location = new System.Drawing.Point(10, 151);
            this.TXT1.Multiline = true;
            this.TXT1.Name = "TXT1";
            this.TXT1.Size = new System.Drawing.Size(546, 34);
            this.TXT1.TabIndex = 4;
            // 
            // BTNRESETAR
            // 
            this.BTNRESETAR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNRESETAR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNRESETAR.Location = new System.Drawing.Point(409, 319);
            this.BTNRESETAR.Name = "BTNRESETAR";
            this.BTNRESETAR.Size = new System.Drawing.Size(149, 82);
            this.BTNRESETAR.TabIndex = 6;
            this.BTNRESETAR.Text = "RESETAR";
            this.BTNRESETAR.UseVisualStyleBackColor = false;
            this.BTNRESETAR.Click += new System.EventHandler(this.BTNRESETAR_Click);
            // 
            // BTNSAIR
            // 
            this.BTNSAIR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNSAIR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNSAIR.Location = new System.Drawing.Point(409, 451);
            this.BTNSAIR.Name = "BTNSAIR";
            this.BTNSAIR.Size = new System.Drawing.Size(149, 82);
            this.BTNSAIR.TabIndex = 7;
            this.BTNSAIR.Text = "SAIR";
            this.BTNSAIR.UseVisualStyleBackColor = false;
            this.BTNSAIR.Click += new System.EventHandler(this.BTNSAIR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 346);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 545);
            this.ControlBox = false;
            this.Controls.Add(this.BTNSAIR);
            this.Controls.Add(this.BTNRESETAR);
            this.Controls.Add(this.TXT1);
            this.Controls.Add(this.PIC_CODE);
            this.Controls.Add(this.lBLESCREVA);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.BTNGERAR);
            this.Controls.Add(this.pictureBox1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PIC_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNGERAR;
        private System.Windows.Forms.Label LB1;
        private System.Windows.Forms.Label lBLESCREVA;
        private System.Windows.Forms.PictureBox PIC_CODE;
        private System.Windows.Forms.TextBox TXT1;
        private System.Windows.Forms.Button BTNRESETAR;
        private System.Windows.Forms.Button BTNSAIR;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


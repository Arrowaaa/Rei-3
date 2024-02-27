namespace Gerenciador_de_Tarefas
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.btnAdicionarTarefa = new System.Windows.Forms.Button();
            this.txbTarefa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(10, 316);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 23);
            this.btnLimpar.TabIndex = 30;
            this.btnLimpar.Text = "Limpar campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tarefa";
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(10, 196);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(125, 20);
            this.dtpVencimento.TabIndex = 23;
            // 
            // btnAdicionarTarefa
            // 
            this.btnAdicionarTarefa.Location = new System.Drawing.Point(10, 345);
            this.btnAdicionarTarefa.Name = "btnAdicionarTarefa";
            this.btnAdicionarTarefa.Size = new System.Drawing.Size(125, 23);
            this.btnAdicionarTarefa.TabIndex = 29;
            this.btnAdicionarTarefa.Text = "Adicionar tarefa";
            this.btnAdicionarTarefa.UseVisualStyleBackColor = true;
            this.btnAdicionarTarefa.Click += new System.EventHandler(this.btnAdicionarTarefa_Click);
            // 
            // txbTarefa
            // 
            this.txbTarefa.Location = new System.Drawing.Point(10, 33);
            this.txbTarefa.Name = "txbTarefa";
            this.txbTarefa.Size = new System.Drawing.Size(125, 20);
            this.txbTarefa.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Expira em:";
            // 
            // txbDesc
            // 
            this.txbDesc.Location = new System.Drawing.Point(10, 66);
            this.txbDesc.Multiline = true;
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(125, 105);
            this.txbDesc.TabIndex = 27;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(10, 373);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(125, 23);
            this.btnAtualizar.TabIndex = 24;
            this.btnAtualizar.Text = "Atualizar tarefa";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbTarefa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbDesc);
            this.panel1.Controls.Add(this.dtpVencimento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAdicionarTarefa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 401);
            this.panel1.TabIndex = 31;
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.AllowUserToAddRows = false;
            this.dgvTarefas.AllowUserToDeleteRows = false;
            this.dgvTarefas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTarefas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTarefas.Location = new System.Drawing.Point(145, 0);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.Size = new System.Drawing.Size(349, 401);
            this.dgvTarefas.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(11, 15);
            this.button1.TabIndex = 31;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 401);
            this.Controls.Add(this.dgvTarefas);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.Button btnAdicionarTarefa;
        private System.Windows.Forms.TextBox txbTarefa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Windows.Forms.Button button1;
    }
}


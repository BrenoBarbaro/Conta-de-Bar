namespace ControleContaDeBar
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
            this.label1 = new System.Windows.Forms.Label();
            this.ttlContadoTbx = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qtdPessoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aumenta10CBx = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalPorPessoa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adcionar_bTn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vUnitarioTbx = new System.Windows.Forms.TextBox();
            this.qtdTbx = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
            // 
            // ttlContadoTbx
            // 
            this.ttlContadoTbx.AutoSize = true;
            this.ttlContadoTbx.Location = new System.Drawing.Point(119, 37);
            this.ttlContadoTbx.Name = "ttlContadoTbx";
            this.ttlContadoTbx.Size = new System.Drawing.Size(28, 13);
            this.ttlContadoTbx.TabIndex = 1;
            this.ttlContadoTbx.Text = "0,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Qtd de pessoas:";
            // 
            // qtdPessoa
            // 
            this.qtdPessoa.Location = new System.Drawing.Point(122, 75);
            this.qtdPessoa.Name = "qtdPessoa";
            this.qtdPessoa.Size = new System.Drawing.Size(130, 20);
            this.qtdPessoa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Incluir 10%";
            // 
            // aumenta10CBx
            // 
            this.aumenta10CBx.AutoSize = true;
            this.aumenta10CBx.Location = new System.Drawing.Point(122, 115);
            this.aumenta10CBx.Name = "aumenta10CBx";
            this.aumenta10CBx.Size = new System.Drawing.Size(43, 17);
            this.aumenta10CBx.TabIndex = 5;
            this.aumenta10CBx.Text = "Sim";
            this.aumenta10CBx.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total por pessoa:";
            // 
            // totalPorPessoa
            // 
            this.totalPorPessoa.AutoSize = true;
            this.totalPorPessoa.Location = new System.Drawing.Point(119, 149);
            this.totalPorPessoa.Name = "totalPorPessoa";
            this.totalPorPessoa.Size = new System.Drawing.Size(28, 13);
            this.totalPorPessoa.TabIndex = 7;
            this.totalPorPessoa.Text = "0,00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.qtdTbx);
            this.groupBox1.Controls.Add(this.vUnitarioTbx);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.adcionar_bTn);
            this.groupBox1.Location = new System.Drawing.Point(12, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 148);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Despesas";
            // 
            // adcionar_bTn
            // 
            this.adcionar_bTn.Location = new System.Drawing.Point(149, 98);
            this.adcionar_bTn.Name = "adcionar_bTn";
            this.adcionar_bTn.Size = new System.Drawing.Size(91, 25);
            this.adcionar_bTn.TabIndex = 0;
            this.adcionar_bTn.Text = "Adicionar";
            this.adcionar_bTn.UseVisualStyleBackColor = true;
            this.adcionar_bTn.Click += new System.EventHandler(this.adcionar_bTn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Valor Unitario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Quantidade:";
            // 
            // vUnitarioTbx
            // 
            this.vUnitarioTbx.Location = new System.Drawing.Point(110, 27);
            this.vUnitarioTbx.Name = "vUnitarioTbx";
            this.vUnitarioTbx.Size = new System.Drawing.Size(130, 20);
            this.vUnitarioTbx.TabIndex = 3;
            // 
            // qtdTbx
            // 
            this.qtdTbx.Location = new System.Drawing.Point(110, 60);
            this.qtdTbx.Name = "qtdTbx";
            this.qtdTbx.Size = new System.Drawing.Size(130, 20);
            this.qtdTbx.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 341);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.totalPorPessoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aumenta10CBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qtdPessoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ttlContadoTbx);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conta de Bar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ttlContadoTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox qtdPessoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox aumenta10CBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalPorPessoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button adcionar_bTn;
        private System.Windows.Forms.TextBox qtdTbx;
        private System.Windows.Forms.TextBox vUnitarioTbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}


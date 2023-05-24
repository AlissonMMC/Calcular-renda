namespace CalculadoraFamiliar
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
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGasto = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnergia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAgua = new System.Windows.Forms.TextBox();
            this.txtTv = new System.Windows.Forms.TextBox();
            this.txtAlimentecao = new System.Windows.Forms.TextBox();
            this.txtOutros = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renda Familiar:";
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(150, 38);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(202, 20);
            this.txtRenda.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(196, 382);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Novo Calculo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(311, 382);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(90, 23);
            this.btnFechar.TabIndex = 15;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(91, 382);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 23);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total de Gastos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 485);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Saldo:";
            // 
            // lblGasto
            // 
            this.lblGasto.AutoSize = true;
            this.lblGasto.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGasto.Location = new System.Drawing.Point(284, 455);
            this.lblGasto.Name = "lblGasto";
            this.lblGasto.Size = new System.Drawing.Size(45, 13);
            this.lblGasto.TabIndex = 19;
            this.lblGasto.Text = "R$ 0,00";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSaldo.Location = new System.Drawing.Point(284, 485);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(45, 13);
            this.lblSaldo.TabIndex = 20;
            this.lblSaldo.Text = "R$ 0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Energia Elétrica:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEnergia
            // 
            this.txtEnergia.Location = new System.Drawing.Point(117, 40);
            this.txtEnergia.Name = "txtEnergia";
            this.txtEnergia.Size = new System.Drawing.Size(148, 20);
            this.txtEnergia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Água:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tv / Fone / Internet:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Alimentação:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Outros:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAgua
            // 
            this.txtAgua.Location = new System.Drawing.Point(117, 83);
            this.txtAgua.Name = "txtAgua";
            this.txtAgua.Size = new System.Drawing.Size(148, 20);
            this.txtAgua.TabIndex = 9;
            // 
            // txtTv
            // 
            this.txtTv.Location = new System.Drawing.Point(117, 122);
            this.txtTv.Name = "txtTv";
            this.txtTv.Size = new System.Drawing.Size(148, 20);
            this.txtTv.TabIndex = 10;
            // 
            // txtAlimentecao
            // 
            this.txtAlimentecao.Location = new System.Drawing.Point(117, 163);
            this.txtAlimentecao.Name = "txtAlimentecao";
            this.txtAlimentecao.Size = new System.Drawing.Size(148, 20);
            this.txtAlimentecao.TabIndex = 11;
            // 
            // txtOutros
            // 
            this.txtOutros.Location = new System.Drawing.Point(117, 203);
            this.txtOutros.Name = "txtOutros";
            this.txtOutros.Size = new System.Drawing.Size(148, 20);
            this.txtOutros.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOutros);
            this.groupBox1.Controls.Add(this.txtAlimentecao);
            this.groupBox1.Controls.Add(this.txtTv);
            this.groupBox1.Controls.Add(this.txtAgua);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEnergia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(79, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 245);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gasto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblGasto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtRenda);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGasto;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnergia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAgua;
        private System.Windows.Forms.TextBox txtTv;
        private System.Windows.Forms.TextBox txtAlimentecao;
        private System.Windows.Forms.TextBox txtOutros;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


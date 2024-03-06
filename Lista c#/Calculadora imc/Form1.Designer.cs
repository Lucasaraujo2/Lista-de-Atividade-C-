namespace Calculadora_imc
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.lbPeso = new System.Windows.Forms.Label();
            this.txbPeso_atual = new System.Windows.Forms.TextBox();
            this.lbAltura = new System.Windows.Forms.Label();
            this.lbIMC = new System.Windows.Forms.Label();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.radio_Homem = new System.Windows.Forms.RadioButton();
            this.radio_Mulher = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(331, 255);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Location = new System.Drawing.Point(409, 171);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(79, 13);
            this.lbPeso.TabIndex = 1;
            this.lbPeso.Text = "Peso Ideal (Kg)";
            // 
            // txbPeso_atual
            // 
            this.txbPeso_atual.Location = new System.Drawing.Point(402, 196);
            this.txbPeso_atual.Name = "txbPeso_atual";
            this.txbPeso_atual.Size = new System.Drawing.Size(100, 20);
            this.txbPeso_atual.TabIndex = 2;
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(239, 171);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(78, 13);
            this.lbAltura.TabIndex = 3;
            this.lbAltura.Text = "Altura (Metros):";
            // 
            // lbIMC
            // 
            this.lbIMC.AutoSize = true;
            this.lbIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIMC.Location = new System.Drawing.Point(236, 62);
            this.lbIMC.Name = "lbIMC";
            this.lbIMC.Size = new System.Drawing.Size(277, 31);
            this.lbIMC.TabIndex = 4;
            this.lbIMC.Text = "Calculo do Peso Ideal";
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(229, 196);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(100, 20);
            this.txbAltura.TabIndex = 5;
            this.txbAltura.TextChanged += new System.EventHandler(this.txbAltura_TextChanged);
            // 
            // radio_Homem
            // 
            this.radio_Homem.AutoSize = true;
            this.radio_Homem.Location = new System.Drawing.Point(242, 132);
            this.radio_Homem.Name = "radio_Homem";
            this.radio_Homem.Size = new System.Drawing.Size(61, 17);
            this.radio_Homem.TabIndex = 6;
            this.radio_Homem.TabStop = true;
            this.radio_Homem.Text = "Homem";
            this.radio_Homem.UseVisualStyleBackColor = true;
            // 
            // radio_Mulher
            // 
            this.radio_Mulher.AutoSize = true;
            this.radio_Mulher.Location = new System.Drawing.Point(412, 132);
            this.radio_Mulher.Name = "radio_Mulher";
            this.radio_Mulher.Size = new System.Drawing.Size(57, 17);
            this.radio_Mulher.TabIndex = 7;
            this.radio_Mulher.TabStop = true;
            this.radio_Mulher.Text = "Mulher";
            this.radio_Mulher.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 411);
            this.Controls.Add(this.radio_Mulher);
            this.Controls.Add(this.radio_Homem);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.lbIMC);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.txbPeso_atual);
            this.Controls.Add(this.lbPeso);
            this.Controls.Add(this.btncalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.TextBox txbPeso_atual;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.Label lbIMC;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.RadioButton radio_Homem;
        private System.Windows.Forms.RadioButton radio_Mulher;
    }
}


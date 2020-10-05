namespace Calculadora_em_Csharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Soma = new System.Windows.Forms.Button();
            this.subitrair = new System.Windows.Forms.Button();
            this.Multiplica = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.txtprimeiro = new System.Windows.Forms.TextBox();
            this.txtsegundo = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Soma
            // 
            this.Soma.Location = new System.Drawing.Point(178, 12);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(75, 23);
            this.Soma.TabIndex = 0;
            this.Soma.Text = "+";
            this.Soma.UseVisualStyleBackColor = true;
            this.Soma.Click += new System.EventHandler(this.button1_Click);
            // 
            // subitrair
            // 
            this.subitrair.Location = new System.Drawing.Point(178, 41);
            this.subitrair.Name = "subitrair";
            this.subitrair.Size = new System.Drawing.Size(75, 23);
            this.subitrair.TabIndex = 1;
            this.subitrair.Text = "-";
            this.subitrair.UseVisualStyleBackColor = true;
            // 
            // Multiplica
            // 
            this.Multiplica.Location = new System.Drawing.Point(259, 12);
            this.Multiplica.Name = "Multiplica";
            this.Multiplica.Size = new System.Drawing.Size(75, 23);
            this.Multiplica.TabIndex = 2;
            this.Multiplica.Text = "X";
            this.Multiplica.UseVisualStyleBackColor = true;
            // 
            // dividir
            // 
            this.dividir.Location = new System.Drawing.Point(259, 41);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(75, 23);
            this.dividir.TabIndex = 3;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = true;
            // 
            // txtprimeiro
            // 
            this.txtprimeiro.Location = new System.Drawing.Point(12, 12);
            this.txtprimeiro.Name = "txtprimeiro";
            this.txtprimeiro.Size = new System.Drawing.Size(156, 20);
            this.txtprimeiro.TabIndex = 4;
            // 
            // txtsegundo
            // 
            this.txtsegundo.Location = new System.Drawing.Point(12, 37);
            this.txtsegundo.Name = "txtsegundo";
            this.txtsegundo.Size = new System.Drawing.Size(156, 20);
            this.txtsegundo.TabIndex = 5;
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(12, 91);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(318, 20);
            this.resultado.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 123);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.txtsegundo);
            this.Controls.Add(this.txtprimeiro);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.Multiplica);
            this.Controls.Add(this.subitrair);
            this.Controls.Add(this.Soma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button subitrair;
        private System.Windows.Forms.Button Multiplica;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.TextBox txtprimeiro;
        private System.Windows.Forms.TextBox txtsegundo;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Label label1;
    }
}


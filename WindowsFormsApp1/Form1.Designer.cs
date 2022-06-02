namespace WindowsFormsApp1
{
    partial class fResolveGramatica
    {
        private System.ComponentModel.IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.tbG = new System.Windows.Forms.TextBox();
            this.gramatica = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.tbT = new System.Windows.Forms.TextBox();
            this.tbP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.gerarGramatica);
            // 
            // tbG
            // 
            this.tbG.Location = new System.Drawing.Point(30, 38);
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(162, 20);
            this.tbG.TabIndex = 1;
            // 
            // gramatica
            // 
            this.gramatica.AutoSize = true;
            this.gramatica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gramatica.Location = new System.Drawing.Point(27, 9);
            this.gramatica.Name = "gramatica";
            this.gramatica.Size = new System.Drawing.Size(83, 20);
            this.gramatica.TabIndex = 2;
            this.gramatica.Text = "Gramática";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(28, 116);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(82, 20);
            this.resultado.TabIndex = 3;
            this.resultado.Text = "Resultado";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(29, 154);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 4;
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(299, 40);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 20);
            this.tbN.TabIndex = 5;
            // 
            // tbT
            // 
            this.tbT.Location = new System.Drawing.Point(299, 66);
            this.tbT.Name = "tbT";
            this.tbT.Size = new System.Drawing.Size(100, 20);
            this.tbT.TabIndex = 6;
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(299, 92);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(100, 20);
            this.tbP.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "T";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "P";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpar Inf";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fResolveGramatica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 246);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.tbT);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.result);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.gramatica);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.button1);
            this.Name = "fResolveGramatica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resolve Gramatica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbG;
        private System.Windows.Forms.Label gramatica;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.TextBox tbT;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}


namespace CalculoAreas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.ResultadoCirculo = new System.Windows.Forms.Label();
            this.ResultadoTriangulo = new System.Windows.Forms.Label();
            this.ResultadoCuadrado = new System.Windows.Forms.Label();
            this.RADIO = new System.Windows.Forms.TextBox();
            this.ALTURA = new System.Windows.Forms.TextBox();
            this.BASE = new System.Windows.Forms.TextBox();
            this.LADO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CALCULAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "LADO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ResultadoCirculo
            // 
            this.ResultadoCirculo.AutoSize = true;
            this.ResultadoCirculo.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoCirculo.ForeColor = System.Drawing.Color.SlateBlue;
            this.ResultadoCirculo.Location = new System.Drawing.Point(232, 231);
            this.ResultadoCirculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResultadoCirculo.Name = "ResultadoCirculo";
            this.ResultadoCirculo.Size = new System.Drawing.Size(25, 27);
            this.ResultadoCirculo.TabIndex = 48;
            this.ResultadoCirculo.Text = "0";
            // 
            // ResultadoTriangulo
            // 
            this.ResultadoTriangulo.AutoSize = true;
            this.ResultadoTriangulo.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoTriangulo.ForeColor = System.Drawing.Color.SlateBlue;
            this.ResultadoTriangulo.Location = new System.Drawing.Point(372, 115);
            this.ResultadoTriangulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResultadoTriangulo.Name = "ResultadoTriangulo";
            this.ResultadoTriangulo.Size = new System.Drawing.Size(25, 27);
            this.ResultadoTriangulo.TabIndex = 47;
            this.ResultadoTriangulo.Text = "0";
            // 
            // ResultadoCuadrado
            // 
            this.ResultadoCuadrado.AutoSize = true;
            this.ResultadoCuadrado.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoCuadrado.ForeColor = System.Drawing.Color.SlateBlue;
            this.ResultadoCuadrado.Location = new System.Drawing.Point(123, 99);
            this.ResultadoCuadrado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResultadoCuadrado.Name = "ResultadoCuadrado";
            this.ResultadoCuadrado.Size = new System.Drawing.Size(25, 27);
            this.ResultadoCuadrado.TabIndex = 46;
            this.ResultadoCuadrado.Text = "0";
            // 
            // RADIO
            // 
            this.RADIO.Location = new System.Drawing.Point(182, 184);
            this.RADIO.Margin = new System.Windows.Forms.Padding(2);
            this.RADIO.Name = "RADIO";
            this.RADIO.Size = new System.Drawing.Size(132, 20);
            this.RADIO.TabIndex = 45;
            // 
            // ALTURA
            // 
            this.ALTURA.Location = new System.Drawing.Point(318, 82);
            this.ALTURA.Margin = new System.Windows.Forms.Padding(2);
            this.ALTURA.Name = "ALTURA";
            this.ALTURA.Size = new System.Drawing.Size(132, 20);
            this.ALTURA.TabIndex = 44;
            // 
            // BASE
            // 
            this.BASE.Location = new System.Drawing.Point(318, 41);
            this.BASE.Margin = new System.Windows.Forms.Padding(2);
            this.BASE.Name = "BASE";
            this.BASE.Size = new System.Drawing.Size(132, 20);
            this.BASE.TabIndex = 43;
            this.BASE.TextChanged += new System.EventHandler(this.Base_TextChanged);
            // 
            // LADO
            // 
            this.LADO.Location = new System.Drawing.Point(89, 55);
            this.LADO.Margin = new System.Windows.Forms.Padding(2);
            this.LADO.Name = "LADO";
            this.LADO.Size = new System.Drawing.Size(132, 20);
            this.LADO.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(115, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "RADIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label6.Location = new System.Drawing.Point(203, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "CIRCULO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(298, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(298, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(330, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "TRIANGULO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "CUADRADO";
            // 
            // CALCULAR
            // 
            this.CALCULAR.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CALCULAR.Location = new System.Drawing.Point(377, 185);
            this.CALCULAR.Margin = new System.Windows.Forms.Padding(2);
            this.CALCULAR.Name = "CALCULAR";
            this.CALCULAR.Size = new System.Drawing.Size(104, 30);
            this.CALCULAR.TabIndex = 35;
            this.CALCULAR.Text = "CALCULAR";
            this.CALCULAR.UseVisualStyleBackColor = true;
            this.CALCULAR.Click += new System.EventHandler(this.CALCULAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultadoCirculo);
            this.Controls.Add(this.ResultadoTriangulo);
            this.Controls.Add(this.ResultadoCuadrado);
            this.Controls.Add(this.RADIO);
            this.Controls.Add(this.ALTURA);
            this.Controls.Add(this.BASE);
            this.Controls.Add(this.LADO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CALCULAR);
            this.Name = "Form1";
            this.Text = "CALCULAR AREAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ResultadoCirculo;
        private System.Windows.Forms.Label ResultadoTriangulo;
        private System.Windows.Forms.Label ResultadoCuadrado;
        private System.Windows.Forms.TextBox RADIO;
        private System.Windows.Forms.TextBox ALTURA;
        private System.Windows.Forms.TextBox BASE;
        private System.Windows.Forms.TextBox LADO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CALCULAR;
    }
}


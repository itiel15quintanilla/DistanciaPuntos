namespace DistanciaPuntosC
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
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.TextBoxYB = new System.Windows.Forms.TextBox();
            this.TextBoxXB = new System.Windows.Forms.TextBox();
            this.TextBoxYA = new System.Windows.Forms.TextBox();
            this.TextBoxXA = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(66, 377);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(76, 17);
            this.Label7.TabIndex = 25;
            this.Label7.Text = "Resultado:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(66, 265);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(17, 17);
            this.Label6.TabIndex = 24;
            this.Label6.Text = "Y";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(66, 225);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(17, 17);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "X";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(66, 121);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(17, 17);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Y";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(66, 86);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(17, 17);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "X";
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(150, 375);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(100, 22);
            this.TxtResultado.TabIndex = 20;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(53, 323);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(197, 23);
            this.Calcular.TabIndex = 19;
            this.Calcular.Text = "Calcula la distancia ";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // TextBoxYB
            // 
            this.TextBoxYB.Location = new System.Drawing.Point(89, 262);
            this.TextBoxYB.Name = "TextBoxYB";
            this.TextBoxYB.Size = new System.Drawing.Size(100, 22);
            this.TextBoxYB.TabIndex = 18;
            // 
            // TextBoxXB
            // 
            this.TextBoxXB.Location = new System.Drawing.Point(89, 222);
            this.TextBoxXB.Name = "TextBoxXB";
            this.TextBoxXB.Size = new System.Drawing.Size(100, 22);
            this.TextBoxXB.TabIndex = 17;
            // 
            // TextBoxYA
            // 
            this.TextBoxYA.Location = new System.Drawing.Point(89, 121);
            this.TextBoxYA.Name = "TextBoxYA";
            this.TextBoxYA.Size = new System.Drawing.Size(100, 22);
            this.TextBoxYA.TabIndex = 16;
            // 
            // TextBoxXA
            // 
            this.TextBoxXA.Location = new System.Drawing.Point(89, 83);
            this.TextBoxXA.Name = "TextBoxXA";
            this.TextBoxXA.Size = new System.Drawing.Size(100, 22);
            this.TextBoxXA.TabIndex = 15;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(93, 189);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 17);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Punto B";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(93, 44);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 17);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Punto A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 432);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.TextBoxYB);
            this.Controls.Add(this.TextBoxXB);
            this.Controls.Add(this.TextBoxYA);
            this.Controls.Add(this.TextBoxXA);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TxtResultado;
        internal System.Windows.Forms.Button Calcular;
        internal System.Windows.Forms.TextBox TextBoxYB;
        internal System.Windows.Forms.TextBox TextBoxXB;
        internal System.Windows.Forms.TextBox TextBoxYA;
        internal System.Windows.Forms.TextBox TextBoxXA;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}


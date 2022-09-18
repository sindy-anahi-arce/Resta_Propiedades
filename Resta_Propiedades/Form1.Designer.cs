
namespace Resta_Propiedades
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnResta = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(170, 286);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 28);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(87, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "RESTA";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 216);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(76, 22);
            this.textBox3.TabIndex = 18;
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(78, 286);
            this.btnResta.Margin = new System.Windows.Forms.Padding(2);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(63, 26);
            this.btnResta.TabIndex = 17;
            this.btnResta.Text = "Restar";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(123, 159);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 22);
            this.txtNum2.TabIndex = 16;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(123, 102);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 22);
            this.txtNum1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Resultado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Número 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Número 1:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 342);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}



namespace tp2.WinFormsUI
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPunto1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.btnPunto2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPunto3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPunto4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPunto1);
            this.groupBox1.Location = new System.Drawing.Point(50, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Punto 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Divisor = 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dividendo = 10";
            // 
            // btnPunto1
            // 
            this.btnPunto1.Location = new System.Drawing.Point(16, 95);
            this.btnPunto1.Name = "btnPunto1";
            this.btnPunto1.Size = new System.Drawing.Size(165, 23);
            this.btnPunto1.TabIndex = 0;
            this.btnPunto1.Text = "Ejecutar Primer Punto";
            this.btnPunto1.UseVisualStyleBackColor = true;
            this.btnPunto1.Click += new System.EventHandler(this.btnPunto1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDivisor);
            this.groupBox2.Controls.Add(this.txtDividendo);
            this.groupBox2.Controls.Add(this.btnPunto2);
            this.groupBox2.Location = new System.Drawing.Point(291, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Punto 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Divisor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dividendo";
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(79, 57);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(100, 23);
            this.txtDivisor.TabIndex = 2;
            this.txtDivisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(79, 28);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(100, 23);
            this.txtDividendo.TabIndex = 1;
            this.txtDividendo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPunto2
            // 
            this.btnPunto2.Location = new System.Drawing.Point(12, 95);
            this.btnPunto2.Name = "btnPunto2";
            this.btnPunto2.Size = new System.Drawing.Size(167, 23);
            this.btnPunto2.TabIndex = 0;
            this.btnPunto2.Text = "Ejecutar Segundo Punto";
            this.btnPunto2.UseVisualStyleBackColor = true;
            this.btnPunto2.Click += new System.EventHandler(this.btnPunto2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPunto3);
            this.groupBox3.Location = new System.Drawing.Point(50, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Punto 3";
            // 
            // btnPunto3
            // 
            this.btnPunto3.Location = new System.Drawing.Point(16, 71);
            this.btnPunto3.Name = "btnPunto3";
            this.btnPunto3.Size = new System.Drawing.Size(165, 23);
            this.btnPunto3.TabIndex = 0;
            this.btnPunto3.Text = "Ejecutar Tercer Punto";
            this.btnPunto3.UseVisualStyleBackColor = true;
            this.btnPunto3.Click += new System.EventHandler(this.btnPunto3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPunto4);
            this.groupBox4.Location = new System.Drawing.Point(291, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Punto 4";
            // 
            // btnPunto4
            // 
            this.btnPunto4.Location = new System.Drawing.Point(12, 71);
            this.btnPunto4.Name = "btnPunto4";
            this.btnPunto4.Size = new System.Drawing.Size(167, 23);
            this.btnPunto4.TabIndex = 0;
            this.btnPunto4.Text = "Ejecutar Cuarto Punto";
            this.btnPunto4.UseVisualStyleBackColor = true;
            this.btnPunto4.Click += new System.EventHandler(this.btnPunto4_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPunto1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPunto2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPunto3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPunto4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.TextBox txtDividendo;
    }
}


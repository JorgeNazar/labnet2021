
namespace tp2.WinFormsUI
{
    partial class MensajePersonalizado
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
            this.pictureChuck = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChuck)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureChuck
            // 
            this.pictureChuck.Image = global::tp2.WinFormsUI.Properties.Resources.chuck_norris;
            this.pictureChuck.Location = new System.Drawing.Point(-8, -5);
            this.pictureChuck.Name = "pictureChuck";
            this.pictureChuck.Size = new System.Drawing.Size(674, 424);
            this.pictureChuck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureChuck.TabIndex = 0;
            this.pictureChuck.TabStop = false;
            // 
            // MensajePersonalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(711, 413);
            this.Controls.Add(this.pictureChuck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MensajePersonalizado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MensajePersonalizado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureChuck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureChuck;
    }
}
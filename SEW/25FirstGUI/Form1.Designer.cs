
namespace _25FirstGUI
{
    partial class Form1
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
            this.btnPleaseKlickMe = new System.Windows.Forms.Button();
            this.tbHelloWorld = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPleaseKlickMe
            // 
            this.btnPleaseKlickMe.Location = new System.Drawing.Point(72, 78);
            this.btnPleaseKlickMe.Name = "btnPleaseKlickMe";
            this.btnPleaseKlickMe.Size = new System.Drawing.Size(114, 60);
            this.btnPleaseKlickMe.TabIndex = 0;
            this.btnPleaseKlickMe.Text = "Please Klick Me";
            this.btnPleaseKlickMe.UseVisualStyleBackColor = true;
            this.btnPleaseKlickMe.Click += new System.EventHandler(this.btnPleaseKlickMe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbHelloWorld);
            this.Controls.Add(this.btnPleaseKlickMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPleaseKlickMe;
        private System.Windows.Forms.TextBox tbHelloWorld;
    }
}


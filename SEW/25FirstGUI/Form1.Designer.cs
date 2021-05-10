
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
            this.txtHelloWorld = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPleaseKlickMe
            // 
            this.btnPleaseKlickMe.BackColor = System.Drawing.Color.Firebrick;
            this.btnPleaseKlickMe.ForeColor = System.Drawing.Color.Snow;
            this.btnPleaseKlickMe.Location = new System.Drawing.Point(110, 75);
            this.btnPleaseKlickMe.Name = "btnPleaseKlickMe";
            this.btnPleaseKlickMe.Size = new System.Drawing.Size(121, 63);
            this.btnPleaseKlickMe.TabIndex = 0;
            this.btnPleaseKlickMe.Text = "Please Klick Me";
            this.btnPleaseKlickMe.UseVisualStyleBackColor = false;
            this.btnPleaseKlickMe.Click += new System.EventHandler(this.btnPleaseKlickMe_Click);
            this.btnPleaseKlickMe.MouseEnter += new System.EventHandler(this.btnPleaseKlickMe_MouseEnter);
            // 
            // txtHelloWorld
            // 
            this.txtHelloWorld.Location = new System.Drawing.Point(237, 96);
            this.txtHelloWorld.Name = "txtHelloWorld";
            this.txtHelloWorld.Size = new System.Drawing.Size(159, 23);
            this.txtHelloWorld.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHelloWorld);
            this.Controls.Add(this.btnPleaseKlickMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPleaseKlickMe;
        private System.Windows.Forms.TextBox txtHelloWorld;
    }
}


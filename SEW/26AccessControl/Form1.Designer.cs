namespace _26AccessControl
{
    partial class AccessControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessControlForm));
            this.lbMaxPersons = new System.Windows.Forms.Label();
            this.lbCurrentPersons = new System.Windows.Forms.Label();
            this.txtMaxPersons = new System.Windows.Forms.TextBox();
            this.txtCurrentPersons = new System.Windows.Forms.TextBox();
            this.btnIncrement1 = new System.Windows.Forms.Button();
            this.btnDecrement1 = new System.Windows.Forms.Button();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.txtIncrement = new System.Windows.Forms.TextBox();
            this.txtDecrement = new System.Windows.Forms.TextBox();
            this.lbNoMorePersons = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMaxPersons
            // 
            this.lbMaxPersons.AutoSize = true;
            this.lbMaxPersons.Location = new System.Drawing.Point(75, 75);
            this.lbMaxPersons.Name = "lbMaxPersons";
            this.lbMaxPersons.Size = new System.Drawing.Size(169, 15);
            this.lbMaxPersons.TabIndex = 0;
            this.lbMaxPersons.Text = "Maximale Anzahl an Personen:";
            // 
            // lbCurrentPersons
            // 
            this.lbCurrentPersons.AutoSize = true;
            this.lbCurrentPersons.Location = new System.Drawing.Point(75, 105);
            this.lbCurrentPersons.Name = "lbCurrentPersons";
            this.lbCurrentPersons.Size = new System.Drawing.Size(160, 15);
            this.lbCurrentPersons.TabIndex = 1;
            this.lbCurrentPersons.Text = "Aktuelle Anzahl an Personen:";
            // 
            // txtMaxPersons
            // 
            this.txtMaxPersons.Location = new System.Drawing.Point(250, 72);
            this.txtMaxPersons.Name = "txtMaxPersons";
            this.txtMaxPersons.Size = new System.Drawing.Size(100, 23);
            this.txtMaxPersons.TabIndex = 2;
            this.txtMaxPersons.Text = "0";
            this.txtMaxPersons.TextChanged += new System.EventHandler(this.txtMaxPersons_TextChanged);
            // 
            // txtCurrentPersons
            // 
            this.txtCurrentPersons.BackColor = System.Drawing.SystemColors.Control;
            this.txtCurrentPersons.Location = new System.Drawing.Point(250, 102);
            this.txtCurrentPersons.Name = "txtCurrentPersons";
            this.txtCurrentPersons.ReadOnly = true;
            this.txtCurrentPersons.Size = new System.Drawing.Size(100, 23);
            this.txtCurrentPersons.TabIndex = 3;
            // 
            // btnIncrement1
            // 
            this.btnIncrement1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIncrement1.Location = new System.Drawing.Point(120, 150);
            this.btnIncrement1.Name = "btnIncrement1";
            this.btnIncrement1.Size = new System.Drawing.Size(50, 50);
            this.btnIncrement1.TabIndex = 4;
            this.btnIncrement1.Text = "+1";
            this.btnIncrement1.UseVisualStyleBackColor = true;
            this.btnIncrement1.Click += new System.EventHandler(this.btnIncrement1_Click);
            // 
            // btnDecrement1
            // 
            this.btnDecrement1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecrement1.Location = new System.Drawing.Point(350, 150);
            this.btnDecrement1.Name = "btnDecrement1";
            this.btnDecrement1.Size = new System.Drawing.Size(50, 50);
            this.btnDecrement1.TabIndex = 5;
            this.btnDecrement1.Text = "-1";
            this.btnDecrement1.UseVisualStyleBackColor = true;
            this.btnDecrement1.Click += new System.EventHandler(this.btnDecrement1_Click);
            // 
            // btnIncrement
            // 
            this.btnIncrement.Location = new System.Drawing.Point(120, 240);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(75, 23);
            this.btnIncrement.TabIndex = 6;
            this.btnIncrement.Text = "erhöhen";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // btnDecrement
            // 
            this.btnDecrement.Location = new System.Drawing.Point(350, 241);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(75, 23);
            this.btnDecrement.TabIndex = 7;
            this.btnDecrement.Text = "verringern";
            this.btnDecrement.UseVisualStyleBackColor = true;
            this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
            // 
            // txtIncrement
            // 
            this.txtIncrement.Location = new System.Drawing.Point(14, 240);
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(100, 23);
            this.txtIncrement.TabIndex = 8;
            this.txtIncrement.TextChanged += new System.EventHandler(this.txtIncrement_TextChanged);
            // 
            // txtDecrement
            // 
            this.txtDecrement.Location = new System.Drawing.Point(244, 241);
            this.txtDecrement.Name = "txtDecrement";
            this.txtDecrement.Size = new System.Drawing.Size(100, 23);
            this.txtDecrement.TabIndex = 9;
            this.txtDecrement.TextChanged += new System.EventHandler(this.txtDecrement_TextChanged);
            // 
            // lbNoMorePersons
            // 
            this.lbNoMorePersons.AutoSize = true;
            this.lbNoMorePersons.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNoMorePersons.ForeColor = System.Drawing.Color.Red;
            this.lbNoMorePersons.Location = new System.Drawing.Point(75, 277);
            this.lbNoMorePersons.Name = "lbNoMorePersons";
            this.lbNoMorePersons.Size = new System.Drawing.Size(286, 30);
            this.lbNoMorePersons.TabIndex = 10;
            this.lbNoMorePersons.Text = "Keine Personen mehr erlaubt!";
            this.lbNoMorePersons.Visible = false;
            // 
            // AccessControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.lbNoMorePersons);
            this.Controls.Add(this.txtDecrement);
            this.Controls.Add(this.txtIncrement);
            this.Controls.Add(this.btnDecrement);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.btnDecrement1);
            this.Controls.Add(this.btnIncrement1);
            this.Controls.Add(this.txtCurrentPersons);
            this.Controls.Add(this.txtMaxPersons);
            this.Controls.Add(this.lbCurrentPersons);
            this.Controls.Add(this.lbMaxPersons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccessControlForm";
            this.Text = "Access Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaxPersons;
        private System.Windows.Forms.Label lbCurrentPersons;
        private System.Windows.Forms.TextBox txtMaxPersons;
        private System.Windows.Forms.TextBox txtCurrentPersons;
        private System.Windows.Forms.Button btnIncrement1;
        private System.Windows.Forms.Button btnDecrement1;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.TextBox txtIncrement;
        private System.Windows.Forms.TextBox txtDecrement;
        private System.Windows.Forms.Label lbNoMorePersons;
    }
}


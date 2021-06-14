namespace _02Subtrahieren
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
            this.txt_FirstNumber = new System.Windows.Forms.TextBox();
            this.lb_MultiplizierSymbol = new System.Windows.Forms.Label();
            this.txt_SecondNumber = new System.Windows.Forms.TextBox();
            this.btn_Solve = new System.Windows.Forms.Button();
            this.txt_Solve = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_FirstNumber
            // 
            this.txt_FirstNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_FirstNumber.Location = new System.Drawing.Point(12, 12);
            this.txt_FirstNumber.Name = "txt_FirstNumber";
            this.txt_FirstNumber.Size = new System.Drawing.Size(125, 29);
            this.txt_FirstNumber.TabIndex = 0;
            this.txt_FirstNumber.TextChanged += new System.EventHandler(this.txt_FirstNumber_TextChanged);
            // 
            // lb_MultiplizierSymbol
            // 
            this.lb_MultiplizierSymbol.AutoSize = true;
            this.lb_MultiplizierSymbol.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_MultiplizierSymbol.Location = new System.Drawing.Point(143, 15);
            this.lb_MultiplizierSymbol.Name = "lb_MultiplizierSymbol";
            this.lb_MultiplizierSymbol.Size = new System.Drawing.Size(18, 21);
            this.lb_MultiplizierSymbol.TabIndex = 1;
            this.lb_MultiplizierSymbol.Text = "*";
            // 
            // txt_SecondNumber
            // 
            this.txt_SecondNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SecondNumber.Location = new System.Drawing.Point(167, 12);
            this.txt_SecondNumber.Name = "txt_SecondNumber";
            this.txt_SecondNumber.Size = new System.Drawing.Size(125, 29);
            this.txt_SecondNumber.TabIndex = 2;
            this.txt_SecondNumber.TextChanged += new System.EventHandler(this.txt_SecondNumber_TextChanged);
            // 
            // btn_Solve
            // 
            this.btn_Solve.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Solve.Location = new System.Drawing.Point(298, 11);
            this.btn_Solve.Name = "btn_Solve";
            this.btn_Solve.Size = new System.Drawing.Size(50, 29);
            this.btn_Solve.TabIndex = 3;
            this.btn_Solve.Text = "=";
            this.btn_Solve.UseVisualStyleBackColor = true;
            this.btn_Solve.Click += new System.EventHandler(this.btn_Solve_Click);
            // 
            // txt_Solve
            // 
            this.txt_Solve.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Solve.Location = new System.Drawing.Point(354, 12);
            this.txt_Solve.Name = "txt_Solve";
            this.txt_Solve.Size = new System.Drawing.Size(125, 29);
            this.txt_Solve.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 61);
            this.Controls.Add(this.txt_Solve);
            this.Controls.Add(this.btn_Solve);
            this.Controls.Add(this.txt_SecondNumber);
            this.Controls.Add(this.lb_MultiplizierSymbol);
            this.Controls.Add(this.txt_FirstNumber);
            this.Name = "Form1";
            this.Text = "Multiplizierer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_FirstNumber;
        private System.Windows.Forms.Label lb_MultiplizierSymbol;
        private System.Windows.Forms.TextBox txt_SecondNumber;
        private System.Windows.Forms.Button btn_Solve;
        private System.Windows.Forms.TextBox txt_Solve;
    }
}


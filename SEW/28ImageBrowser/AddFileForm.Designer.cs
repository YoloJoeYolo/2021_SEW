namespace _28ImageBrowser
{
    partial class AddFileForm
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lb_Path = new System.Windows.Forms.Label();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_SelectImage = new System.Windows.Forms.Button();
            this.ofd_SelectImage = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(612, 413);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(85, 25);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(703, 413);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(85, 25);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Abbrechen";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // lb_Path
            // 
            this.lb_Path.AutoSize = true;
            this.lb_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Path.Location = new System.Drawing.Point(12, 38);
            this.lb_Path.Name = "lb_Path";
            this.lb_Path.Size = new System.Drawing.Size(0, 16);
            this.lb_Path.TabIndex = 2;
            // 
            // btn_Select
            // 
            this.btn_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Select.Location = new System.Drawing.Point(12, 12);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(125, 25);
            this.btn_Select.TabIndex = 3;
            this.btn_Select.Text = "Wähle Bild";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_SelectImage
            // 
            this.btn_SelectImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectImage.Location = new System.Drawing.Point(663, 12);
            this.btn_SelectImage.Name = "btn_SelectImage";
            this.btn_SelectImage.Size = new System.Drawing.Size(125, 25);
            this.btn_SelectImage.TabIndex = 4;
            this.btn_SelectImage.Text = "Hinzufügen";
            this.btn_SelectImage.UseVisualStyleBackColor = true;
            this.btn_SelectImage.Click += new System.EventHandler(this.btn_SelectImage_Click);
            // 
            // ofd_SelectImage
            // 
            this.ofd_SelectImage.FileName = "openFileDialog1";
            // 
            // AddFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SelectImage);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.lb_Path);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Name = "AddFileForm";
            this.Text = "AddFileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lb_Path;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_SelectImage;
        private System.Windows.Forms.OpenFileDialog ofd_SelectImage;
    }
}
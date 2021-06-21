namespace _28ImageBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_LoadFile = new System.Windows.Forms.Button();
            this.pb_PictureBox = new System.Windows.Forms.PictureBox();
            this.lb_LoadedFile = new System.Windows.Forms.Label();
            this.ofd_Image = new System.Windows.Forms.OpenFileDialog();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_EditFileList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LoadFile
            // 
            this.btn_LoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadFile.Location = new System.Drawing.Point(12, 12);
            this.btn_LoadFile.Name = "btn_LoadFile";
            this.btn_LoadFile.Size = new System.Drawing.Size(125, 29);
            this.btn_LoadFile.TabIndex = 0;
            this.btn_LoadFile.Text = "Datei auswählen";
            this.btn_LoadFile.UseVisualStyleBackColor = true;
            this.btn_LoadFile.Click += new System.EventHandler(this.btn_LoadFile_Click);
            // 
            // pb_PictureBox
            // 
            this.pb_PictureBox.Location = new System.Drawing.Point(12, 77);
            this.pb_PictureBox.Name = "pb_PictureBox";
            this.pb_PictureBox.Size = new System.Drawing.Size(460, 372);
            this.pb_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_PictureBox.TabIndex = 1;
            this.pb_PictureBox.TabStop = false;
            // 
            // lb_LoadedFile
            // 
            this.lb_LoadedFile.AutoSize = true;
            this.lb_LoadedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LoadedFile.Location = new System.Drawing.Point(9, 47);
            this.lb_LoadedFile.Name = "lb_LoadedFile";
            this.lb_LoadedFile.Size = new System.Drawing.Size(130, 16);
            this.lb_LoadedFile.TabIndex = 2;
            this.lb_LoadedFile.Text = "Keine Datei geladen";
            // 
            // ofd_Image
            // 
            this.ofd_Image.FileName = "openFileDialog1";
            this.ofd_Image.Filter = "Textdatein|*.txt|Spezialdateien|*.sp";
            // 
            // btn_Next
            // 
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(362, 12);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(110, 29);
            this.btn_Next.TabIndex = 3;
            this.btn_Next.Text = "Nächstes -->";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_EditFileList
            // 
            this.btn_EditFileList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditFileList.Location = new System.Drawing.Point(143, 12);
            this.btn_EditFileList.Name = "btn_EditFileList";
            this.btn_EditFileList.Size = new System.Drawing.Size(110, 29);
            this.btn_EditFileList.TabIndex = 4;
            this.btn_EditFileList.Text = "Ändere Fileliste";
            this.btn_EditFileList.UseVisualStyleBackColor = true;
            this.btn_EditFileList.Click += new System.EventHandler(this.btn_EditFileList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btn_EditFileList);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.lb_LoadedFile);
            this.Controls.Add(this.pb_PictureBox);
            this.Controls.Add(this.btn_LoadFile);
            this.Name = "Form1";
            this.Text = "image browser";
            ((System.ComponentModel.ISupportInitialize)(this.pb_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LoadFile;
        private System.Windows.Forms.PictureBox pb_PictureBox;
        private System.Windows.Forms.Label lb_LoadedFile;
        private System.Windows.Forms.OpenFileDialog ofd_Image;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_EditFileList;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28ImageBrowser
{
    public partial class Form1 : Form
    {
        int currentImage = 0;
        string[] lines;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_LoadFile_Click(object sender, EventArgs e)
        {
            if(this.ofd_Image.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = this.ofd_Image.FileName;  // Multiselect --> false
                    this.lines = File.ReadAllLines(path);
                    this.pb_PictureBox.ImageLocation = this.lines[0];
                    this.currentImage = 1;
                    this.lb_LoadedFile.Text = path;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace, "Fehler beim Dateizugriff");
                }
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            this.pb_PictureBox.ImageLocation = this.lines[this.currentImage];
            if (this.currentImage + 1 >= this.lines.Length)
            {
                this.currentImage = 0;
            }
            else
            {
                this.currentImage++;
            }
        }
    }
}

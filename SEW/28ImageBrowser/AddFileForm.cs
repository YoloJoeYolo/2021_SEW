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
    public partial class AddFileForm : Form
    {
        private string fileName;

        public AddFileForm()
        {
            InitializeComponent();
        }

        public string FileName
        {
            get
            {
                return this.fileName;
            }
            set
            {
                this.fileName = value;
            }
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            if (ofd_SelectImage.ShowDialog() == DialogResult.OK)
            {
                this.lb_Path.Text = this.ofd_SelectImage.FileName;
            }
        }

        private void btn_SelectImage_Click(object sender, EventArgs e)
        {
            // Dateipfad vom Bild zu unserer Dateiliste hinzufügen
            File.AppendAllText(this.fileName, this.lb_Path.Text + "\r\n");
        }
    }
}

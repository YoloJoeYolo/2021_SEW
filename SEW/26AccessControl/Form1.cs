using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26AccessControl
{
    public partial class AccesControlForm : Form
    {
        private AccesControl ac;
        public AccesControlForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtMaxPersons_TextChanged(object sender, EventArgs e)
        {
            int persons = int.Parse(this.txtMaxPersons.Text);
            this.ac = new AccesControl(persons);
            UpdateGUI();
        }

        private void UpdateGUI()
        {
            this.txtCurrentPersons.Text = this.ac.CurrentCount.ToString();
        }
    }
}

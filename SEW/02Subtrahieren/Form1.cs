using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02Subtrahieren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Solve_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_Solve.Text = (int.Parse(this.txt_FirstNumber.Text) * int.Parse(this.txt_SecondNumber.Text)).ToString();
            }
            catch (Exception)
            {
            }
        }

        private void txt_FirstNumber_TextChanged(object sender, EventArgs e)
        {
            txt_Solve.Text = "0";
        }

        private void txt_SecondNumber_TextChanged(object sender, EventArgs e)
        {
            txt_Solve.Text = "0";
        }
    }
}

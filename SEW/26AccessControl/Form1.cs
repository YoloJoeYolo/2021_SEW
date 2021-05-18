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
            try
            {
                this.ac = new AccesControl(int.Parse(this.txtMaxPersons.Text));
                UpdateGUI();
            }
            catch (Exception)
            {
                // hier könnten wir Fehler behandeln --> z.B.: Eingabe eines leeren Textes --> FormatException
                // kann nicht in int umgewandelt werden

                // wir machen hier nichts
            }
        }

        private void UpdateGUI()
        {
            if (this.txtMaxPersons.Text == "")
            {
                this.txtCurrentPersons.Text = "";
            }
            else
            {
                this.txtCurrentPersons.Text = this.ac.CurrentCount.ToString();
                // überprüfen ob maximale Anzahl an Personen überschritten wird
                if (this.txtMaxPersons.Text != "" && this.ac.canEnter())
                {
                    this.btnIncrement1.Enabled = true;
                    this.lbNoMorePersons.Visible = false;
                }
                else
                {
                    this.btnIncrement1.Enabled = false;
                    this.lbNoMorePersons.Visible = true;
                }
                // überprüfen ob kleiner 0
                if (this.txtMaxPersons.Text != "" && this.ac.canEnter(-1))
                {
                    this.btnDecrement1.Enabled = true;
                    this.btnDecrement.Enabled = true;
                }
                else
                {
                    this.btnDecrement1.Enabled = false;
                    this.btnDecrement.Enabled = false;
                }
            }

        }

        private void btnIncrement1_Click(object sender, EventArgs e)
        {
            if (this.txtMaxPersons.Text != "")
            {
                this.ac.Increment();
                UpdateGUI();
            }
        }

        private void btnDecrement1_Click(object sender, EventArgs e)
        {
            if (this.txtMaxPersons.Text != "")
            {
                this.ac.Decrement();
                UpdateGUI();
            }
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            if (this.txtDecrement.Text != "")
            {
                this.ac.Increment(int.Parse(this.txtIncrement.Text));
                this.txtIncrement.Text = "";    // wir löschen nach dem erhöhen den Wert
                UpdateGUI();
            }
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            if (this.txtDecrement.Text != "")
            {
                this.ac.Decrement(int.Parse(this.txtDecrement.Text));
                this.txtDecrement.Text = "";
                UpdateGUI();
            }
        }

        private void txtIncrement_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int persons = int.Parse(this.txtIncrement.Text);
                if (this.ac.canEnter(persons))
                {
                    this.btnIncrement.Enabled = true;
                }
                else
                {
                    this.btnIncrement.Enabled = false;
                }
            }
            catch (Exception)
            {
                this.btnIncrement.Enabled = false;
            }
        }

        private void txtDecrement_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int persons = int.Parse(this.txtDecrement.Text);
                if (this.ac.canEnter(persons * -1))
                {
                    this.btnDecrement.Enabled = true;
                }
                else
                {
                    this.btnDecrement.Enabled = false;
                }
            }
            catch (Exception)
            {
                this.btnDecrement.Enabled = false;
            }
        }
    }
}

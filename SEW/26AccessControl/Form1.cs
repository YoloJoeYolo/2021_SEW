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
    public partial class AccessControlForm : Form
    {
        private AccessControl ac;
        public AccessControlForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                int persons = int.Parse(this.txtMaxPersons.Text);
                this.ac = new AccessControl(persons);
                updateGUI();
            }
            catch (Exception ex)
            {
                // hier könnten wir Fehler behandeln --> z.B.: Eingabe eines leeren Textes --> FormatException
                // kann nicht in int umgewandelt werden

                // wir machen hier nichts
            }
        }

        private void txtMaxPersons_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int persons = int.Parse(this.txtMaxPersons.Text);
                this.ac = new AccessControl(persons);
                updateGUI();
            }
            catch (Exception ex)
            {
                // hier könnten wir Fehler behandeln --> z.B.: Eingabe eines leeren Textes --> FormatException
                // kann nicht in int umgewandelt werden

                // wir machen hier nichts
            }

        }

        private void updateGUI()
        {
            this.txtCurrentPersons.Text = this.ac.CurrentCount.ToString();

            // überprüfen ob maximale Anzahl an Personen überschritten wird
            if (this.ac.canEnter())
            {
                this.btnIncrement1.Enabled = true;
                this.lbNoMorePersons.Visible = false;
            }
            else
            {
                this.btnIncrement1.Enabled = false;
                this.lbNoMorePersons.Visible = true;
            }

            // überprüfen ob < 0
            if (this.ac.CurrentCount <= 0)
            {
                this.btnDecrement1.Enabled = false;
            }
            else
            {
                this.btnDecrement1.Enabled = true;
            }
        }

        private void btnIncrement1_Click(object sender, EventArgs e)
        {
            this.ac.Increment();
            this.txtIncrement.Text = "";
            this.txtDecrement.Text = "";
            updateGUI();        }

        private void btnDecrement1_Click(object sender, EventArgs e)
        {
            this.ac.Decrement();
            this.txtIncrement.Text = "";
            this.txtDecrement.Text = "";
            updateGUI();
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            try
            {
                int persons = int.Parse(this.txtIncrement.Text);
                this.ac.Increment(persons);
                this.txtIncrement.Text = "";        // wir löschen nach dem erhöhen den Wert.
                updateGUI();
            }
            catch (Exception ex)
            {

            }
        }

        private void txtIncrement_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int persons = int.Parse(this.txtIncrement.Text);
                // überprüfen ob eine bestimmte Anzahl an Personen noch erlaubt ist.
                 if (this.ac.canEnter(persons))
                {
                    this.btnIncrement.Enabled = true;
                }
                else
                {
                    this.btnIncrement.Enabled = false;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            try
            {
                int persons = int.Parse(this.txtDecrement.Text);
                this.ac.Decrement(persons);
                this.txtDecrement.Text = "";
                updateGUI();
            }
            catch (Exception ex)
            {

            }
        }

        private void txtDecrement_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int persons = int.Parse(this.txtDecrement.Text);
                // überprüfe ob maximale Anzahl (0) unterschritten wird
                if (this.ac.canEnter(persons * -1))      // wir addieren eine negative Zahl
                {
                    this.btnDecrement.Enabled = true;
                }
                else
                {
                    this.btnDecrement.Enabled = false;
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
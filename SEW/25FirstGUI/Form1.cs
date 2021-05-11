using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25FirstGUI
{
    public partial class FirstGUI : Form
    {
        public FirstGUI()
        {
            InitializeComponent();
        }

        private void btnPleaseKlickMe_Click(object sender, EventArgs e)
        {
            // Wenn button gedrückt wird, wird genau diese Methode aufgerufen
            this.txtHelloWorld.Text = "Hello World";
        }

        private void btnPleaseKlickMe_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            Button b = (Button)sender;  // convert the sender to a button
            // wir generieren eine zufällige "neue" Position für den Button
            int widthOfForm = this.FindForm().Size.Width;
            int heightOfForm = this.FindForm().Size.Height;
            int x = rand.Next(widthOfForm - b.Size.Width);    // Breite von Button noch abziehem, damit er auch sicher Platz hat
            int y = rand.Next(heightOfForm - b.Size.Height);
            b.Location = new Point(x, y);

        }
    }
}

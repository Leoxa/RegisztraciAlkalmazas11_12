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

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void hozzaad_Click(object sender, EventArgs e)
        {
            hobbik.Items.Add("felhasznalok.txt");

        }
        private void mentes_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("felhasznalok.txt");

            sw.WriteLine(nev.Text + ", " + szdatum.Text);

            if (F.Checked == true) { sw.WriteLine("Férfi"); }
            else
            { sw.WriteLine("Nő"); }
            sw.WriteLine(hobbik.Text);

            sw.Close();
        }

        private void betolt_Click(object sender, EventArgs e)
        {
            
        }
    }
}

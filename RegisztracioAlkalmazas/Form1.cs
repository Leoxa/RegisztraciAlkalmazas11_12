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
            hobbik.Items.Add("úszás");
            hobbik.Items.Add("horgászat");
            hobbik.Items.Add("futás");
        }
        private void hozzaad_Click(object sender, EventArgs e)
        {
            if (!ujhobbi.Text.Trim().Equals("") && !hobbik.Text.Equals(ujhobbi.Text))
            {
                hobbik.Items.Add(ujhobbi.Text);
            }
            else
            {
                MessageBox.Show("Ez a hobbi már szerepel a listán!");
            }
        }
        private void mentes_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text (.txt)|*.txt";
            saveFileDialog1.ShowDialog();
        }

        private void betolt_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

            sw.WriteLine(nev.Text + "\n " + szdatum.Text);
            
            if (F.Checked == true) { sw.WriteLine("Férfi"); }
            else
            { sw.WriteLine("Nő"); }
            sw.WriteLine(hobbik.SelectedItem);

            sw.Close();
        }

    }
}

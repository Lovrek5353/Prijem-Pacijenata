using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string spol=null, ime=null;
            int hitnost = trackBar1.Value;
            ime = textBox1.Text;
            if (radioButton1.Checked)
            {
                spol = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                spol = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                spol = radioButton3.Text;
            }
            string text= ("Pacijent: " + ime + ";" + "Spol: " + spol + ";" + "Hitnost: " + hitnost);
            listBox1.Items.Add(text);
            MessageBox.Show("Pacijent: " + ime + "\n" + "Spol: " + spol + "\n" + "Hitnost: " + hitnost);
        }
    }
}

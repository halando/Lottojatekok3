using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoJatekok3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("" + sender);

        }

        private void Lenyomas(object sender, KeyEventArgs e)
        {
           /* MessageBox.Show("" + sender);
            MessageBox.Show($"{e.KeyValue},{e.KeyCode}");*/
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           // Regex rk = new Regex("\\w{2} \\w{3,}");
            Regex rk = new Regex(@"\w{2} \w{3,}");
            string jok = "aábcdeéfghiíjklmnoóöőpqrstuúüűvwxyz -";
            //if(e.KeyChar >='a' && e.KeyChar <= 'z' || e.KeyChar>='A' && e.KeyChar <='Z' || e.KeyChar =' ' && e.KeyChar ='-' )
            if(jok.Contains(e.KeyChar) || jok.ToUpper().Contains(e.KeyChar) ||e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            
            if ( e.KeyChar !=8 && rk.IsMatch(textBox1.Text + e.KeyChar) || e.KeyChar == 8 && rk.IsMatch(textBox1.Text.Substring(0,textBox1.Text.Length-1)))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Szelveny sz = new Szelveny(9, 10, 5);
            Controls.Add(sz);
            foreach(Control c in Controls)
            {
                MessageBox.Show("" + c);
            }
        }
    }
}

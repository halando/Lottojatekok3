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
        Random vszg = new Random();
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
            Szelveny[] szelvenyek = new Szelveny[3];
            for (int i = 0; i < szelvenyek.Length; i++)
            {
                Szelveny sz = null;
                switch (i)
                {
                    case 0:
                        sz = new Szelveny(9, 10, 5);
                        break;
                    case 1:
                        sz = new Szelveny(5, 9, 6);
                        break;
                    case 2:
                        sz = new Szelveny(5, 7, 7);
                        break;
                }
                szelvenyek[i] = sz;

            }
            Controls.Add(szelvenyek[vszg.Next(szelvenyek.Length)]);
                        /*foreach(Control c in Controls)
                        {
                            MessageBox.Show("" + c);
                        }*/
                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SzelvenyTorles();
            Szelveny sz = new Szelveny(9,10,5);
            Controls.Add(sz);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SzelvenyTorles();
            Szelveny sz = new Szelveny(5,9,6);
            Controls.Add(sz);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SzelvenyTorles();
            Szelveny sz = new Szelveny(5,7,7);
            Controls.Add(sz);
        }
        void SzelvenyTorles()
        {
            Control torlendo = null;
            foreach (Control c in Controls)
            {
             if(c is Szelveny)
                {
                    torlendo = c;
                }
            }
            if (torlendo != null)
            {
                Controls.Remove(torlendo);
            }
            
        }
    }
}

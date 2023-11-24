using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoJatekok3
{
    internal class Szelveny:TableLayoutPanel
    {
      /*  private int sor;
        private int oszlop;*/
        private int tippdb;
        int db = 0;

        public Szelveny(int sor, int oszlop, int tippdb)
        {
            /* this.sor = sor;
             this.oszlop = oszlop;*/
            ColumnCount = oszlop;
            RowCount = sor;
            this.tippdb = tippdb;

            // this.BackColor = Color.Red;
            Width = 800;
            Height = 600;
            Location = new Point(50, 100);
            for(int i = 1; i <= ColumnCount; i++)
            {
                ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60));
            }
            for (int i = 1; i <= RowCount; i++)
            {
                RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            }
            for(int s = 1; s<= RowCount;s++)
            {
                for (int o =1; o<= ColumnCount; o++)
                {

                    CheckBox cb = new CheckBox();
                    cb.Text=""+((s-1)* ColumnCount +o);
                    cb.CheckedChanged += Kattintas;
                    Controls.Add(cb);
                }
            }
        }
        void Kattintas(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                db++;
            }
            else
            {
                db--;
            }
            if(db == tippdb)
            {
                foreach (Control c in Controls)
                {
               if (!((CheckBox)c).Checked)
                    {
                        c.Enabled = false;  
                    }
                }
            }
            else
            {
                foreach (Control c in Controls)
                {
                    c.Enabled=true;
                }
            }
        }
    }
}

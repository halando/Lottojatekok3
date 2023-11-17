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
        private int sor;
        private int oszlop;
        private int tippdb;

        public Szelveny(int sor, int osz, int tippdb)
        {
            this.sor = sor;
            this.oszlop = osz;
            this.tippdb = tippdb;
            this.BackColor = Color.Red;
        }
    }
}

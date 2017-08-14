using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class And : Form
    {
        public And()
        {
            InitializeComponent();
        }
        private void AND()
        {
            if (ChkA.Checked == true && ChkB.Checked == true)
            {
                PicON.Visible = true;
                PicOFF.Visible = false;
                TxtOUT.Text = "1";
            }
            else
            {
                PicON.Visible = false;
                PicOFF.Visible = true;
                TxtOUT.Text = "0";
            }
        }
        private void ChkA_CheckedChanged(object sender, EventArgs e)
        {
            AND();
        }

        private void ChkB_CheckedChanged(object sender, EventArgs e)
        {
            AND();
        }

        private void And_Load(object sender, EventArgs e)
        {
            AND();
        }
    }
}

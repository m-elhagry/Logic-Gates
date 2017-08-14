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
    public partial class XNOR : Form
    {
        public XNOR()
        {
            InitializeComponent();
        }
        private void xnor()
        {
            if (ChkA.Checked == ChkB.Checked)
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
        private void XNOR_Load(object sender, EventArgs e)
        {
            xnor();
        }

        private void ChkA_CheckedChanged(object sender, EventArgs e)
        {
            xnor();
        }

        private void ChkB_CheckedChanged(object sender, EventArgs e)
        {
            xnor();
        }
    }
}

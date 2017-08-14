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
    public partial class NOR : Form
    {
        public NOR()
        {
            InitializeComponent();
        }
        private void nor()
        {
            if (ChkA.Checked == true || ChkB.Checked == true)
            {
                PicON.Visible = false;
                PicOFF.Visible = true;
                TxtOUT.Text = "0";
            }
            else
            {
                PicON.Visible = true;
                PicOFF.Visible = false;
                TxtOUT.Text = "1";
            }
        }
        private void NOR_Load(object sender, EventArgs e)
        {
            nor();
        }

        private void ChkA_CheckedChanged(object sender, EventArgs e)
        {
            nor();
        }

        private void ChkB_CheckedChanged(object sender, EventArgs e)
        {
            nor();
        }
    }
}

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
    public partial class OR : Form
    {
        public OR()
        {
            InitializeComponent();
        }
        private void or()
        {
            if (ChkA.Checked == true || ChkB.Checked == true)
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
        private void OR_Load(object sender, EventArgs e)
        {
            or();
        }

        private void ChkA_CheckedChanged(object sender, EventArgs e)
        {
            or();
        }

        private void ChkB_CheckedChanged(object sender, EventArgs e)
        {
            or();
        }
    }
}

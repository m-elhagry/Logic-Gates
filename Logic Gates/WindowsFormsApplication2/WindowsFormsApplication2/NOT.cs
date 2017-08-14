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
    public partial class NOT : Form
    {
        public NOT()
        {
            InitializeComponent();
        }
        private void not()
        {
            if (ChkA.Checked == false)
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
        private void NOT_Load(object sender, EventArgs e)
        {
            not();
        }

        private void ChkA_CheckedChanged(object sender, EventArgs e)
        {
            not();
        }
    }
}

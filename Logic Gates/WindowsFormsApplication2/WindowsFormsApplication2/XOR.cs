﻿using System;
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
    public partial class XOR : Form
    {
        public XOR()
        {
            InitializeComponent();
        }
        private void xor()
        {
            if (ChkA.Checked == ChkB.Checked)
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
        private void XOR_Load(object sender, EventArgs e)
        {
            xor();
        }

        private void ChkA_CheckedChanged(object sender, EventArgs e)
        {
            xor();
        }

        private void ChkB_CheckedChanged(object sender, EventArgs e)
        {
            xor();
        }
    }
}

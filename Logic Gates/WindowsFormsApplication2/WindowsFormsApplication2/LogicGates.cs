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
    public partial class LogicGates : Form
    {
        public LogicGates()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Program Show You The outputs Of Every Logic Gate\nDeveloped By Mohamed Elhagry","About Program",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnAND_Click(object sender, EventArgs e)
        {
            And And = new And();
            And.ShowDialog();
        }

        private void BtnOR_Click(object sender, EventArgs e)
        {
            OR OR = new OR();
            OR.ShowDialog();
        }

        private void BtnXOR_Click(object sender, EventArgs e)
        {
            XOR XOR = new XOR();
            XOR.ShowDialog();
        }

        private void BtnNOT_Click(object sender, EventArgs e)
        {
            NOT NOT = new NOT();
            NOT.ShowDialog();
        }

        private void BtnNAND_Click(object sender, EventArgs e)
        {
            NAND NAND = new NAND();
            NAND.ShowDialog();
        }

        private void BtnNOR_Click(object sender, EventArgs e)
        {
            NOR NOR = new NOR();
            NOR.ShowDialog();
        }

        private void BtnXNOR_Click(object sender, EventArgs e)
        {
            XNOR XNOR = new XNOR();
            XNOR.ShowDialog();
        }
    }
}

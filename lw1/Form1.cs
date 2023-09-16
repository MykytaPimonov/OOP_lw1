using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lw1.Shape;

namespace lw1
{
    public partial class Form1 : Form
    {
        private CEmblem[] emblems;
        private int emblemsCount, cur;
        public Form1()
        {
            InitializeComponent();
            emblemsCount = 0;
            emblems = new CEmblem[100];
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (emblemsCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів!");
                return;
            }

            Graphics graphics = pnMain.CreateGraphics();
            cur = emblemsCount;
            emblems[cur] = new CEmblem(graphics, pnMain.Width / 2,  pnMain.Height / 2, 50);
            emblems[cur].Show();
            emblemsCount++;
            cbCircles.Items.Add("Коло №" + (emblemsCount - 1));
            cbCircles.SelectedIndex = emblemsCount - 1;
        }
        
        private void btnHide_Click(object sender, EventArgs e)
        {
            cur = cbCircles.SelectedIndex;
            if (cur > emblemsCount || cur < 0) return;
            emblems[cur].Hide();
        }
        
        private void btnShow_Click(object sender, EventArgs e)
        {
            cur = cbCircles.SelectedIndex;
            if (cur > emblemsCount || cur < 0) return;
            emblems[cur].Show();
        }
        
        private void btnExpand_Click(object sender, EventArgs e)
        {
            cur = cbCircles.SelectedIndex;
            if (cur > emblemsCount || cur < 0) return;
            emblems[cur].Expand(5);
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            cur = cbCircles.SelectedIndex;
            if (cur > emblemsCount || cur < 0) return;
            emblems[cur].Collapse(5);
        }
        
        private void btnUp_Click(object sender, EventArgs e)
        {
            cur = cbCircles.SelectedIndex;
            if (cur > emblemsCount || cur < 0) return;
            emblems[cur].Move(0, -10);
        }
        
        private void btnDown_Click(object sender, EventArgs e)
        {
            cur = cbCircles.SelectedIndex;
            if (cur > emblemsCount || cur < 0) return;
            emblems[cur].Move(0, 10);
        }
        
        private void btnRight_Click(object sender, EventArgs e)
        {
            cur = cbCircles.SelectedIndex;
            if (cur > emblemsCount || cur < 0) return;
            emblems[cur].Move(10, 0);
        }
        
        private void btnLeft_Click(object sender, EventArgs e)
        {
            cur = cbCircles.SelectedIndex;
            if (cur > emblemsCount || cur < 0) return;
            emblems[cur].Move(-10, 0);
        }
        
        private void btnUpFar_Click(object sender, EventArgs e)
        {
            cur = cbCircles.SelectedIndex;
            if (cur > emblemsCount || cur < 0) return;
            for (int i = 0; i < 100; i++)
            {
                emblems[cur].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            }
        }
        
        private void btnDownFar_Click(object sender, EventArgs e)
        {
            cur = cbCircles.SelectedIndex;
            if (cur > emblemsCount || cur < 0) return;
            for (int i = 0; i < 100; i++)
            {
                emblems[cur].Move(0, 1);
                System.Threading.Thread.Sleep(5);
            }
        }
        
        private void btnRightFar_Click(object sender, EventArgs e)
        {
            cur = cbCircles.SelectedIndex;
            if (cur > emblemsCount || cur < 0) return;
            for (int i = 0; i < 100; i++)
            {
                emblems[cur].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }
        
        private void btnLeftFar_Click(object sender, EventArgs e)
        {
            cur = cbCircles.SelectedIndex;
            if (cur > emblemsCount || cur < 0) return;
            for (int i = 0; i < 100; i++)
            {
                emblems[cur].Move(-1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }
    }
}
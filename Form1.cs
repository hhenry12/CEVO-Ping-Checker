using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEVOPingChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int teamAAvg = 0;
            int teamBAvg = 0;
            int teamACount = 0;
            int teamBCount = 0; 


            if (teamAp1.Text != "")
            {
                teamAAvg += Convert.ToInt32(teamAp1.Text);
                teamACount++;
            }

            if (teamAp2.Text != "")
            {
                teamAAvg += Convert.ToInt32(teamAp2.Text);
                teamACount++;
            }

            if (teamAp3.Text != "")
            {
                teamAAvg += Convert.ToInt32(teamAp3.Text);
                teamACount++;
            }

            if (teamAp4.Text != "")
            {
                teamAAvg += Convert.ToInt32(teamAp4.Text);
                teamACount++;
            }

            if (teamAp5.Text != "")
            {
                teamAAvg += Convert.ToInt32(teamAp5.Text);
                teamACount++;
            }

            if (teamBp1.Text != "")
            {
                teamBAvg += Convert.ToInt32(teamBp1.Text);
                teamBCount++;
            }

            if (teamBp2.Text != "")
            {
                teamBAvg += Convert.ToInt32(teamBp2.Text);
                teamBCount++;
            }

            if (teamBp3.Text != "")
            {
                teamBAvg += Convert.ToInt32(teamBp3.Text);
                teamBCount++;
            }

            if (teamBp4.Text != "")
            {
                teamBAvg += Convert.ToInt32(teamBp4.Text);
                teamBCount++;
            }

            if (teamBp5.Text != "")
            {
                teamBAvg += Convert.ToInt32(teamBp5.Text);
                teamBCount++;
            }

            if (teamACount > 0 && teamBCount > 0)
            {
                int aAvg = teamAAvg / teamACount;
                int bAvg = teamBAvg / teamBCount;
                teamAAverage.Text = aAvg.ToString();
                teamAAverage.Visible = true;
                teamBAverage.Text = bAvg.ToString();
                teamBAverage.Visible = true;

                if(Math.Abs(aAvg - bAvg) > 30)
                {
                    statusLbl.Text = "Change: " + Math.Abs(aAvg - bAvg) + " diff";
                    statusLbl.ForeColor = Color.Red;
                    statusLbl.Visible = true;
                }
                else
                {
                    statusLbl.Text = "Stay: " + Math.Abs(aAvg - bAvg) + " diff";
                    statusLbl.ForeColor = Color.Green;
                    statusLbl.Visible = true;
                }
            }
            else
                MessageBox.Show("Make sure to fill in at least 1 box for each team.");
        }

        #region NUMBERS ONLY
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
        private void teamAp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void teamAp3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void teamAp4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void teamAp5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void teamBp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void teamBp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void teamBp3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void teamBp4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void teamBp5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion

        private void teamAp1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

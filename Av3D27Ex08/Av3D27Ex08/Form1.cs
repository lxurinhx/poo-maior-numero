using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Av3D27Ex08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;

            num1 = int.Parse(txtnum1.Text);
            num2 = int.Parse(txtnum2.Text);
            num3 = int.Parse(txtnum3.Text);

            if (num1 > num2 && num1 > num3)
            {
                lblresult.Text = num1.ToString();
            }
            else if (num2 > num1 && num2 > num3)
            {
                lblresult.Text = num2.ToString();
            }
            else if (num3 > num1 && num3 > num2)
            {
                lblresult.Text = num3.ToString();
            };
        }
    }
}

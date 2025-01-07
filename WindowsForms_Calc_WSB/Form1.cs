using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Calc_WSB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkMode.Checked)
            {
                resultLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            }
            else
            {
                resultLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            }
        }

        private void staticSpine_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

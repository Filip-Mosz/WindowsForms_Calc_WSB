using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        private void DarkModeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            object[] ColoredElementsArray = { inputBox, resultLabel, calculateButton, exchangeUnits, resultPrecision, description, calculationGroup };

            if (DarkModeCheckbox.Checked)
            {
                foreach (var element in ColoredElementsArray)
                {
                    DarkModeActive(element);
                }

                this.ForeColor = SystemColors.ControlLightLight;
                this.BackColor = SystemColors.ControlDarkDark;

            }
            else
            {
                foreach (var element in ColoredElementsArray)
                {
                    DarkModeInactive(element);
                }
                //DarkModeInactive(resultLabel);
                this.ForeColor = SystemColors.ActiveCaptionText;
                this.BackColor = SystemColors.Control;
            }
        }

        private void DarkModeInactive(object element)
        {
            Console.WriteLine(element.GetType());
            string type = element.GetType().ToString();

            switch (element.GetType().ToString())
            {
                case "System.Windows.Forms.Label":
                    (element as Label).ForeColor = SystemColors.ActiveCaptionText;
                    break;
                case "System.Windows.Forms.Button":
                    (element as Button).ForeColor = SystemColors.ActiveCaptionText;
                    (element as Button).BackColor = SystemColors.Control;
                    break;
                case "System.Windows.Forms.ComboBox":
                    (element as ComboBox).ForeColor = SystemColors.ActiveCaptionText;
                    (element as ComboBox).BackColor = SystemColors.Window;
                    break;
                case "System.Windows.Forms.GroupBox":
                    (element as GroupBox).ForeColor = SystemColors.ActiveCaptionText;
                    break;
                case "System.Windows.Forms.TextBox":
                    (element as TextBox).ForeColor = SystemColors.ActiveCaptionText;
                    (element as TextBox).BackColor = SystemColors.Window;
                    break;
            }
        }

        private void DarkModeActive(object element)
        {
            Console.WriteLine(element.GetType());
            string type = element.GetType().ToString();

            switch (element.GetType().ToString())
            {
                case "System.Windows.Forms.Label":
                    (element as Label).ForeColor = SystemColors.ControlLightLight;
                    break;
                case "System.Windows.Forms.Button":
                    (element as Button).ForeColor = SystemColors.ControlLightLight;
                    (element as Button).BackColor = SystemColors.ControlDarkDark;
                    break;
                case "System.Windows.Forms.ComboBox":
                    (element as ComboBox).ForeColor = SystemColors.ControlLightLight;
                    (element as ComboBox).BackColor = SystemColors.ControlDarkDark;
                    break;
                case "System.Windows.Forms.GroupBox":
                    (element as GroupBox).ForeColor = SystemColors.ControlLightLight;
                    break;
                case "System.Windows.Forms.TextBox":
                    (element as TextBox).ForeColor = SystemColors.ControlLightLight;
                    (element as TextBox).BackColor = SystemColors.ControlDarkDark;
                    break;
            }
        }

        private void staticSpine_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

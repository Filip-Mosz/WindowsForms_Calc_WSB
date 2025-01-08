﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Calc_WSB
{
    public partial class Form1 : Form
    {
        bool unitsExchanged = false;
        int outputPrecision = 0;
        ConverterImperial cImperial = new ConverterImperial();
        ConverterMetric cMetric = new ConverterMetric();

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
                    (element as System.Windows.Forms.Label).ForeColor = SystemColors.ActiveCaptionText; //full path against ambigious call
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
                    (element as System.Windows.Forms.Label).ForeColor = SystemColors.ControlLightLight; //full path against ambigious call
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

        private void ExchangeUnits_OnHover(object sender, System.EventArgs e)
        {
            ToolTip ExchangeUnitsTooltip = new ToolTip();
            ExchangeUnitsTooltip.SetToolTip(exchangeUnits, "Zamień jednostki miejscami");
        }

        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (staticSpine.Checked)
            {
                unitInput.Text = "TradSpine";
                unitResult.Text = "InchSpine";
                if (unitsExchanged)
                {
                    unitInput.Text = "InchSpine";
                    unitResult.Text = "TradSpine";
                }
            }

            if (poundage.Checked)
            {
                unitInput.Text = "Kg";
                unitResult.Text = "Lbs";
                if (unitsExchanged)
                {
                    unitInput.Text = "Lbs";
                    unitResult.Text = "Kg";
                }
            }

            if (arrowWeight.Checked)
            {
                unitInput.Text = "gram";
                unitResult.Text = "grain";
                if (unitsExchanged)
                {
                    unitInput.Text = "grain";
                    unitResult.Text = "gram";
                }
            }

            if (arrowSpeed.Checked)
            {
                unitInput.Text = "m/s";
                unitResult.Text = "fps";
                if (unitsExchanged)
                {
                    unitInput.Text = "fps";
                    unitResult.Text = "m/s";
                }
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double inputValue = Convert.ToDouble(inputBox.Text);

            if(staticSpine.Checked) {
                //oblicznie spinu statycznego
                //sprawdzenie, czy exchange utits odkliknięty
                if (unitsExchanged)
                {
                    //use of 'imperial' version of convert
                }
                else
                {
                    //use 'SI' version of convert
                }
            }

            if (poundage.Checked)
            {
                //oblicznie spinu statycznego
                //sprawdzenie, czy exchange utits odkliknięty
                if (unitsExchanged)
                {
                    resultLabel.Text = cImperial.weight(inputValue, outputPrecision).ToString();//use of 'imperial' version of convert
                }
                else
                {
                    resultLabel.Text = cMetric.poundage(inputValue, outputPrecision).ToString();//use 'SI' version of convert
                }
            }

            if (arrowWeight.Checked)
            {
                //oblicznie spinu statycznego
                //sprawdzenie, czy exchange utits odkliknięty
                if (unitsExchanged)
                {
                    //use of 'imperial' version of convert
                }
                else
                {
                    //use 'SI' version of convert
                }
            }

            if (arrowSpeed.Checked)
            {
                //oblicznie spinu statycznego
                //sprawdzenie, czy exchange utits odkliknięty
                if (unitsExchanged)
                {
                    //use of 'imperial' version of convert
                }
                else
                {
                    //use 'SI' version of convert
                }
            }
        }
    }
}

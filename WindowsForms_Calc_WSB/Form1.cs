using System;
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
                descriptionContent.Text = "Spin statyczny oznacza sztywność promienia strzały. Używany jest do określenia, czy strzała ma szanse na \"czyste\" wyjście z łuku bez zaburzenia toru lotu. Wyrażany w funtach lub setnych częściach cala";
                unitInput.Text = "InchSpine";
                unitResult.Text = "LbsSpine"; 
                if (unitsExchanged)
                {
                    unitInput.Text = "LbsSpine";
                    unitResult.Text = "InchSpine";
                }
            }

            if (poundage.Checked)
            {
                descriptionContent.Text = "Siła łuku reprezentuje ekwiwalent cieżaru jakim należałoby obciążyć cięciwę, żeby odciagnąć ją na daną odległość. Zazwyczaj mierzona jest na odległości 28 cali/ok 71 centymetrów";
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
                descriptionContent.Text = "Waga strzały wydaje się dość intuicyjna. Jednak kiedy część producentów podaje wagę w gramach a część w grainach, ten kalkulator może być przydatny.";
                unitInput.Text = "grain";
                unitResult.Text = "gram"; 
                if (unitsExchanged)
                {
                    unitInput.Text = "gram";
                    unitResult.Text = "grain";
                }
            }

            if (arrowSpeed.Checked)
            {
                descriptionContent.Text = "Prędkość wylotowa strzały wydaje się dość intuicyjna. Mimo to - najczęściej podawana w stopach na sekundę - może nie być jasna dla europejczyka przyzwyczajonego do jednostek metrycznych.";
                unitInput.Text = "fps";
                unitResult.Text = "m/s"; 
                if (unitsExchanged)
                {
                    unitInput.Text = "m/s";
                    unitResult.Text = "fps";
                }
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double inputValue = 0;
            try
            {
                inputValue = Convert.ToDouble(inputBox.Text);
                if (inputValue < 0)
                {
                    throw new Exception("wartość nie może być ujemna");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message, MessageBoxButtons.OK.ToString());
            }
            

            if(staticSpine.Checked) 
            {
                //sprawdzenie, czy exchange utits odkliknięty
                if (unitsExchanged)
                {
                    resultLabel.Text = cImperial.staticSpine(inputValue, outputPrecision).ToString();//use of 'imperial' version of convert
                    Console.WriteLine("poundsSpine -> inchSpine");
                }
                else
                {
                    resultLabel.Text = cMetric.staticSpine(inputValue, outputPrecision).ToString();//use 'SI' version of convert
                    Console.WriteLine("inchSpine -> poundsSpine");
                }
            }
            else if (poundage.Checked)
            {
                //sprawdzenie, czy exchange utits odkliknięty
                if (unitsExchanged)
                {
                    Console.WriteLine("lbs -> kg");
                    resultLabel.Text = cMetric.poundage(inputValue, outputPrecision).ToString();//use of 'imperial' version of convert
                }
                else
                {
                    Console.WriteLine("kg -> lbs");
                    resultLabel.Text = cImperial.poundage(inputValue, outputPrecision).ToString();//use 'SI' version of convert
                }
            }
            else if (arrowWeight.Checked)
            {
                //sprawdzenie, czy exchange utits odkliknięty
                if (unitsExchanged)
                {
                    resultLabel.Text = cImperial.weight(inputValue, outputPrecision).ToString();//use of 'imperial' version of convert
                    Console.WriteLine("g -> gr");
                }
                else
                {
                    resultLabel.Text = cMetric.weight(inputValue, outputPrecision).ToString();//use 'SI' version of convert
                    Console.WriteLine("gr -> g");
                }
            }
            else if (arrowSpeed.Checked)
            {
                //sprawdzenie, czy exchange utits odkliknięty
                if (unitsExchanged)
                {
                    resultLabel.Text = cImperial.speed(inputValue, outputPrecision).ToString();//use of 'imperial' version of convert
                    Console.WriteLine("m/s -> fps");
                }
                else
                {
                    resultLabel.Text = cMetric.speed(inputValue, outputPrecision).ToString(); //use 'SI' version of convert
                    Console.WriteLine("fps -> m/s");
                }
            }
            else
            {
                MessageBox.Show("Info: Najpierw zaznacz żądaną operację");
            }
        }

        private void ExchangeUnitsButton_Click(object sender, EventArgs e)
        {
            if (unitsExchanged) 
            { 
                unitsExchanged = false;
            }
            else if(!unitsExchanged)
            {
                unitsExchanged = true;
            }
            Checkbox_CheckedChanged(sender, e);
        }
    }
}

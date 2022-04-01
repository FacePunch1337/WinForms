using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;




namespace WinForms.Forms
{
    public partial class Calc : Form
    {
        //Создание объекта logger
        private static Logger logger;
        public Calc()
        {
            InitializeComponent();
            //Инициализация объекта logger
            logger = NLog.LogManager.GetCurrentClassLogger();
        }

        private void buttonDigit_Click(object sender, EventArgs e)
        {
            var clickedButton = sender as Button;
            if (clickedButton == null) return;

            int lim_display = 9;
            if (labelDisplay.Text.Contains('-')) lim_display++;
            if (labelDisplay.Text.Contains('.')) lim_display++;
            if (labelDisplay.Text.Length >= lim_display) return;
            int lim_history = 30;
            if (labelHistory.Text.Contains('-')) lim_history++;
            if (labelHistory.Text.Contains('.')) lim_history++;
            if (labelHistory.Text.Length >= lim_history) return;

            if (labelDisplay.Text.Equals("0"))
            {
                labelDisplay.Text = clickedButton.Text;
            }
            else
            {
                labelDisplay.Text += Convert.ToDouble(clickedButton.Text);
            }
            labelHistory.Text += clickedButton.Text;
            if (labelHistory.Text.Contains("+")) buttonResult_Click(sender, e);
            if (labelHistory.Text.Contains("-")) buttonResult_Click(sender, e);
            if (labelHistory.Text.Contains("x")) buttonResult_Click(sender, e);
            if (labelHistory.Text.Contains("÷")) buttonResult_Click(sender, e);

        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (labelDisplay.Text.Equals("0")) return;
            if (labelDisplay.Text.StartsWith('-'))
            {
                labelDisplay.Text = labelDisplay.Text.Substring(1);
                labelHistory.Text = labelHistory.Text.Substring(1);
            }
            else
            {
                char[] charsToTrim = { 's', 'q', 'r' };
                var num = labelHistory.Text.Trim(charsToTrim).Replace("(", "").Replace(")", "");
                labelDisplay.Text = "-" + labelDisplay.Text;
                labelHistory.Text = "-" + labelHistory.Text;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = "0";
            labelHistory.Text = "";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = "0";
        }

        private void buttonCL_Click(object sender, EventArgs e)
        {
            var size_history_text = labelHistory.Text.Length - 1;
            var size_display_text = labelDisplay.Text.Length - 1;

            if (labelHistory.Text != "" && labelDisplay.Text != "")
            {
                labelHistory.Text = labelHistory.Text.Substring(0, size_history_text);
                labelDisplay.Text = labelDisplay.Text.Substring(0, size_display_text);
            }
            else
            {
                labelHistory.Text = "";
                labelDisplay.Text = "0";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (labelHistory.Text != "") labelHistory.Text += " + ";
            else labelHistory.Text = "";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (labelHistory.Text != "") labelHistory.Text += " - ";
            else labelHistory.Text = "()";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (labelHistory.Text != "") labelHistory.Text += " ÷ ";
            else labelHistory.Text = "";
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            if (labelHistory.Text != "") labelHistory.Text += " x ";
            else labelHistory.Text = "";
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            
            if (labelHistory.Text != "" && labelDisplay.Text != "")
            {
                if (labelDisplay.Text.Contains(","))
                {
                    var enter = Convert.ToDouble(labelDisplay.Text);
                    double value = Math.Pow(enter, 2);
                    labelHistory.Text = $"sqr({value.ToString()})";
                    labelDisplay.Text = value.ToString();
                }
                else
                {

                    var enter = Convert.ToInt32(labelDisplay.Text);
                    int value = enter;

                    value *= value;
                    labelHistory.Text = $"sqr({value.ToString()})";
                    labelDisplay.Text = value.ToString();

                }
            }
            else
            {
                labelHistory.Text = "";
                labelDisplay.Text = "0";
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            //Обработка исключительных ситуаций при вычеслении
            try
            {
               
                char[] charsToTrim = { 's', 'q', 'r' };
                var num = labelHistory.Text.Trim(charsToTrim).Replace("(", "").Replace(")", "");

                var result = new DataTable().Compute(num.Replace("x", "*").Replace("÷", "/").Replace(",", "."), null);
                labelDisplay.Text = result.ToString();
            }
            catch (Exception ex)
            {
             
                labelDisplay.Text = "ERROR";
                //Логирование исключения
                logger.Error(ex);
                
            }
            

            
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            if (labelDisplay.Text == "0")
            {
                labelHistory.Text = "0" + ",";
            }
            else
            {
                labelHistory.Text += ",";
            }

            if (!labelDisplay.Text.Contains(","))
                labelDisplay.Text += ",";
        }

        private void Calc_Load(object sender, EventArgs e)
        {

        }
    }

    enum Operations
    {
        None,
        Add,
        Sub,
        Mul,
        Div
    }
}

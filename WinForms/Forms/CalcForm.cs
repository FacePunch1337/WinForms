using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace WinForms.Forms
{
    public partial class Calc : Form
    {

        public Calc()
        {
            InitializeComponent();
        }

        private void buttonDigit_Click(object sender, EventArgs e)
        {
            var clickedButton = sender as Button;
            if (clickedButton == null) return;

            int lim = 9;
            if (labelDisplay.Text.Contains('-')) lim++;
            if (labelDisplay.Text.Contains('.')) lim++;
            if (labelDisplay.Text.Length >= lim) return;

            if (labelDisplay.Text.Equals("0"))
            {
                labelDisplay.Text = clickedButton.Text;


            }
            else
            {
                labelDisplay.Text += clickedButton.Text;
            }
            labelHistory.Text += clickedButton.Text;
            if (labelHistory.Text.Contains("+")) buttonResult_Click(sender, e);
            if (labelHistory.Text.Contains("-")) buttonResult_Click(sender, e);
            if (labelHistory.Text.Contains("*")) buttonResult_Click(sender, e);
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
            else labelHistory.Text = "";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (labelHistory.Text != "") labelHistory.Text += " ÷ ";
            else labelHistory.Text = "";
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            if (labelHistory.Text != "") labelHistory.Text += " * ";
            else labelHistory.Text = "";
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            var result = new DataTable().Compute(labelHistory.Text.Replace('x', '*').Replace('÷', '/'), null);
            labelDisplay.Text = result.ToString();
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (labelHistory.Text != "" && labelDisplay.Text != "")
            {
                int value = Convert.ToInt32(labelDisplay.Text);
                value *= value;
                labelHistory.Text = value.ToString();
                labelDisplay.Text = value.ToString();
            }
            else
            {
                labelHistory.Text = "";
                labelDisplay.Text = "0";
            }
        }

        private void Calc_Load(object sender, EventArgs e)
        {

        }
    }
}

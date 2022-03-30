using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        
        bool press;
        int counter;
        
        public Form1()
        {
            InitializeComponent();
            press = false;
            counter = 0;
            
            checkBoxDemo.ForeColor = Color.Red;
        }

        private void buttonDemo_Click(object sender, EventArgs e)
        {
            listBoxDemo.Items.Add("Сработала кнопка");
            counter++;
            


            if (press == false)
            {
                buttonDemo.Text = "PRESS";
                press = true;
            }
            else if(press == true)
            {
        
                buttonDemo.Text = "PRESSED";
                press = false;
            }
            labelDemo.Text = $"Кнопка была нажата: {counter} раз";
            /*if(counter / 13 == 2)
            {
                labelDemo.Text = $"Кнопка была нажата: {counter} раза";
            }

            else
            {
                labelDemo.Text = $"Кнопка была нажата: {counter} раз";
            }*/

        }

        private void checkBoxDemo_CheckedChanged(object sender, EventArgs e)
        {
            listBoxDemo.Items.Add("Cработал флажок");
            if (checkBoxDemo.Checked)
            {
                checkBoxDemo.ForeColor = Color.Green;
            }
            else
            {
                checkBoxDemo.ForeColor = Color.Red;
            }
        }

        private void textBoxDemo_TextChanged(object sender, EventArgs e)
        {
            labelDemo.Text = textBoxDemo.Text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Forms
{
    public partial class ProgressForm : Form
    {

        private readonly NLog.Logger _logger;
        private readonly Random _random;
        private float progressTime;

        public ProgressForm(NLog.Logger logger, Random random)
        {
            _random = random;
            _logger = logger;   
            InitializeComponent();
            
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            listBoxStyle.Items.Add(new BarStyle { Title = "Thin", Height = 15 });
            listBoxStyle.Items.Add(new BarStyle { Title = "Normal", Height = 23 });
            listBoxStyle.Items.Add(new BarStyle { Title = "Tall", Height = 40 });

            listBoxStyle.SelectedIndex = 1;

            comboBoxBarTime.Items.Add("1");
            comboBoxBarTime.Items.Add("2");
            comboBoxBarTime.Items.Add("3");

            comboBoxBarTime.SelectedIndex = 1;
            progressTime = 2;

            progressBarStyle.Minimum = 0;
            progressBarStyle.Maximum = 100;
            //progressBarStyle.Value = 50;
        }

        private void listBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStyle.SelectedItem == null) return;
            //MessageBox.Show(listBoxStyle.SelectedItem.ToString());
            progressBarStyle.Height = ((BarStyle)listBoxStyle.SelectedItem).Height;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                progressBarStyle.Value = (i + 1) * 10;
                Thread.Sleep((int)(progressTime * 100));
            }
        }

        private void comboBoxBarTime_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (comboBoxBarTime.SelectedIndex == -1) return;

            if (comboBoxBarTime.Text == String.Empty) return;
            progressTime = Convert.ToInt32(comboBoxBarTime.Text);
            
            
        }
    }

    class BarStyle
    {
        public String? Title { get; set; }
        public int Height { get; set; }

        public override string ToString()
        {
            return Title;
        }

    }

}

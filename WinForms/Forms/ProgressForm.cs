using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private CancellationTokenSource cts;
        private float progressTime;
        //private bool stopPressed;
        private int progressState;
        private bool press;
        



        public ProgressForm(NLog.Logger logger, Random random)
        {
            _random = random;
            _logger = logger;
            cts = null;
            InitializeComponent();

        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            listBoxStyle.Items.Add(new BarStyle { Title = "Thin", Height = 15 });
            listBoxStyle.Items.Add(new BarStyle { Title = "Normal", Height = 23 });
            listBoxStyle.Items.Add(new BarStyle { Title = "Tall", Height = 40 });

            listBoxStyle.SelectedIndex = 1;


            comboBoxBarTime.Items.Add("1");
            comboBoxBarTime.Items.Add("2.5");
            comboBoxBarTime.Items.Add("3");

            comboBoxBarTime.SelectedIndex = 0;
            progressTime = 0;


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
        private void UpdateProgress()
        {
            progressBarStyle.Value = progressState;
        }

        private void StartHandler(object obj)
        {
            //stopPressed = false;
            if (!(obj is CancellationToken)) return;
            CancellationToken token = (CancellationToken)obj;
            
            for (int i = progressState; i < 10; i++)
            {
               
                progressState = (i + 1) * 10;
                this.Invoke((Action)UpdateProgress);

                Thread.Sleep((int)(progressTime * 100));
                // if (stopPressed) break;

                if (token.IsCancellationRequested) break;

                
            }

          
            
        }

      
        private void buttonStart_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            Task.Run(() => StartHandler(cts.Token));

        }



       
        //Событие изменения текста
        private void comboBoxText_Update(object sender, EventArgs e)
        {

            try
            {
                progressTime = float.Parse(comboBoxBarTime.Text.Replace(".", ","));
                if (comboBoxBarTime.Text.Contains("-") || progressTime <= 0 || progressTime > 10)
                {
                    comboBoxBarTime.Text = "1";
                }


            }
            catch
            {
                comboBoxBarTime.Text = string.Empty;
            }


        }



        private void buttonStop_Click(object sender, EventArgs e)
        {
            //stopPressed = true;
            cts?.Cancel();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
           
            if (press == false)
            {
                press = true;
                buttonPause.Text = "continue";
                cts?.Cancel();
                this.Invoke((Action)UpdateProgress);
            }
            else if(press == true)
            {
                
                press = false;
                buttonPause.Text = "pause";

                cts = new CancellationTokenSource();
                Task.Run(() => StartHandler(cts.Token));
            }





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

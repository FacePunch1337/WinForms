using Microsoft.Practices.Unity;
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
    public partial class FractalsForm : Form
    {

        private Brush convergentBrush;
        private Brush divergentBrush;
        Graphics g;

        [Dependency]

        public Services.IRandom Random { get; set; }

        private Thread drawThread;


        public FractalsForm()
        {
            InitializeComponent();
            convergentBrush = new SolidBrush(Color.Black);
            divergentBrush = new SolidBrush(Color.White);
            g = null;
            drawThread = null;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            convergentBrush.Dispose();
            divergentBrush.Dispose();
            this.Close();
        }

        /*private async void ShowPoint2(object obj)
        {
            PointData data = obj as PointData;
            Brush color;
            Complex Z = new Complex
            {
                Re = 3.0 * (data.X - panelPicture.Width / 2) / panelPicture.Width,
                Im = 3.0 * (data.Y - panelPicture.Height / 2) / panelPicture.Height,
            };
            int n = 0;
            do
            {
                n++;
                Z = Z * Z + data.C;
            } while (n < 100 && Z.Abs < 10);

            if (n < 100)
            {
                color = convergentBrush;
            }
            else
            {
                color = divergentBrush;
            }

            lock (panelPicture)
            {
                using (Graphics g = panelPicture.CreateGraphics())
                {
                    g.FillRectangle(color, data.X, data.Y, 1, 1);
                }
            }
        }*/
        private void ShowPoint(object obj)
        {
            PointData data = obj as PointData;
            Brush color;
            Complex Z = new Complex
            {
                Re = 3.0 * (data.X - panelPicture.Width / 2) / panelPicture.Width,
                Im = 3.0 * (data.Y - panelPicture.Height / 2) / panelPicture.Height,
            };
            int n = 0;
            do
            {
                n++;
                Z = Z * Z + data.C;
            } while (n < 100 && Z.Abs < 10);

            if (n < 100)
            {
                color = convergentBrush;
            }
            else
            {
                color = divergentBrush;
            }

            lock (panelPicture)
            {
                using (Graphics g = panelPicture.CreateGraphics())
                {
                    g.FillRectangle(color, data.X, data.Y, 1, 1);
                }
            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Complex C;
            try
            {
                C = new Complex
                {
                    Re = Convert.ToDouble(textBoxRe.Text.Replace('.', ',')),
                    Im = Convert.ToDouble(textBoxIm.Text.Replace('.', ',')),
                };
            }
            catch
            {
                MessageBox.Show("Something wrong with numeric values");
                return;
            }

            for (int x = 0; x < panelPicture.Width; x += 1)    // координаты панели
                for (int y = 0; y < panelPicture.Height; y += 1)
                {
                    // Sync (время - для панели размером 415 x 311 )
                     ShowPoint(new PointData { X = x, Y = y, C = C });  // 4 s без using - 1.9 s  -- 30 Mb

                    // MultiThread
                    // new Thread(ShowPoint).Start(new PointData { X = x, Y = y, C = C }); // 100500 s

                    // MultiTask
                    // ShowPoint2(x, y, C);  // 8 s без using - 3 s  -- 170 Mb

                    // ThreadPool
                   /* ThreadPool.QueueUserWorkItem(  // 3.4 s  // без using - 2.2-2.4 s  -- 48 Mb
                        ShowPoint,
                        new PointData { X = x, Y = y, C = C });*/
                }
            drawThread = new Thread(DrawFractal);
            drawThread.Start();



        }


        private void FractalsForm_Load(object sender, EventArgs e)
        {
            textBoxRe.Text = "-1.2";
            textBoxIm.Text = "-0.16";
        }


        private void DrawFractal(object obj)
        {
            Complex C = obj as Complex;
            for (int x = 0; x < panelPicture.Width; x += 1)
            {
                for (int y = 0; y < panelPicture.Height; y += 1)
                {

                    ShowPoint(new PointData { X = x, Y = y, C = C });

                    //new Thread(ShowPoint).Start(new PointData { X = x, Y = y, C = C });
                }
            }
        }
    }
        class PointData
        {
            public int X;
            public int Y;
            public Complex C;
        }

        class Complex
        {
            public double Re { get; set; }
            public double Im { get; set; }
            public double Abs
            {
                get => Math.Sqrt(Re * Re + Im * Im);
            }

            public static Complex operator +(Complex c1, Complex c2)
            {
                return new Complex
                {
                    Re = c1.Re + c2.Re,
                    Im = c1.Im + c2.Im
                };
            }

            public static Complex operator *(Complex c1, Complex c2)
            {
                return new Complex
                {
                    Re = c1.Re * c2.Re - c1.Im * c2.Im,
                    Im = c1.Re * c2.Im + c2.Re * c1.Im
                };
            }
        }
    
}

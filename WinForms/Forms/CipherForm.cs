using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Forms
{
    public partial class CipherForm : Form
    {

        private const String SAMPLE_FILENAME = "sample.txt";
        private const String SAMPLE_CONTENT = "Hello, World";
        private char PASSWORD_CHAR;

        private CipherData cipherData;
        private CancellationTokenSource cancellationTokenSource;

        private int progressValue; //exchange variable - to show from other thread


        public CipherForm()
        {
            InitializeComponent();
            cipherData = new CipherData();
            cancellationTokenSource = null;
            


        }

        private void CipherForm_Load(object sender, EventArgs e)
        {
            panelTarget.Visible = false;
            panelProgress.Visible = false;
            
            PASSWORD_CHAR = textBoxPassword.PasswordChar;
            //Глаз закрыт
            pictureBoxEye.Image = Image.FromFile("pass_eye_close.png");

        }


        // Creates file "sample.txt" in application startup folder
        private void makeSampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(SAMPLE_FILENAME, SAMPLE_CONTENT);
        }


        // Selects file (name) for ciphering - source file
        // using fileOpenDialog resource
        private void buttonSelectSourceFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = SAMPLE_FILENAME;
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String fullpath = openFileDialog1.FileName;
                String name = Path.GetFileNameWithoutExtension(fullpath);
                String nameExt = Path.GetFileName(fullpath);
                String dir = Path.GetDirectoryName(fullpath);

                textBoxSourceFileName.Text = fullpath;
                panelTarget.Visible = true;

                textBoxTargetFileName.Text = name + ".cod";

                cipherData.SourceFile = fullpath;
                cipherData.TargetFile = Path.Combine(dir, textBoxTargetFileName.Text);

                
                
            }
            else
            {
                textBoxSourceFileName.Text = String.Empty;
                textBoxTargetFileName.Text= String.Empty;
                panelTarget.Visible = false;
            }
        }

        private void buttonCipher_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show($"{cipherData.SourceFile}\n »\n{cipherData.TargetFile}");

            cipherData.Password = textBoxPassword.Text;
            cancellationTokenSource = new CancellationTokenSource();
            progressValue = 0;
            panelProgress.Visible = true;
            new Thread(Cipher).Start(new ThreadData { CipherData = cipherData, Token = cancellationTokenSource.Token });
        }


        //"Кнопка" смены состояния отображения пароля
        private void pictureBoxEye_Click(object sender, EventArgs e)
        {
            EyeOpenClose();
        }


        //Метод смены состояния отображения пароля
        private void EyeOpenClose()
        {
            if (PASSWORD_CHAR == '\0')
            {
                PASSWORD_CHAR = '•';
                textBoxPassword.PasswordChar = PASSWORD_CHAR;
                //Глаз закрыт
                pictureBoxEye.Image = Image.FromFile("pass_eye_close.png");
            }
            else
            {
                PASSWORD_CHAR = '\0';
                textBoxPassword.PasswordChar = PASSWORD_CHAR;
                //Глаз открыт
                pictureBoxEye.Image = Image.FromFile("pass_eye_open.png");
            }
        }


        //set progress bar to progress value - from any thread   
        private void UpdateProgress()
        {
            lock(progressCipherBar)
            {
                progressCipherBar.Value = progressValue;
            }
           
        }

        //cross-thread method for setting panel invisible
        private void HidePanelProgress()
        {
            lock (panelProgress)
            {
                if (progressCipherBar.Visible) progressCipherBar.Visible = false;
            }

        }


        private void Cipher(object data)
        {
            if (data is null || data is not ThreadData) return;
            ThreadData tdata = (ThreadData)data;

            if (tdata.CipherData is null) return;

            try
            {
                //source file size - for progress bar scaling
                long fileSize = new FileInfo(tdata.CipherData.SourceFile).Length;
                //open source file to read
                using (var reader = new StreamReader(tdata.CipherData.SourceFile))
                {
                    //open destination file for writing
                    using (var writer = new StreamWriter(tdata.CipherData.TargetFile))
                    {
                        int cnt = 0;
                        while (!reader.EndOfStream)
                        {
                            char symT = (char)reader.Read();    // text symbol - read from file
                            char symP = tdata.CipherData.Password[cnt % tdata.CipherData.Password.Length];
                            char symC = (char)(symT ^ symP);  // cipher symbol
                            writer.Write(symC);              //write to file
                            ++cnt;

                            //display progress
                            progressValue = (int)(cnt * 100 / fileSize); // exchange variable 
                            Invoke((Action)UpdateProgress);

                            Thread.Sleep(300);
                            if (tdata.Token.IsCancellationRequested)
                            {
                               
                                if(DialogResult.Yes == MessageBox.Show("Shure", "Cancel", MessageBoxButtons.YesNo))
                                {
                                    tdata.Token.ThrowIfCancellationRequested();
                                }
                                else
                                {
                                    cancellationTokenSource = new CancellationTokenSource();
                                    tdata.Token = cancellationTokenSource.Token;
                                }
                            }
                        }
                    }
                }
                
                //ciphering finished successfully
                MessageBox.Show("Open in notepad?", "Сiphering finished successfully", MessageBoxButtons.YesNo);
               
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OperationCanceledException)
            {
                //MessageBox.Show("Sure?","Сancel", MessageBoxButtons.YesNo);
                try
                {
                    File.Delete(tdata.CipherData.TargetFile); 
                }
                catch (Exception)
                {

                    throw;
                }
            }
            finally
            {
                //ciphering finished with any state
               Invoke((Action)HidePanelProgress);
            }
        }

        private void buttonCipherCancel_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
        }
    }

    class ThreadData
    {
        public CipherData CipherData { get; set;}
        public CancellationToken Token { get; set; } 
    }

    class CipherData
    {
        public String SourceFile { get; set; } = String.Empty;
        public String TargetFile { get; set; } = String.Empty;
        public String Password { get; set; } = String.Empty;
    }
}

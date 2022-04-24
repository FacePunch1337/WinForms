using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
        public CipherForm()
        {
            cipherData = new CipherData();
            
            InitializeComponent();
        }

        private void CipherForm_Load(object sender, EventArgs e)
        {
            panelTarget.Visible = false;
            
            PASSWORD_CHAR = textBoxPassword.PasswordChar;
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
            MessageBox.Show($"{cipherData.SourceFile}\n »\n{cipherData.TargetFile}");
        }

        private void pictureBoxEye_Click(object sender, EventArgs e)
        {
            EyeOpenClose();
        }

        private void EyeOpenClose()
        {
            if (PASSWORD_CHAR == '\0')
            {
                PASSWORD_CHAR = '•';
                textBoxPassword.PasswordChar = PASSWORD_CHAR;
                pictureBoxEye.Image = Image.FromFile("pass_eye_close.png");
            }
            else
            {
                PASSWORD_CHAR = '\0';
                textBoxPassword.PasswordChar = PASSWORD_CHAR;
                pictureBoxEye.Image = Image.FromFile("pass_eye_open.png");
            }
        }

       
    }


    class CipherData
    {
        public String SourceFile { get; set; } = String.Empty;
        public String TargetFile { get; set; } = String.Empty;
        public String Password { get; set; } = String.Empty;
    }
}

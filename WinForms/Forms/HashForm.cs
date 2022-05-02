using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Forms
{
    public partial class HashForm : Form
    {
        public HashForm()
        {
            InitializeComponent();
        }

        private void buttonMD5_Click(object sender, EventArgs e)
        {
            textBoxMD5.Text = MyLibrary.Hash.Md5(textBoxSource.Text);
            
            
        }

        private void buttonSHA1_Click(object sender, EventArgs e)
        {
            textBoxSHA1.Text = MyLibrary.Hash.Sha1(textBoxSource.Text);
        }
       

        private void buttonSHA256_Click_1(object sender, EventArgs e)
        {
            textBoxSHA256.Text = MyLibrary.Hash.Sha256(textBoxSource.Text);
        }

        private void buttonSHA384_Click(object sender, EventArgs e)
        {
            textBoxSHA384.Text = MyLibrary.Hash.Sha384(textBoxSource.Text);
        }

        private void buttonSHA512_Click(object sender, EventArgs e)
        {
            textBoxSHA512.Text = MyLibrary.Hash.Sha512(textBoxSource.Text);

        }
    }
}

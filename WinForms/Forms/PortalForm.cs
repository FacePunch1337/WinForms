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
    public partial class PortalForm : Form
    {
        
       
        public PortalForm()
        {
            InitializeComponent();
        }

        private void linkLabelToControl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void linkCalc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Calc().ShowDialog();
        }
    }
}

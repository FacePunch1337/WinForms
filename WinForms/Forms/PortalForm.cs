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

        private readonly NLog.Logger _logger;
        public PortalForm(NLog.Logger logger)
        {
            InitializeComponent();
            _logger = logger;
        }

        private void linkLabelToControl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void linkCalc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Calc(_logger).ShowDialog();
        }
    }
}

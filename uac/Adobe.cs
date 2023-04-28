using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uac
{
    public partial class Adobe : Form
    {
        public Adobe()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Icon = Properties.Resources.alogo;
            this.pictureBox2.Image = Properties.Resources.bottom;
            this.pictureBox1.Image = Properties.Resources.junk;
            this.label1.BringToFront();
            this.label2.BringToFront();
            this.Text = "Adobe Acrobat Reader Setup";
        }
        public void SetProgressValue(int value)
        {
            progressBar1.Value = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

    }
}

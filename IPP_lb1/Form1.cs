using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace IPP_lb1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void bt_start_Click(object sender, EventArgs e)
        {
            ThreadController threadController = new ThreadController(tb_FThread, tb_SThread);

            
        }

        private void rb_FThread_CheckedChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        private void rb_FThread2_CheckedChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void rb_FThread3_CheckedChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void rb_SThread1_CheckedChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void rb_SThread2_CheckedChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void rb_SThread3_CheckedChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
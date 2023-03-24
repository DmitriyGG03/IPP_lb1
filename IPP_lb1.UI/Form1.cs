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
using IPP_lb1.BL;

namespace IPP_lb1.UI
{
    public partial class Form1 : Form
    {
        ThreadController threadController;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void bt_start_Click(object sender, EventArgs e)
        {
            threadController = new ThreadController(new UIThread[]
            {
                new UIThread(tb_FThread, tb_FThreadState, tb_FThreadTime),
                new UIThread(tb_SThread, tb_SThreadState, tb_SThreadTime)
            });
            pnl_FPriority.Enabled = true;
            pnl_SPriority.Enabled = true;
        }

        private void rb_FThread_CheckedChanged(object sender, EventArgs e)
        {
            threadController.Threads[0].ChangePriority(ThreadPriority.Lowest);
        }
        
        private void rb_FThread2_CheckedChanged(object sender, EventArgs e)
        {
            threadController.Threads[0].ChangePriority(ThreadPriority.Normal);
        }

        private void rb_FThread3_CheckedChanged(object sender, EventArgs e)
        {
            threadController.Threads[0].ChangePriority(ThreadPriority.Highest);
        }

        private void rb_SThread1_CheckedChanged(object sender, EventArgs e)
        {
            threadController.Threads[1].ChangePriority(ThreadPriority.Lowest);
        }

        private void rb_SThread2_CheckedChanged(object sender, EventArgs e)
        {
            threadController.Threads[1].ChangePriority(ThreadPriority.Normal);
        }

        private void rb_SThread3_CheckedChanged(object sender, EventArgs e)
        {
            threadController.Threads[1].ChangePriority(ThreadPriority.Highest);
        }
    }
}
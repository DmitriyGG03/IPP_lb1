using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace IPP_lb1.BL
{
    public class ThreadController

    {
        public UIThread[] Threads { get; set; }

        public ThreadController(UIThread[] uiThreads)
        {
            this.Threads = uiThreads;
            Array.ForEach(Threads, i => i.Thread = new Thread(PrintNumbers));

            StartThreads();
        }

        private void StartThreads()
        {
            foreach (UIThread uiThread in Threads)
            {
                uiThread.Thread.Start();
                uiThread.StartTime = DateTime.Now;
            }

            Task task = new Task(() => PrintInfo());
            task.Start();
        }

        private void PrintInfo()
        {
            while (true)
            {
                foreach (UIThread thread in Threads)
                {
                    //Set live time of thread in TB
                    TimeSpan workTime = thread.GetSubtractTime();
                    thread.TimeTextBox.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                        workTime.Hours, workTime.Minutes, workTime.Seconds,
                        workTime.Milliseconds);
                    
                    //Set state of thread
                    thread.StateTextBox.Text = thread.Thread.ThreadState.ToString();
                }
                
                // The delay required by the task
                Thread.Sleep(2 * 10 ^ 3);
            }
        }

        private void PrintNumbers()
        {
            var currentThread = Threads.First(i => i.Thread == Thread.CurrentThread);
            
            #region testDelay
            // if (currentThread == Threads[0])
            // {
            //     for (int i = 0; i < 100000; i++)
            //     {
            //         currentThread.MainTextBox.Text = (i + 1).ToString();
            //         Thread.Sleep(100 * 10 ^ 3);
            //     }
            // } else 
            #endregion
            
            for (int i = 0; i < 100000; i++)
            {
                currentThread.MainTextBox.Text = (i + 1).ToString();
                
                // The delay required by the task
                Thread.Sleep(10 * 10 ^ 3); //Comment to check the state
            }
        }
    }
}
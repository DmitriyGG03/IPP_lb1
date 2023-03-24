using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Threading;
using System.Windows.Forms;

namespace IPP_lb1
{
    public class ThreadController
    {
        private Thread thread1 { get; set; }
        private Thread thread2 { get; set; }
        
        public ThreadController(TextBox fld1, TextBox fld2)
        {
            thread1 = new Thread(Print);
            thread2 = new Thread(Print);
            thread1.Start(fld1);
            thread2.Start(fld2);
        }
        public void Print(object fld)
        {
            TextBox currectTextBox;
            
            if (fld is TextBox tb) currectTextBox = tb;
            else throw new ArgumentException();
            
            for (int i = 0; i < 100000; i++)
            {
                currectTextBox.Text = (i + 1).ToString();
            }
            
        }
    }
}
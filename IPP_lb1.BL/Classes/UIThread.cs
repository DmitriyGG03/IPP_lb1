using System;
using System.Threading;
using System.Windows.Forms;

namespace IPP_lb1.BL
{
    /// <summary>
    /// Have the thread and UI elements that can be used for output information
    /// </summary>
    public class UIThread : Time, IThread, IThreadFields
    {
        public Thread Thread { get; set; }
        public TextBox MainTextBox { get; set; }
        public TextBox StateTextBox { get; set; }
        public TextBox TimeTextBox { get; set; }
        
        public UIThread(TextBox mainTextBox, 
                        TextBox stateTextBox, 
                        TextBox timeTextBox, 
                        Thread thread = null,
                        DateTime? dateTime = null) : base(dateTime)
        {
            this.MainTextBox = mainTextBox;
            this.StateTextBox = stateTextBox;
            this.TimeTextBox = timeTextBox;
            if (Thread != null) this.Thread = thread;
        }

        public void ChangePriority(ThreadPriority tp) 
        {
            this.Thread.Priority = tp;
        }
    }
}
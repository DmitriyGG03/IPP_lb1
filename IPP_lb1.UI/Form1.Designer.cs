namespace IPP_lb1.UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_threadsData = new System.Windows.Forms.Panel();
            this.tb_SThreadTime = new System.Windows.Forms.TextBox();
            this.tb_SThreadState = new System.Windows.Forms.TextBox();
            this.tb_FThreadTime = new System.Windows.Forms.TextBox();
            this.tb_FThreadState = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_start = new System.Windows.Forms.Button();
            this.tb_SThread = new System.Windows.Forms.TextBox();
            this.tb_FThread = new System.Windows.Forms.TextBox();
            this.rb_FThread1 = new System.Windows.Forms.RadioButton();
            this.pnl_FPriority = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_FThread2 = new System.Windows.Forms.RadioButton();
            this.rb_FThread3 = new System.Windows.Forms.RadioButton();
            this.pnl_SPriority = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_SThread2 = new System.Windows.Forms.RadioButton();
            this.rb_SThread3 = new System.Windows.Forms.RadioButton();
            this.rb_SThread1 = new System.Windows.Forms.RadioButton();
            this.pnl_threadsData.SuspendLayout();
            this.pnl_FPriority.SuspendLayout();
            this.pnl_SPriority.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "First thread";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second thread";
            // 
            // pnl_threadsData
            // 
            this.pnl_threadsData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_threadsData.Controls.Add(this.tb_SThreadTime);
            this.pnl_threadsData.Controls.Add(this.tb_SThreadState);
            this.pnl_threadsData.Controls.Add(this.tb_FThreadTime);
            this.pnl_threadsData.Controls.Add(this.tb_FThreadState);
            this.pnl_threadsData.Controls.Add(this.label8);
            this.pnl_threadsData.Controls.Add(this.label7);
            this.pnl_threadsData.Controls.Add(this.label6);
            this.pnl_threadsData.Controls.Add(this.label5);
            this.pnl_threadsData.Controls.Add(this.bt_start);
            this.pnl_threadsData.Controls.Add(this.tb_SThread);
            this.pnl_threadsData.Controls.Add(this.tb_FThread);
            this.pnl_threadsData.Controls.Add(this.label2);
            this.pnl_threadsData.Controls.Add(this.label1);
            this.pnl_threadsData.Location = new System.Drawing.Point(20, 18);
            this.pnl_threadsData.Name = "pnl_threadsData";
            this.pnl_threadsData.Size = new System.Drawing.Size(344, 160);
            this.pnl_threadsData.TabIndex = 2;
            // 
            // tb_SThreadTime
            // 
            this.tb_SThreadTime.Location = new System.Drawing.Point(213, 132);
            this.tb_SThreadTime.Name = "tb_SThreadTime";
            this.tb_SThreadTime.ReadOnly = true;
            this.tb_SThreadTime.Size = new System.Drawing.Size(109, 20);
            this.tb_SThreadTime.TabIndex = 11;
            // 
            // tb_SThreadState
            // 
            this.tb_SThreadState.Location = new System.Drawing.Point(245, 94);
            this.tb_SThreadState.Name = "tb_SThreadState";
            this.tb_SThreadState.ReadOnly = true;
            this.tb_SThreadState.Size = new System.Drawing.Size(77, 20);
            this.tb_SThreadState.TabIndex = 10;
            // 
            // tb_FThreadTime
            // 
            this.tb_FThreadTime.Location = new System.Drawing.Point(23, 132);
            this.tb_FThreadTime.Name = "tb_FThreadTime";
            this.tb_FThreadTime.ReadOnly = true;
            this.tb_FThreadTime.Size = new System.Drawing.Size(109, 20);
            this.tb_FThreadTime.TabIndex = 9;
            // 
            // tb_FThreadState
            // 
            this.tb_FThreadState.Location = new System.Drawing.Point(55, 94);
            this.tb_FThreadState.Name = "tb_FThreadState";
            this.tb_FThreadState.ReadOnly = true;
            this.tb_FThreadState.Size = new System.Drawing.Size(77, 20);
            this.tb_FThreadState.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(210, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "State:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(21, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "State:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(210, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Execution time:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Execution time:";
            // 
            // bt_start
            // 
            this.bt_start.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_start.Location = new System.Drawing.Point(139, 51);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(65, 40);
            this.bt_start.TabIndex = 1;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // tb_SThread
            // 
            this.tb_SThread.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SThread.Location = new System.Drawing.Point(210, 51);
            this.tb_SThread.Multiline = true;
            this.tb_SThread.Name = "tb_SThread";
            this.tb_SThread.ReadOnly = true;
            this.tb_SThread.Size = new System.Drawing.Size(112, 40);
            this.tb_SThread.TabIndex = 3;
            this.tb_SThread.TabStop = false;
            this.tb_SThread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_FThread
            // 
            this.tb_FThread.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FThread.Location = new System.Drawing.Point(21, 51);
            this.tb_FThread.Multiline = true;
            this.tb_FThread.Name = "tb_FThread";
            this.tb_FThread.ReadOnly = true;
            this.tb_FThread.ShortcutsEnabled = false;
            this.tb_FThread.Size = new System.Drawing.Size(112, 40);
            this.tb_FThread.TabIndex = 2;
            this.tb_FThread.TabStop = false;
            this.tb_FThread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rb_FThread1
            // 
            this.rb_FThread1.Location = new System.Drawing.Point(3, 63);
            this.rb_FThread1.Name = "rb_FThread1";
            this.rb_FThread1.Size = new System.Drawing.Size(64, 25);
            this.rb_FThread1.TabIndex = 2;
            this.rb_FThread1.Text = "Lowest";
            this.rb_FThread1.UseVisualStyleBackColor = true;
            this.rb_FThread1.CheckedChanged += new System.EventHandler(this.rb_FThread_CheckedChanged);
            // 
            // pnl_FPriority
            // 
            this.pnl_FPriority.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_FPriority.Controls.Add(this.label3);
            this.pnl_FPriority.Controls.Add(this.rb_FThread2);
            this.pnl_FPriority.Controls.Add(this.rb_FThread3);
            this.pnl_FPriority.Controls.Add(this.rb_FThread1);
            this.pnl_FPriority.Enabled = false;
            this.pnl_FPriority.Location = new System.Drawing.Point(28, 184);
            this.pnl_FPriority.Name = "pnl_FPriority";
            this.pnl_FPriority.Size = new System.Drawing.Size(125, 153);
            this.pnl_FPriority.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "First thread priority\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rb_FThread2
            // 
            this.rb_FThread2.Checked = true;
            this.rb_FThread2.Location = new System.Drawing.Point(3, 94);
            this.rb_FThread2.Name = "rb_FThread2";
            this.rb_FThread2.Size = new System.Drawing.Size(64, 25);
            this.rb_FThread2.TabIndex = 3;
            this.rb_FThread2.TabStop = true;
            this.rb_FThread2.Text = "Medium";
            this.rb_FThread2.UseVisualStyleBackColor = true;
            this.rb_FThread2.CheckedChanged += new System.EventHandler(this.rb_FThread2_CheckedChanged);
            // 
            // rb_FThread3
            // 
            this.rb_FThread3.Location = new System.Drawing.Point(3, 125);
            this.rb_FThread3.Name = "rb_FThread3";
            this.rb_FThread3.Size = new System.Drawing.Size(64, 25);
            this.rb_FThread3.TabIndex = 4;
            this.rb_FThread3.Text = "Highest";
            this.rb_FThread3.UseVisualStyleBackColor = true;
            this.rb_FThread3.CheckedChanged += new System.EventHandler(this.rb_FThread3_CheckedChanged);
            // 
            // pnl_SPriority
            // 
            this.pnl_SPriority.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_SPriority.Controls.Add(this.label4);
            this.pnl_SPriority.Controls.Add(this.rb_SThread2);
            this.pnl_SPriority.Controls.Add(this.rb_SThread3);
            this.pnl_SPriority.Controls.Add(this.rb_SThread1);
            this.pnl_SPriority.Enabled = false;
            this.pnl_SPriority.Location = new System.Drawing.Point(231, 184);
            this.pnl_SPriority.Name = "pnl_SPriority";
            this.pnl_SPriority.Size = new System.Drawing.Size(125, 153);
            this.pnl_SPriority.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 46);
            this.label4.TabIndex = 5;
            this.label4.Text = "Second thread priority\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rb_SThread2
            // 
            this.rb_SThread2.Checked = true;
            this.rb_SThread2.Location = new System.Drawing.Point(3, 94);
            this.rb_SThread2.Name = "rb_SThread2";
            this.rb_SThread2.Size = new System.Drawing.Size(64, 25);
            this.rb_SThread2.TabIndex = 6;
            this.rb_SThread2.TabStop = true;
            this.rb_SThread2.Text = "Medium";
            this.rb_SThread2.UseVisualStyleBackColor = true;
            this.rb_SThread2.CheckedChanged += new System.EventHandler(this.rb_SThread2_CheckedChanged);
            // 
            // rb_SThread3
            // 
            this.rb_SThread3.Location = new System.Drawing.Point(3, 125);
            this.rb_SThread3.Name = "rb_SThread3";
            this.rb_SThread3.Size = new System.Drawing.Size(64, 25);
            this.rb_SThread3.TabIndex = 7;
            this.rb_SThread3.Text = "Highest";
            this.rb_SThread3.UseVisualStyleBackColor = true;
            this.rb_SThread3.CheckedChanged += new System.EventHandler(this.rb_SThread3_CheckedChanged);
            // 
            // rb_SThread1
            // 
            this.rb_SThread1.Location = new System.Drawing.Point(3, 63);
            this.rb_SThread1.Name = "rb_SThread1";
            this.rb_SThread1.Size = new System.Drawing.Size(64, 25);
            this.rb_SThread1.TabIndex = 5;
            this.rb_SThread1.Text = "Lowest";
            this.rb_SThread1.UseVisualStyleBackColor = true;
            this.rb_SThread1.CheckedChanged += new System.EventHandler(this.rb_SThread1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 349);
            this.Controls.Add(this.pnl_SPriority);
            this.Controls.Add(this.pnl_FPriority);
            this.Controls.Add(this.pnl_threadsData);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multithreaded application";
            this.pnl_threadsData.ResumeLayout(false);
            this.pnl_threadsData.PerformLayout();
            this.pnl_FPriority.ResumeLayout(false);
            this.pnl_SPriority.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox tb_FThreadState;
        private System.Windows.Forms.TextBox tb_FThreadTime;
        private System.Windows.Forms.TextBox tb_SThreadState;
        private System.Windows.Forms.TextBox tb_SThreadTime;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button bt_start;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_SPriority;
        private System.Windows.Forms.RadioButton rb_SThread2;
        private System.Windows.Forms.RadioButton rb_SThread3;
        private System.Windows.Forms.RadioButton rb_SThread1;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Panel pnl_FPriority;
        private System.Windows.Forms.RadioButton rb_FThread3;
        private System.Windows.Forms.RadioButton rb_FThread2;

        private System.Windows.Forms.RadioButton rb_FThread1;

        private System.Windows.Forms.TextBox tb_SThread;

        private System.Windows.Forms.Panel pnl_threadsData;
        private System.Windows.Forms.TextBox tb_FThread;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}
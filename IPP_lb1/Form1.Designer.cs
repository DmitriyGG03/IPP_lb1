namespace IPP_lb1
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
            this.tb_SThread = new System.Windows.Forms.TextBox();
            this.tb_FThread = new System.Windows.Forms.TextBox();
            this.rb_FThread = new System.Windows.Forms.RadioButton();
            this.pnt_FPriority = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.pnl_threadsData.SuspendLayout();
            this.pnt_FPriority.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnl_threadsData.Controls.Add(this.tb_SThread);
            this.pnl_threadsData.Controls.Add(this.tb_FThread);
            this.pnl_threadsData.Controls.Add(this.label2);
            this.pnl_threadsData.Controls.Add(this.label1);
            this.pnl_threadsData.Location = new System.Drawing.Point(20, 18);
            this.pnl_threadsData.Name = "pnl_threadsData";
            this.pnl_threadsData.Size = new System.Drawing.Size(344, 153);
            this.pnl_threadsData.TabIndex = 2;
            // 
            // tb_SThread
            // 
            this.tb_SThread.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SThread.Location = new System.Drawing.Point(195, 51);
            this.tb_SThread.Multiline = true;
            this.tb_SThread.Name = "tb_SThread";
            this.tb_SThread.ReadOnly = true;
            this.tb_SThread.Size = new System.Drawing.Size(140, 77);
            this.tb_SThread.TabIndex = 3;
            this.tb_SThread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_FThread
            // 
            this.tb_FThread.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FThread.Location = new System.Drawing.Point(8, 51);
            this.tb_FThread.Multiline = true;
            this.tb_FThread.Name = "tb_FThread";
            this.tb_FThread.ReadOnly = true;
            this.tb_FThread.Size = new System.Drawing.Size(140, 77);
            this.tb_FThread.TabIndex = 2;
            this.tb_FThread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rb_FThread
            // 
            this.rb_FThread.Location = new System.Drawing.Point(3, 63);
            this.rb_FThread.Name = "rb_FThread";
            this.rb_FThread.Size = new System.Drawing.Size(50, 25);
            this.rb_FThread.TabIndex = 3;
            this.rb_FThread.TabStop = true;
            this.rb_FThread.Text = "Low";
            this.rb_FThread.UseVisualStyleBackColor = true;
            this.rb_FThread.CheckedChanged += new System.EventHandler(this.rb_FThread_CheckedChanged);
            // 
            // pnt_FPriority
            // 
            this.pnt_FPriority.Controls.Add(this.label3);
            this.pnt_FPriority.Controls.Add(this.radioButton2);
            this.pnt_FPriority.Controls.Add(this.radioButton1);
            this.pnt_FPriority.Controls.Add(this.rb_FThread);
            this.pnt_FPriority.Location = new System.Drawing.Point(28, 177);
            this.pnt_FPriority.Name = "pnt_FPriority";
            this.pnt_FPriority.Size = new System.Drawing.Size(125, 153);
            this.pnt_FPriority.TabIndex = 4;
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
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(3, 94);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 25);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Medium";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(3, 125);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 25);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hight";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Location = new System.Drawing.Point(230, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 153);
            this.panel1.TabIndex = 5;
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
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(3, 94);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 25);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Medium";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.Location = new System.Drawing.Point(3, 125);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(50, 25);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Hight";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.Location = new System.Drawing.Point(3, 63);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(50, 25);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Low";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 339);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnt_FPriority);
            this.Controls.Add(this.pnl_threadsData);
            this.Name = "Form1";
            this.Text = "Multithreaded application";
            this.pnl_threadsData.ResumeLayout(false);
            this.pnl_threadsData.PerformLayout();
            this.pnt_FPriority.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Panel pnt_FPriority;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;

        private System.Windows.Forms.RadioButton rb_FThread;

        private System.Windows.Forms.TextBox tb_SThread;

        private System.Windows.Forms.Panel pnl_threadsData;
        private System.Windows.Forms.TextBox tb_FThread;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}
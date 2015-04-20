namespace Timer
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
            this.components = new System.ComponentModel.Container();
            this.gbSet = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.secondsTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSet
            // 
            this.gbSet.Controls.Add(this.btnSet);
            this.gbSet.Controls.Add(this.txtSecond);
            this.gbSet.Controls.Add(this.txtMinute);
            this.gbSet.Controls.Add(this.txtHour);
            this.gbSet.Controls.Add(this.label3);
            this.gbSet.Controls.Add(this.label2);
            this.gbSet.Controls.Add(this.label1);
            this.gbSet.Location = new System.Drawing.Point(12, 12);
            this.gbSet.Name = "gbSet";
            this.gbSet.Size = new System.Drawing.Size(412, 177);
            this.gbSet.TabIndex = 0;
            this.gbSet.TabStop = false;
            this.gbSet.Text = "Set";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Second";
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(6, 67);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(100, 22);
            this.txtHour.TabIndex = 3;
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(112, 67);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(100, 22);
            this.txtMinute.TabIndex = 4;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(218, 67);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 22);
            this.txtSecond.TabIndex = 5;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(124, 115);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(100, 56);
            this.btnSet.TabIndex = 6;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // secondsTimer
            // 
            this.secondsTimer.Interval = 1000;
            this.secondsTimer.Tick += new System.EventHandler(this.secondsTimer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(27, 210);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(369, 145);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "label4";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(52, 413);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(220, 105);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(278, 413);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(220, 105);
            this.btnPause.TabIndex = 8;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(504, 413);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(220, 105);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 552);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.gbSet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSet.ResumeLayout(false);
            this.gbSet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Timer secondsTimer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
    }
}



namespace RegisterUser_CSharp
{
    partial class stopWatch
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
            this.lblSetMinutes = new System.Windows.Forms.Label();
            this.lblSetHours = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.txtSetSeconds = new System.Windows.Forms.TextBox();
            this.txtSetMinutes = new System.Windows.Forms.TextBox();
            this.lblSetSeconds = new System.Windows.Forms.Label();
            this.setTimePanel = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtSetHours = new System.Windows.Forms.TextBox();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.lblSeperatorTwo = new System.Windows.Forms.Label();
            this.lblSeperatorOne = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHours = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.setTimePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSetMinutes
            // 
            this.lblSetMinutes.AutoSize = true;
            this.lblSetMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetMinutes.Location = new System.Drawing.Point(3, 72);
            this.lblSetMinutes.Name = "lblSetMinutes";
            this.lblSetMinutes.Size = new System.Drawing.Size(149, 39);
            this.lblSetMinutes.TabIndex = 0;
            this.lblSetMinutes.Text = "Minutes:";
            // 
            // lblSetHours
            // 
            this.lblSetHours.AutoSize = true;
            this.lblSetHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetHours.Location = new System.Drawing.Point(3, 10);
            this.lblSetHours.Name = "lblSetHours";
            this.lblSetHours.Size = new System.Drawing.Size(120, 39);
            this.lblSetHours.TabIndex = 0;
            this.lblSetHours.Text = "Hours:";
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(414, 323);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(141, 66);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(242, 323);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(141, 66);
            this.btnPause.TabIndex = 12;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(68, 323);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 66);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(447, 182);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(108, 75);
            this.lblSeconds.TabIndex = 6;
            this.lblSeconds.Text = "00";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(256, 182);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(108, 75);
            this.lblMinutes.TabIndex = 7;
            this.lblMinutes.Text = "00";
            // 
            // txtSetSeconds
            // 
            this.txtSetSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetSeconds.Location = new System.Drawing.Point(176, 132);
            this.txtSetSeconds.MaxLength = 2;
            this.txtSetSeconds.Name = "txtSetSeconds";
            this.txtSetSeconds.Size = new System.Drawing.Size(71, 47);
            this.txtSetSeconds.TabIndex = 1;
            // 
            // txtSetMinutes
            // 
            this.txtSetMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetMinutes.Location = new System.Drawing.Point(176, 69);
            this.txtSetMinutes.MaxLength = 2;
            this.txtSetMinutes.Name = "txtSetMinutes";
            this.txtSetMinutes.Size = new System.Drawing.Size(71, 47);
            this.txtSetMinutes.TabIndex = 1;
            // 
            // lblSetSeconds
            // 
            this.lblSetSeconds.AutoSize = true;
            this.lblSetSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetSeconds.Location = new System.Drawing.Point(3, 135);
            this.lblSetSeconds.Name = "lblSetSeconds";
            this.lblSetSeconds.Size = new System.Drawing.Size(162, 39);
            this.lblSetSeconds.TabIndex = 0;
            this.lblSetSeconds.Text = "Seconds:";
            // 
            // setTimePanel
            // 
            this.setTimePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.setTimePanel.Controls.Add(this.btnApply);
            this.setTimePanel.Controls.Add(this.txtSetSeconds);
            this.setTimePanel.Controls.Add(this.txtSetMinutes);
            this.setTimePanel.Controls.Add(this.lblSetSeconds);
            this.setTimePanel.Controls.Add(this.lblSetMinutes);
            this.setTimePanel.Controls.Add(this.txtSetHours);
            this.setTimePanel.Controls.Add(this.lblSetHours);
            this.setTimePanel.Location = new System.Drawing.Point(646, 173);
            this.setTimePanel.Name = "setTimePanel";
            this.setTimePanel.Size = new System.Drawing.Size(254, 306);
            this.setTimePanel.TabIndex = 15;
            this.setTimePanel.Visible = false;
            // 
            // btnApply
            // 
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(153, 205);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(94, 39);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtSetHours
            // 
            this.txtSetHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetHours.Location = new System.Drawing.Point(176, 7);
            this.txtSetHours.MaxLength = 2;
            this.txtSetHours.Name = "txtSetHours";
            this.txtSetHours.Size = new System.Drawing.Size(71, 47);
            this.txtSetHours.TabIndex = 1;
            // 
            // btnSetTime
            // 
            this.btnSetTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTime.Location = new System.Drawing.Point(646, 75);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(254, 93);
            this.btnSetTime.TabIndex = 14;
            this.btnSetTime.Text = "Set Time";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // lblSeperatorTwo
            // 
            this.lblSeperatorTwo.AutoSize = true;
            this.lblSeperatorTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeperatorTwo.Location = new System.Drawing.Point(370, 173);
            this.lblSeperatorTwo.Name = "lblSeperatorTwo";
            this.lblSeperatorTwo.Size = new System.Drawing.Size(70, 73);
            this.lblSeperatorTwo.TabIndex = 8;
            this.lblSeperatorTwo.Text = "::";
            // 
            // lblSeperatorOne
            // 
            this.lblSeperatorOne.AutoSize = true;
            this.lblSeperatorOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeperatorOne.Location = new System.Drawing.Point(182, 173);
            this.lblSeperatorOne.Name = "lblSeperatorOne";
            this.lblSeperatorOne.Size = new System.Drawing.Size(70, 73);
            this.lblSeperatorOne.TabIndex = 9;
            this.lblSeperatorOne.Text = "::";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(68, 182);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(108, 75);
            this.lblHours.TabIndex = 10;
            this.lblHours.Text = "00";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(178, 85);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(265, 39);
            this.lblHeading.TabIndex = 5;
            this.lblHeading.Text = "My Stop Watch";
            // 
            // stopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 554);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.setTimePanel);
            this.Controls.Add(this.btnSetTime);
            this.Controls.Add(this.lblSeperatorTwo);
            this.Controls.Add(this.lblSeperatorOne);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblHeading);
            this.Name = "stopWatch";
            this.Text = "stopWatch";
            this.setTimePanel.ResumeLayout(false);
            this.setTimePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSetMinutes;
        private System.Windows.Forms.Label lblSetHours;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.TextBox txtSetSeconds;
        private System.Windows.Forms.TextBox txtSetMinutes;
        private System.Windows.Forms.Label lblSetSeconds;
        private System.Windows.Forms.Panel setTimePanel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtSetHours;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.Label lblSeperatorTwo;
        private System.Windows.Forms.Label lblSeperatorOne;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblHeading;
    }
}
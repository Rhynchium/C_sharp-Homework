namespace Homework1
{
    partial class Homework_Final_Alarm
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tex_Sec = new System.Windows.Forms.TextBox();
            this.tex_Min = new System.Windows.Forms.TextBox();
            this.tex_Hour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SetAlarm = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_Clock = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tex_Sec);
            this.groupBox1.Controls.Add(this.tex_Min);
            this.groupBox1.Controls.Add(this.tex_Hour);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SetAlarm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(51, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "設置時間";
            // 
            // tex_Sec
            // 
            this.tex_Sec.Location = new System.Drawing.Point(301, 120);
            this.tex_Sec.Name = "tex_Sec";
            this.tex_Sec.Size = new System.Drawing.Size(50, 33);
            this.tex_Sec.TabIndex = 6;
            // 
            // tex_Min
            // 
            this.tex_Min.Location = new System.Drawing.Point(227, 120);
            this.tex_Min.Name = "tex_Min";
            this.tex_Min.Size = new System.Drawing.Size(50, 33);
            this.tex_Min.TabIndex = 5;
            // 
            // tex_Hour
            // 
            this.tex_Hour.Location = new System.Drawing.Point(153, 120);
            this.tex_Hour.Name = "tex_Hour";
            this.tex_Hour.Size = new System.Drawing.Size(50, 33);
            this.tex_Hour.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "秒";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "分";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "時";
            // 
            // SetAlarm
            // 
            this.SetAlarm.AutoSize = true;
            this.SetAlarm.Location = new System.Drawing.Point(191, 217);
            this.SetAlarm.Name = "SetAlarm";
            this.SetAlarm.Size = new System.Drawing.Size(105, 28);
            this.SetAlarm.TabIndex = 3;
            this.SetAlarm.Text = "設置鬧鐘";
            this.SetAlarm.UseVisualStyleBackColor = true;
            this.SetAlarm.CheckedChanged += new System.EventHandler(this.SetAlarm_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "鬧鐘時間：";
            // 
            // lab_Clock
            // 
            this.lab_Clock.AutoSize = true;
            this.lab_Clock.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Clock.Location = new System.Drawing.Point(43, 32);
            this.lab_Clock.Name = "lab_Clock";
            this.lab_Clock.Size = new System.Drawing.Size(159, 44);
            this.lab_Clock.TabIndex = 1;
            this.lab_Clock.Text = "現在時間";
            // 
            // Homework_Final_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 448);
            this.Controls.Add(this.lab_Clock);
            this.Controls.Add(this.groupBox1);
            this.Name = "Homework_Final_Alarm";
            this.Text = "Homework_Final_Alarm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_Clock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox SetAlarm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tex_Sec;
        private System.Windows.Forms.TextBox tex_Min;
        private System.Windows.Forms.TextBox tex_Hour;
    }
}
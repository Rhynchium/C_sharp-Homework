namespace Homework
{
    partial class Homework2
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
            this.but_PMT = new System.Windows.Forms.Button();
            this.but_total = new System.Windows.Forms.Button();
            this.but_report = new System.Windows.Forms.Button();
            this.lab_loan = new System.Windows.Forms.Label();
            this.lab_duration = new System.Windows.Forms.Label();
            this.lab_rate = new System.Windows.Forms.Label();
            this.lab_head = new System.Windows.Forms.Label();
            this.tex_loan = new System.Windows.Forms.TextBox();
            this.tex_yearduration = new System.Windows.Forms.TextBox();
            this.tex_yearratio = new System.Windows.Forms.TextBox();
            this.tex_head = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // but_PMT
            // 
            this.but_PMT.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_PMT.Location = new System.Drawing.Point(18, 277);
            this.but_PMT.Name = "but_PMT";
            this.but_PMT.Size = new System.Drawing.Size(132, 46);
            this.but_PMT.TabIndex = 0;
            this.but_PMT.Text = "PMT(月付)";
            this.but_PMT.UseVisualStyleBackColor = true;
            this.but_PMT.Click += new System.EventHandler(this.but_PMT_Click);
            // 
            // but_total
            // 
            this.but_total.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_total.Location = new System.Drawing.Point(178, 277);
            this.but_total.Name = "but_total";
            this.but_total.Size = new System.Drawing.Size(132, 46);
            this.but_total.TabIndex = 1;
            this.but_total.Text = "總付款";
            this.but_total.UseVisualStyleBackColor = true;
            this.but_total.Click += new System.EventHandler(this.but_total_Click);
            // 
            // but_report
            // 
            this.but_report.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_report.Location = new System.Drawing.Point(373, 277);
            this.but_report.Name = "but_report";
            this.but_report.Size = new System.Drawing.Size(132, 46);
            this.but_report.TabIndex = 2;
            this.but_report.Text = "Report";
            this.but_report.UseVisualStyleBackColor = true;
            this.but_report.Click += new System.EventHandler(this.but_report_Click);
            // 
            // lab_loan
            // 
            this.lab_loan.AutoSize = true;
            this.lab_loan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lab_loan.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_loan.ForeColor = System.Drawing.Color.Cornsilk;
            this.lab_loan.Location = new System.Drawing.Point(85, 38);
            this.lab_loan.Name = "lab_loan";
            this.lab_loan.Size = new System.Drawing.Size(157, 34);
            this.lab_loan.TabIndex = 3;
            this.lab_loan.Text = "貸款金額($)";
            // 
            // lab_duration
            // 
            this.lab_duration.AutoSize = true;
            this.lab_duration.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lab_duration.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_duration.ForeColor = System.Drawing.Color.Cornsilk;
            this.lab_duration.Location = new System.Drawing.Point(85, 91);
            this.lab_duration.Name = "lab_duration";
            this.lab_duration.Size = new System.Drawing.Size(114, 34);
            this.lab_duration.TabIndex = 4;
            this.lab_duration.Text = "期限(年)";
            // 
            // lab_rate
            // 
            this.lab_rate.AutoSize = true;
            this.lab_rate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lab_rate.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_rate.ForeColor = System.Drawing.Color.Cornsilk;
            this.lab_rate.Location = new System.Drawing.Point(85, 146);
            this.lab_rate.Name = "lab_rate";
            this.lab_rate.Size = new System.Drawing.Size(111, 34);
            this.lab_rate.TabIndex = 5;
            this.lab_rate.Text = "利率(%)";
            // 
            // lab_head
            // 
            this.lab_head.AutoSize = true;
            this.lab_head.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lab_head.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_head.ForeColor = System.Drawing.Color.Cornsilk;
            this.lab_head.Location = new System.Drawing.Point(85, 198);
            this.lab_head.Name = "lab_head";
            this.lab_head.Size = new System.Drawing.Size(130, 34);
            this.lab_head.TabIndex = 6;
            this.lab_head.Text = "頭期款($)";
            // 
            // tex_loan
            // 
            this.tex_loan.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_loan.Location = new System.Drawing.Point(293, 29);
            this.tex_loan.Name = "tex_loan";
            this.tex_loan.Size = new System.Drawing.Size(140, 43);
            this.tex_loan.TabIndex = 7;
            this.tex_loan.Text = "100000";
            // 
            // tex_yearduration
            // 
            this.tex_yearduration.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_yearduration.Location = new System.Drawing.Point(293, 82);
            this.tex_yearduration.Name = "tex_yearduration";
            this.tex_yearduration.Size = new System.Drawing.Size(140, 43);
            this.tex_yearduration.TabIndex = 8;
            this.tex_yearduration.Text = "2";
            // 
            // tex_yearratio
            // 
            this.tex_yearratio.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_yearratio.Location = new System.Drawing.Point(293, 137);
            this.tex_yearratio.Name = "tex_yearratio";
            this.tex_yearratio.Size = new System.Drawing.Size(140, 43);
            this.tex_yearratio.TabIndex = 9;
            this.tex_yearratio.Text = "10";
            // 
            // tex_head
            // 
            this.tex_head.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_head.Location = new System.Drawing.Point(293, 194);
            this.tex_head.Name = "tex_head";
            this.tex_head.Size = new System.Drawing.Size(140, 43);
            this.tex_head.TabIndex = 10;
            this.tex_head.Text = "0";
            // 
            // Homework2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(524, 348);
            this.Controls.Add(this.tex_head);
            this.Controls.Add(this.tex_yearratio);
            this.Controls.Add(this.tex_yearduration);
            this.Controls.Add(this.tex_loan);
            this.Controls.Add(this.lab_head);
            this.Controls.Add(this.lab_rate);
            this.Controls.Add(this.lab_duration);
            this.Controls.Add(this.lab_loan);
            this.Controls.Add(this.but_report);
            this.Controls.Add(this.but_total);
            this.Controls.Add(this.but_PMT);
            this.Name = "Homework2";
            this.Text = "Homework2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_PMT;
        private System.Windows.Forms.Button but_total;
        private System.Windows.Forms.Button but_report;
        private System.Windows.Forms.Label lab_loan;
        private System.Windows.Forms.Label lab_duration;
        private System.Windows.Forms.Label lab_rate;
        private System.Windows.Forms.Label lab_head;
        private System.Windows.Forms.TextBox tex_loan;
        private System.Windows.Forms.TextBox tex_yearduration;
        private System.Windows.Forms.TextBox tex_yearratio;
        private System.Windows.Forms.TextBox tex_head;
    }
}
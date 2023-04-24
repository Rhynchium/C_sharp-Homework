namespace Homework
{
    partial class Homework4
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
            this.group_Score = new System.Windows.Forms.GroupBox();
            this.tex_ShowScore = new System.Windows.Forms.TextBox();
            this.tex_Datalist = new System.Windows.Forms.TextBox();
            this.tex_Name = new System.Windows.Forms.TextBox();
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_Chinese = new System.Windows.Forms.Label();
            this.tex_Chinese = new System.Windows.Forms.TextBox();
            this.lab_English = new System.Windows.Forms.Label();
            this.tex_English = new System.Windows.Forms.TextBox();
            this.lab_Math = new System.Windows.Forms.Label();
            this.tex_Math = new System.Windows.Forms.TextBox();
            this.but_Save = new System.Windows.Forms.Button();
            this.but_Showsave = new System.Windows.Forms.Button();
            this.but_Showscore = new System.Windows.Forms.Button();
            this.group_Score.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_Score
            // 
            this.group_Score.Controls.Add(this.tex_ShowScore);
            this.group_Score.Controls.Add(this.tex_Datalist);
            this.group_Score.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.group_Score.Location = new System.Drawing.Point(348, 20);
            this.group_Score.Name = "group_Score";
            this.group_Score.Size = new System.Drawing.Size(332, 362);
            this.group_Score.TabIndex = 0;
            this.group_Score.TabStop = false;
            this.group_Score.Text = "成績";
            // 
            // tex_ShowScore
            // 
            this.tex_ShowScore.Location = new System.Drawing.Point(6, 265);
            this.tex_ShowScore.Multiline = true;
            this.tex_ShowScore.Name = "tex_ShowScore";
            this.tex_ShowScore.ReadOnly = true;
            this.tex_ShowScore.Size = new System.Drawing.Size(320, 91);
            this.tex_ShowScore.TabIndex = 1;
            // 
            // tex_Datalist
            // 
            this.tex_Datalist.Location = new System.Drawing.Point(6, 33);
            this.tex_Datalist.Multiline = true;
            this.tex_Datalist.Name = "tex_Datalist";
            this.tex_Datalist.ReadOnly = true;
            this.tex_Datalist.Size = new System.Drawing.Size(320, 226);
            this.tex_Datalist.TabIndex = 0;
            // 
            // tex_Name
            // 
            this.tex_Name.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_Name.Location = new System.Drawing.Point(137, 53);
            this.tex_Name.Name = "tex_Name";
            this.tex_Name.Size = new System.Drawing.Size(126, 35);
            this.tex_Name.TabIndex = 1;
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Name.Location = new System.Drawing.Point(56, 56);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(75, 27);
            this.lab_Name.TabIndex = 2;
            this.lab_Name.Text = "姓名：";
            // 
            // lab_Chinese
            // 
            this.lab_Chinese.AutoSize = true;
            this.lab_Chinese.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Chinese.Location = new System.Drawing.Point(56, 110);
            this.lab_Chinese.Name = "lab_Chinese";
            this.lab_Chinese.Size = new System.Drawing.Size(75, 27);
            this.lab_Chinese.TabIndex = 4;
            this.lab_Chinese.Text = "國文：";
            // 
            // tex_Chinese
            // 
            this.tex_Chinese.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_Chinese.Location = new System.Drawing.Point(137, 107);
            this.tex_Chinese.Name = "tex_Chinese";
            this.tex_Chinese.Size = new System.Drawing.Size(126, 35);
            this.tex_Chinese.TabIndex = 3;
            // 
            // lab_English
            // 
            this.lab_English.AutoSize = true;
            this.lab_English.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_English.Location = new System.Drawing.Point(56, 164);
            this.lab_English.Name = "lab_English";
            this.lab_English.Size = new System.Drawing.Size(75, 27);
            this.lab_English.TabIndex = 6;
            this.lab_English.Text = "英文：";
            // 
            // tex_English
            // 
            this.tex_English.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_English.Location = new System.Drawing.Point(137, 161);
            this.tex_English.Name = "tex_English";
            this.tex_English.Size = new System.Drawing.Size(126, 35);
            this.tex_English.TabIndex = 5;
            // 
            // lab_Math
            // 
            this.lab_Math.AutoSize = true;
            this.lab_Math.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Math.Location = new System.Drawing.Point(56, 218);
            this.lab_Math.Name = "lab_Math";
            this.lab_Math.Size = new System.Drawing.Size(75, 27);
            this.lab_Math.TabIndex = 8;
            this.lab_Math.Text = "數學：";
            // 
            // tex_Math
            // 
            this.tex_Math.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_Math.Location = new System.Drawing.Point(137, 215);
            this.tex_Math.Name = "tex_Math";
            this.tex_Math.Size = new System.Drawing.Size(126, 35);
            this.tex_Math.TabIndex = 7;
            // 
            // but_Save
            // 
            this.but_Save.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Save.Location = new System.Drawing.Point(12, 346);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(148, 36);
            this.but_Save.TabIndex = 9;
            this.but_Save.Text = "儲存";
            this.but_Save.UseVisualStyleBackColor = true;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // but_Showsave
            // 
            this.but_Showsave.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Showsave.Location = new System.Drawing.Point(178, 346);
            this.but_Showsave.Name = "but_Showsave";
            this.but_Showsave.Size = new System.Drawing.Size(148, 36);
            this.but_Showsave.TabIndex = 10;
            this.but_Showsave.Text = "顯示儲存內容";
            this.but_Showsave.UseVisualStyleBackColor = true;
            this.but_Showsave.Click += new System.EventHandler(this.but_Showsave_Click);
            // 
            // but_Showscore
            // 
            this.but_Showscore.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Showscore.Location = new System.Drawing.Point(457, 388);
            this.but_Showscore.Name = "but_Showscore";
            this.but_Showscore.Size = new System.Drawing.Size(223, 36);
            this.but_Showscore.TabIndex = 11;
            this.but_Showscore.Text = "最高分/最低分科目";
            this.but_Showscore.UseVisualStyleBackColor = true;
            this.but_Showscore.Click += new System.EventHandler(this.but_Showscore_Click);
            // 
            // Homework4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 443);
            this.Controls.Add(this.but_Showscore);
            this.Controls.Add(this.but_Showsave);
            this.Controls.Add(this.but_Save);
            this.Controls.Add(this.lab_Math);
            this.Controls.Add(this.tex_Math);
            this.Controls.Add(this.lab_English);
            this.Controls.Add(this.tex_English);
            this.Controls.Add(this.lab_Chinese);
            this.Controls.Add(this.tex_Chinese);
            this.Controls.Add(this.lab_Name);
            this.Controls.Add(this.tex_Name);
            this.Controls.Add(this.group_Score);
            this.Name = "Homework4";
            this.Text = "Homework4";
            this.group_Score.ResumeLayout(false);
            this.group_Score.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group_Score;
        private System.Windows.Forms.TextBox tex_Name;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Label lab_Chinese;
        private System.Windows.Forms.TextBox tex_Chinese;
        private System.Windows.Forms.Label lab_English;
        private System.Windows.Forms.TextBox tex_English;
        private System.Windows.Forms.Label lab_Math;
        private System.Windows.Forms.TextBox tex_Math;
        private System.Windows.Forms.Button but_Save;
        private System.Windows.Forms.Button but_Showsave;
        private System.Windows.Forms.Button but_Showscore;
        private System.Windows.Forms.TextBox tex_ShowScore;
        private System.Windows.Forms.TextBox tex_Datalist;
    }
}
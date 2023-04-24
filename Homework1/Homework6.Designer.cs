namespace Homework
{
    partial class Homework6
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
            this.list_Cacu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCChinese = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCEnglish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCMath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_Data = new System.Windows.Forms.ListView();
            this.column_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Chinese = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_English = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Math = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Average = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Bottom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Top = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.but_SEARCH = new System.Windows.Forms.Button();
            this.but_Clear = new System.Windows.Forms.Button();
            this.but_Caculate = new System.Windows.Forms.Button();
            this.but_Adddata = new System.Windows.Forms.Button();
            this.lab_Math = new System.Windows.Forms.Label();
            this.tex_Math = new System.Windows.Forms.TextBox();
            this.lab_English = new System.Windows.Forms.Label();
            this.tex_English = new System.Windows.Forms.TextBox();
            this.lab_Chinese = new System.Windows.Forms.Label();
            this.tex_Chinese = new System.Windows.Forms.TextBox();
            this.lab_Name = new System.Windows.Forms.Label();
            this.tex_Name = new System.Windows.Forms.TextBox();
            this.but_Insert = new System.Windows.Forms.Button();
            this.but_RemoveAt = new System.Windows.Forms.Button();
            this.lab_Search = new System.Windows.Forms.Label();
            this.tex_LowRange = new System.Windows.Forms.TextBox();
            this.tex_HighRange = new System.Windows.Forms.TextBox();
            this.label_DASH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_Cacu
            // 
            this.list_Cacu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnCChinese,
            this.columnCEnglish,
            this.columnCMath});
            this.list_Cacu.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.list_Cacu.HideSelection = false;
            this.list_Cacu.Location = new System.Drawing.Point(281, 318);
            this.list_Cacu.Name = "list_Cacu";
            this.list_Cacu.Size = new System.Drawing.Size(484, 118);
            this.list_Cacu.TabIndex = 43;
            this.list_Cacu.UseCompatibleStateImageBehavior = false;
            this.list_Cacu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // columnCChinese
            // 
            this.columnCChinese.Text = "國文";
            this.columnCChinese.Width = 50;
            // 
            // columnCEnglish
            // 
            this.columnCEnglish.Text = "英文";
            this.columnCEnglish.Width = 51;
            // 
            // columnCMath
            // 
            this.columnCMath.Text = "數學";
            this.columnCMath.Width = 50;
            // 
            // list_Data
            // 
            this.list_Data.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Name,
            this.column_Chinese,
            this.column_English,
            this.column_Math,
            this.column_Sum,
            this.column_Average,
            this.column_Bottom,
            this.column_Top});
            this.list_Data.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.list_Data.HideSelection = false;
            this.list_Data.Location = new System.Drawing.Point(281, 14);
            this.list_Data.Name = "list_Data";
            this.list_Data.Size = new System.Drawing.Size(484, 297);
            this.list_Data.TabIndex = 42;
            this.list_Data.UseCompatibleStateImageBehavior = false;
            this.list_Data.View = System.Windows.Forms.View.Details;
            // 
            // column_Name
            // 
            this.column_Name.Text = "姓名";
            // 
            // column_Chinese
            // 
            this.column_Chinese.Text = "國文";
            this.column_Chinese.Width = 50;
            // 
            // column_English
            // 
            this.column_English.Text = "英文";
            this.column_English.Width = 50;
            // 
            // column_Math
            // 
            this.column_Math.Text = "數學";
            this.column_Math.Width = 50;
            // 
            // column_Sum
            // 
            this.column_Sum.Text = "總分";
            this.column_Sum.Width = 50;
            // 
            // column_Average
            // 
            this.column_Average.Text = "平均";
            this.column_Average.Width = 70;
            // 
            // column_Bottom
            // 
            this.column_Bottom.Text = "最低";
            this.column_Bottom.Width = 70;
            // 
            // column_Top
            // 
            this.column_Top.Text = "最高";
            this.column_Top.Width = 70;
            // 
            // but_SEARCH
            // 
            this.but_SEARCH.Enabled = false;
            this.but_SEARCH.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_SEARCH.Location = new System.Drawing.Point(65, 441);
            this.but_SEARCH.Name = "but_SEARCH";
            this.but_SEARCH.Size = new System.Drawing.Size(148, 36);
            this.but_SEARCH.TabIndex = 41;
            this.but_SEARCH.Text = "SEAECH";
            this.but_SEARCH.UseVisualStyleBackColor = true;
            this.but_SEARCH.Click += new System.EventHandler(this.but_SEARCH_Click);
            // 
            // but_Clear
            // 
            this.but_Clear.Enabled = false;
            this.but_Clear.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Clear.Location = new System.Drawing.Point(65, 318);
            this.but_Clear.Name = "but_Clear";
            this.but_Clear.Size = new System.Drawing.Size(148, 36);
            this.but_Clear.TabIndex = 40;
            this.but_Clear.Text = "清除所有資料";
            this.but_Clear.UseVisualStyleBackColor = true;
            this.but_Clear.Click += new System.EventHandler(this.but_Clear_Click);
            // 
            // but_Caculate
            // 
            this.but_Caculate.Enabled = false;
            this.but_Caculate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Caculate.Location = new System.Drawing.Point(617, 445);
            this.but_Caculate.Name = "but_Caculate";
            this.but_Caculate.Size = new System.Drawing.Size(148, 36);
            this.but_Caculate.TabIndex = 39;
            this.but_Caculate.Text = "各科統計";
            this.but_Caculate.UseVisualStyleBackColor = true;
            this.but_Caculate.UseWaitCursor = true;
            this.but_Caculate.Click += new System.EventHandler(this.but_Caculate_Click);
            // 
            // but_Adddata
            // 
            this.but_Adddata.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Adddata.Location = new System.Drawing.Point(65, 192);
            this.but_Adddata.Name = "but_Adddata";
            this.but_Adddata.Size = new System.Drawing.Size(148, 36);
            this.but_Adddata.TabIndex = 37;
            this.but_Adddata.Text = "加入學生資料";
            this.but_Adddata.UseVisualStyleBackColor = true;
            this.but_Adddata.Click += new System.EventHandler(this.but_Adddata_Click);
            // 
            // lab_Math
            // 
            this.lab_Math.AutoSize = true;
            this.lab_Math.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Math.Location = new System.Drawing.Point(36, 140);
            this.lab_Math.Name = "lab_Math";
            this.lab_Math.Size = new System.Drawing.Size(75, 27);
            this.lab_Math.TabIndex = 36;
            this.lab_Math.Text = "數學：";
            // 
            // tex_Math
            // 
            this.tex_Math.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_Math.Location = new System.Drawing.Point(117, 137);
            this.tex_Math.Name = "tex_Math";
            this.tex_Math.Size = new System.Drawing.Size(126, 35);
            this.tex_Math.TabIndex = 35;
            // 
            // lab_English
            // 
            this.lab_English.AutoSize = true;
            this.lab_English.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_English.Location = new System.Drawing.Point(36, 99);
            this.lab_English.Name = "lab_English";
            this.lab_English.Size = new System.Drawing.Size(75, 27);
            this.lab_English.TabIndex = 34;
            this.lab_English.Text = "英文：";
            // 
            // tex_English
            // 
            this.tex_English.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_English.Location = new System.Drawing.Point(117, 96);
            this.tex_English.Name = "tex_English";
            this.tex_English.Size = new System.Drawing.Size(126, 35);
            this.tex_English.TabIndex = 33;
            // 
            // lab_Chinese
            // 
            this.lab_Chinese.AutoSize = true;
            this.lab_Chinese.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Chinese.Location = new System.Drawing.Point(36, 58);
            this.lab_Chinese.Name = "lab_Chinese";
            this.lab_Chinese.Size = new System.Drawing.Size(75, 27);
            this.lab_Chinese.TabIndex = 32;
            this.lab_Chinese.Text = "國文：";
            // 
            // tex_Chinese
            // 
            this.tex_Chinese.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_Chinese.Location = new System.Drawing.Point(117, 55);
            this.tex_Chinese.Name = "tex_Chinese";
            this.tex_Chinese.Size = new System.Drawing.Size(126, 35);
            this.tex_Chinese.TabIndex = 31;
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Name.Location = new System.Drawing.Point(36, 17);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(75, 27);
            this.lab_Name.TabIndex = 30;
            this.lab_Name.Text = "姓名：";
            // 
            // tex_Name
            // 
            this.tex_Name.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_Name.Location = new System.Drawing.Point(117, 14);
            this.tex_Name.Name = "tex_Name";
            this.tex_Name.Size = new System.Drawing.Size(126, 35);
            this.tex_Name.TabIndex = 29;
            // 
            // but_Insert
            // 
            this.but_Insert.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Insert.Location = new System.Drawing.Point(65, 234);
            this.but_Insert.Name = "but_Insert";
            this.but_Insert.Size = new System.Drawing.Size(148, 36);
            this.but_Insert.TabIndex = 44;
            this.but_Insert.Text = "插入學生資料";
            this.but_Insert.UseVisualStyleBackColor = true;
            this.but_Insert.Click += new System.EventHandler(this.but_Insert_Click);
            // 
            // but_RemoveAt
            // 
            this.but_RemoveAt.Enabled = false;
            this.but_RemoveAt.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_RemoveAt.Location = new System.Drawing.Point(65, 275);
            this.but_RemoveAt.Name = "but_RemoveAt";
            this.but_RemoveAt.Size = new System.Drawing.Size(148, 36);
            this.but_RemoveAt.TabIndex = 45;
            this.but_RemoveAt.Text = "移除資料";
            this.but_RemoveAt.UseVisualStyleBackColor = true;
            this.but_RemoveAt.Click += new System.EventHandler(this.but_RemoveAt_Click);
            // 
            // lab_Search
            // 
            this.lab_Search.AutoSize = true;
            this.lab_Search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Search.Location = new System.Drawing.Point(60, 372);
            this.lab_Search.Name = "lab_Search";
            this.lab_Search.Size = new System.Drawing.Size(153, 20);
            this.lab_Search.TabIndex = 46;
            this.lab_Search.Text = "搜尋國文成績範圍：";
            // 
            // tex_LowRange
            // 
            this.tex_LowRange.Enabled = false;
            this.tex_LowRange.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_LowRange.Location = new System.Drawing.Point(56, 401);
            this.tex_LowRange.Name = "tex_LowRange";
            this.tex_LowRange.Size = new System.Drawing.Size(72, 35);
            this.tex_LowRange.TabIndex = 47;
            // 
            // tex_HighRange
            // 
            this.tex_HighRange.Enabled = false;
            this.tex_HighRange.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_HighRange.Location = new System.Drawing.Point(156, 401);
            this.tex_HighRange.Name = "tex_HighRange";
            this.tex_HighRange.Size = new System.Drawing.Size(67, 35);
            this.tex_HighRange.TabIndex = 48;
            // 
            // label_DASH
            // 
            this.label_DASH.AutoSize = true;
            this.label_DASH.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_DASH.Location = new System.Drawing.Point(134, 409);
            this.label_DASH.Name = "label_DASH";
            this.label_DASH.Size = new System.Drawing.Size(16, 20);
            this.label_DASH.TabIndex = 49;
            this.label_DASH.Text = "-";
            // 
            // Homework6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 489);
            this.Controls.Add(this.label_DASH);
            this.Controls.Add(this.tex_HighRange);
            this.Controls.Add(this.tex_LowRange);
            this.Controls.Add(this.lab_Search);
            this.Controls.Add(this.but_RemoveAt);
            this.Controls.Add(this.but_Insert);
            this.Controls.Add(this.list_Cacu);
            this.Controls.Add(this.list_Data);
            this.Controls.Add(this.but_SEARCH);
            this.Controls.Add(this.but_Clear);
            this.Controls.Add(this.but_Caculate);
            this.Controls.Add(this.but_Adddata);
            this.Controls.Add(this.lab_Math);
            this.Controls.Add(this.tex_Math);
            this.Controls.Add(this.lab_English);
            this.Controls.Add(this.tex_English);
            this.Controls.Add(this.lab_Chinese);
            this.Controls.Add(this.tex_Chinese);
            this.Controls.Add(this.lab_Name);
            this.Controls.Add(this.tex_Name);
            this.Name = "Homework6";
            this.Text = "Homework7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_Cacu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnCChinese;
        private System.Windows.Forms.ColumnHeader columnCEnglish;
        private System.Windows.Forms.ColumnHeader columnCMath;
        private System.Windows.Forms.ListView list_Data;
        private System.Windows.Forms.ColumnHeader column_Name;
        private System.Windows.Forms.ColumnHeader column_Chinese;
        private System.Windows.Forms.ColumnHeader column_English;
        private System.Windows.Forms.ColumnHeader column_Math;
        private System.Windows.Forms.ColumnHeader column_Sum;
        private System.Windows.Forms.ColumnHeader column_Average;
        private System.Windows.Forms.ColumnHeader column_Bottom;
        private System.Windows.Forms.ColumnHeader column_Top;
        private System.Windows.Forms.Button but_SEARCH;
        private System.Windows.Forms.Button but_Clear;
        private System.Windows.Forms.Button but_Caculate;
        private System.Windows.Forms.Button but_Adddata;
        private System.Windows.Forms.Label lab_Math;
        private System.Windows.Forms.TextBox tex_Math;
        private System.Windows.Forms.Label lab_English;
        private System.Windows.Forms.TextBox tex_English;
        private System.Windows.Forms.Label lab_Chinese;
        private System.Windows.Forms.TextBox tex_Chinese;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.TextBox tex_Name;
        private System.Windows.Forms.Button but_Insert;
        private System.Windows.Forms.Button but_RemoveAt;
        private System.Windows.Forms.Label lab_Search;
        private System.Windows.Forms.TextBox tex_LowRange;
        private System.Windows.Forms.TextBox tex_HighRange;
        private System.Windows.Forms.Label label_DASH;
    }
}
﻿namespace Homework
{
    partial class Homework5
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
            this.lab_Math = new System.Windows.Forms.Label();
            this.tex_Math = new System.Windows.Forms.TextBox();
            this.lab_English = new System.Windows.Forms.Label();
            this.tex_English = new System.Windows.Forms.TextBox();
            this.lab_Chinese = new System.Windows.Forms.Label();
            this.tex_Chinese = new System.Windows.Forms.TextBox();
            this.lab_Name = new System.Windows.Forms.Label();
            this.tex_Name = new System.Windows.Forms.TextBox();
            this.but_Adddata = new System.Windows.Forms.Button();
            this.but_Random = new System.Windows.Forms.Button();
            this.but_Caculate = new System.Windows.Forms.Button();
            this.but_Reset = new System.Windows.Forms.Button();
            this.but_20Random = new System.Windows.Forms.Button();
            this.list_Data = new System.Windows.Forms.ListView();
            this.column_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Chinese = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_English = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Math = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Average = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Bottom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Top = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_Cacu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCChinese = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCEnglish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCMath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lab_Math
            // 
            this.lab_Math.AutoSize = true;
            this.lab_Math.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Math.Location = new System.Drawing.Point(22, 138);
            this.lab_Math.Name = "lab_Math";
            this.lab_Math.Size = new System.Drawing.Size(75, 27);
            this.lab_Math.TabIndex = 16;
            this.lab_Math.Text = "數學：";
            // 
            // tex_Math
            // 
            this.tex_Math.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_Math.Location = new System.Drawing.Point(103, 135);
            this.tex_Math.Name = "tex_Math";
            this.tex_Math.Size = new System.Drawing.Size(126, 35);
            this.tex_Math.TabIndex = 15;
            // 
            // lab_English
            // 
            this.lab_English.AutoSize = true;
            this.lab_English.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_English.Location = new System.Drawing.Point(22, 97);
            this.lab_English.Name = "lab_English";
            this.lab_English.Size = new System.Drawing.Size(75, 27);
            this.lab_English.TabIndex = 14;
            this.lab_English.Text = "英文：";
            // 
            // tex_English
            // 
            this.tex_English.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_English.Location = new System.Drawing.Point(103, 94);
            this.tex_English.Name = "tex_English";
            this.tex_English.Size = new System.Drawing.Size(126, 35);
            this.tex_English.TabIndex = 13;
            // 
            // lab_Chinese
            // 
            this.lab_Chinese.AutoSize = true;
            this.lab_Chinese.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Chinese.Location = new System.Drawing.Point(22, 56);
            this.lab_Chinese.Name = "lab_Chinese";
            this.lab_Chinese.Size = new System.Drawing.Size(75, 27);
            this.lab_Chinese.TabIndex = 12;
            this.lab_Chinese.Text = "國文：";
            // 
            // tex_Chinese
            // 
            this.tex_Chinese.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_Chinese.Location = new System.Drawing.Point(103, 53);
            this.tex_Chinese.Name = "tex_Chinese";
            this.tex_Chinese.Size = new System.Drawing.Size(126, 35);
            this.tex_Chinese.TabIndex = 11;
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Name.Location = new System.Drawing.Point(22, 15);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(75, 27);
            this.lab_Name.TabIndex = 10;
            this.lab_Name.Text = "姓名：";
            // 
            // tex_Name
            // 
            this.tex_Name.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_Name.Location = new System.Drawing.Point(103, 12);
            this.tex_Name.Name = "tex_Name";
            this.tex_Name.Size = new System.Drawing.Size(126, 35);
            this.tex_Name.TabIndex = 9;
            // 
            // but_Adddata
            // 
            this.but_Adddata.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Adddata.Location = new System.Drawing.Point(51, 190);
            this.but_Adddata.Name = "but_Adddata";
            this.but_Adddata.Size = new System.Drawing.Size(148, 36);
            this.but_Adddata.TabIndex = 17;
            this.but_Adddata.Text = "加入學生資料";
            this.but_Adddata.UseVisualStyleBackColor = true;
            this.but_Adddata.Click += new System.EventHandler(this.but_Adddata_Click);
            // 
            // but_Random
            // 
            this.but_Random.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Random.Location = new System.Drawing.Point(51, 232);
            this.but_Random.Name = "but_Random";
            this.but_Random.Size = new System.Drawing.Size(148, 36);
            this.but_Random.TabIndex = 18;
            this.but_Random.Text = "隨機儲存資料";
            this.but_Random.UseVisualStyleBackColor = true;
            this.but_Random.Click += new System.EventHandler(this.but_Random_Click);
            // 
            // but_Caculate
            // 
            this.but_Caculate.Enabled = false;
            this.but_Caculate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Caculate.Location = new System.Drawing.Point(51, 274);
            this.but_Caculate.Name = "but_Caculate";
            this.but_Caculate.Size = new System.Drawing.Size(148, 36);
            this.but_Caculate.TabIndex = 19;
            this.but_Caculate.Text = "各科統計";
            this.but_Caculate.UseVisualStyleBackColor = true;
            this.but_Caculate.UseWaitCursor = true;
            this.but_Caculate.Click += new System.EventHandler(this.but_Caculate_Click);
            // 
            // but_Reset
            // 
            this.but_Reset.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Reset.Location = new System.Drawing.Point(51, 356);
            this.but_Reset.Name = "but_Reset";
            this.but_Reset.Size = new System.Drawing.Size(148, 36);
            this.but_Reset.TabIndex = 20;
            this.but_Reset.Text = "重設所有資料";
            this.but_Reset.UseVisualStyleBackColor = true;
            this.but_Reset.Click += new System.EventHandler(this.but_Reset_Click);
            // 
            // but_20Random
            // 
            this.but_20Random.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_20Random.Location = new System.Drawing.Point(51, 398);
            this.but_20Random.Name = "but_20Random";
            this.but_20Random.Size = new System.Drawing.Size(148, 36);
            this.but_20Random.TabIndex = 21;
            this.but_20Random.Text = "隨機加入20筆";
            this.but_20Random.UseVisualStyleBackColor = true;
            this.but_20Random.Click += new System.EventHandler(this.but_20Random_Click);
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
            this.list_Data.Location = new System.Drawing.Point(267, 12);
            this.list_Data.Name = "list_Data";
            this.list_Data.Size = new System.Drawing.Size(484, 297);
            this.list_Data.TabIndex = 27;
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
            // list_Cacu
            // 
            this.list_Cacu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnCChinese,
            this.columnCEnglish,
            this.columnCMath});
            this.list_Cacu.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.list_Cacu.HideSelection = false;
            this.list_Cacu.Location = new System.Drawing.Point(267, 316);
            this.list_Cacu.Name = "list_Cacu";
            this.list_Cacu.Size = new System.Drawing.Size(484, 118);
            this.list_Cacu.TabIndex = 28;
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
            // Homework5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 465);
            this.Controls.Add(this.list_Cacu);
            this.Controls.Add(this.list_Data);
            this.Controls.Add(this.but_20Random);
            this.Controls.Add(this.but_Reset);
            this.Controls.Add(this.but_Caculate);
            this.Controls.Add(this.but_Random);
            this.Controls.Add(this.but_Adddata);
            this.Controls.Add(this.lab_Math);
            this.Controls.Add(this.tex_Math);
            this.Controls.Add(this.lab_English);
            this.Controls.Add(this.tex_English);
            this.Controls.Add(this.lab_Chinese);
            this.Controls.Add(this.tex_Chinese);
            this.Controls.Add(this.lab_Name);
            this.Controls.Add(this.tex_Name);
            this.Name = "Homework5";
            this.Text = "Homework5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Math;
        private System.Windows.Forms.TextBox tex_Math;
        private System.Windows.Forms.Label lab_English;
        private System.Windows.Forms.TextBox tex_English;
        private System.Windows.Forms.Label lab_Chinese;
        private System.Windows.Forms.TextBox tex_Chinese;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.TextBox tex_Name;
        private System.Windows.Forms.Button but_Adddata;
        private System.Windows.Forms.Button but_Random;
        private System.Windows.Forms.Button but_Reset;
        private System.Windows.Forms.Button but_20Random;
        private System.Windows.Forms.ListView list_Data;
        private System.Windows.Forms.ColumnHeader column_Name;
        private System.Windows.Forms.ColumnHeader column_Chinese;
        private System.Windows.Forms.ColumnHeader column_English;
        private System.Windows.Forms.ColumnHeader column_Math;
        private System.Windows.Forms.ColumnHeader column_Sum;
        private System.Windows.Forms.ColumnHeader column_Average;
        private System.Windows.Forms.ColumnHeader column_Bottom;
        private System.Windows.Forms.ColumnHeader column_Top;
        private System.Windows.Forms.ListView list_Cacu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnCChinese;
        private System.Windows.Forms.ColumnHeader columnCEnglish;
        private System.Windows.Forms.ColumnHeader columnCMath;
        private System.Windows.Forms.Button but_Caculate;
    }
}
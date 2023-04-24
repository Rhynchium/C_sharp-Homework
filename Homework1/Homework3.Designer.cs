namespace Homework
{
    partial class Homework3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homework3));
            this.butBear = new System.Windows.Forms.Button();
            this.butTequila = new System.Windows.Forms.Button();
            this.butWhisky = new System.Windows.Forms.Button();
            this.butWine = new System.Windows.Forms.Button();
            this.but_cleanlist = new System.Windows.Forms.Button();
            this.tex_Totalprice = new System.Windows.Forms.TextBox();
            this.tex_Shoplist = new System.Windows.Forms.TextBox();
            this.Menubackground = new System.Windows.Forms.TextBox();
            this.but_bycash = new System.Windows.Forms.Button();
            this.but_bycard = new System.Windows.Forms.Button();
            this.Totalpricebackground = new System.Windows.Forms.TextBox();
            this.Howtopaybackground = new System.Windows.Forms.TextBox();
            this.discount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butBear
            // 
            this.butBear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butBear.BackgroundImage")));
            this.butBear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butBear.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butBear.Location = new System.Drawing.Point(37, 69);
            this.butBear.Name = "butBear";
            this.butBear.Size = new System.Drawing.Size(95, 127);
            this.butBear.TabIndex = 0;
            this.butBear.Text = "啤酒Beer NT$120";
            this.butBear.UseVisualStyleBackColor = true;
            this.butBear.Click += new System.EventHandler(this.butBear_Click);
            // 
            // butTequila
            // 
            this.butTequila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butTequila.BackgroundImage")));
            this.butTequila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butTequila.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butTequila.ForeColor = System.Drawing.Color.Black;
            this.butTequila.Location = new System.Drawing.Point(158, 69);
            this.butTequila.Name = "butTequila";
            this.butTequila.Size = new System.Drawing.Size(95, 127);
            this.butTequila.TabIndex = 1;
            this.butTequila.Text = "龍舌蘭Tequila NT$180";
            this.butTequila.UseVisualStyleBackColor = true;
            this.butTequila.Click += new System.EventHandler(this.butTequila_Click);
            // 
            // butWhisky
            // 
            this.butWhisky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butWhisky.BackgroundImage")));
            this.butWhisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butWhisky.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butWhisky.Location = new System.Drawing.Point(37, 236);
            this.butWhisky.Name = "butWhisky";
            this.butWhisky.Size = new System.Drawing.Size(95, 127);
            this.butWhisky.TabIndex = 3;
            this.butWhisky.Text = "威士忌Whisky NT$350";
            this.butWhisky.UseVisualStyleBackColor = true;
            this.butWhisky.Click += new System.EventHandler(this.butWhisky_Click);
            // 
            // butWine
            // 
            this.butWine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butWine.BackgroundImage")));
            this.butWine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butWine.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butWine.Location = new System.Drawing.Point(158, 236);
            this.butWine.Name = "butWine";
            this.butWine.Size = new System.Drawing.Size(95, 127);
            this.butWine.TabIndex = 4;
            this.butWine.Text = "紅酒Wine NT$320";
            this.butWine.UseVisualStyleBackColor = true;
            this.butWine.Click += new System.EventHandler(this.butWine_Click);
            // 
            // but_cleanlist
            // 
            this.but_cleanlist.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_cleanlist.Location = new System.Drawing.Point(652, 330);
            this.but_cleanlist.Name = "but_cleanlist";
            this.but_cleanlist.Size = new System.Drawing.Size(133, 43);
            this.but_cleanlist.TabIndex = 7;
            this.but_cleanlist.Text = "清除清單";
            this.but_cleanlist.UseVisualStyleBackColor = true;
            this.but_cleanlist.Click += new System.EventHandler(this.but_cleanlist_Click);
            // 
            // tex_Totalprice
            // 
            this.tex_Totalprice.AcceptsReturn = true;
            this.tex_Totalprice.AcceptsTab = true;
            this.tex_Totalprice.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tex_Totalprice.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_Totalprice.ForeColor = System.Drawing.SystemColors.Info;
            this.tex_Totalprice.Location = new System.Drawing.Point(297, 90);
            this.tex_Totalprice.Name = "tex_Totalprice";
            this.tex_Totalprice.ReadOnly = true;
            this.tex_Totalprice.Size = new System.Drawing.Size(218, 39);
            this.tex_Totalprice.TabIndex = 8;
            this.tex_Totalprice.Text = "0 NT$";
            this.tex_Totalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tex_Totalprice.TextChanged += new System.EventHandler(this.tex_Totalprice_TextChanged);
            // 
            // tex_Shoplist
            // 
            this.tex_Shoplist.AcceptsReturn = true;
            this.tex_Shoplist.AcceptsTab = true;
            this.tex_Shoplist.BackColor = System.Drawing.Color.White;
            this.tex_Shoplist.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_Shoplist.Location = new System.Drawing.Point(536, 70);
            this.tex_Shoplist.Multiline = true;
            this.tex_Shoplist.Name = "tex_Shoplist";
            this.tex_Shoplist.ReadOnly = true;
            this.tex_Shoplist.Size = new System.Drawing.Size(249, 250);
            this.tex_Shoplist.TabIndex = 8;
            this.tex_Shoplist.Text = "尚未點餐";
            this.tex_Shoplist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tex_Shoplist.TextChanged += new System.EventHandler(this.tex_Shoplist_TextChanged);
            // 
            // Menubackground
            // 
            this.Menubackground.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Menubackground.Location = new System.Drawing.Point(12, 34);
            this.Menubackground.Multiline = true;
            this.Menubackground.Name = "Menubackground";
            this.Menubackground.ReadOnly = true;
            this.Menubackground.Size = new System.Drawing.Size(264, 344);
            this.Menubackground.TabIndex = 9;
            this.Menubackground.Text = "菜單 (Menu)";
            // 
            // but_bycash
            // 
            this.but_bycash.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_bycash.Location = new System.Drawing.Point(297, 236);
            this.but_bycash.Name = "but_bycash";
            this.but_bycash.Size = new System.Drawing.Size(95, 53);
            this.but_bycash.TabIndex = 5;
            this.but_bycash.Text = "現金";
            this.but_bycash.UseVisualStyleBackColor = true;
            this.but_bycash.Click += new System.EventHandler(this.but_bycash_Click);
            // 
            // but_bycard
            // 
            this.but_bycard.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_bycard.Location = new System.Drawing.Point(420, 236);
            this.but_bycard.Name = "but_bycard";
            this.but_bycard.Size = new System.Drawing.Size(95, 53);
            this.but_bycard.TabIndex = 4;
            this.but_bycard.Text = "信用卡";
            this.but_bycard.UseVisualStyleBackColor = true;
            this.but_bycard.Click += new System.EventHandler(this.but_bycard_Click);
            // 
            // Totalpricebackground
            // 
            this.Totalpricebackground.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Totalpricebackground.Location = new System.Drawing.Point(291, 34);
            this.Totalpricebackground.Multiline = true;
            this.Totalpricebackground.Name = "Totalpricebackground";
            this.Totalpricebackground.ReadOnly = true;
            this.Totalpricebackground.Size = new System.Drawing.Size(230, 111);
            this.Totalpricebackground.TabIndex = 9;
            this.Totalpricebackground.Text = "總金額 (Total Price)";
            // 
            // Howtopaybackground
            // 
            this.Howtopaybackground.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Howtopaybackground.Location = new System.Drawing.Point(291, 188);
            this.Howtopaybackground.Multiline = true;
            this.Howtopaybackground.Name = "Howtopaybackground";
            this.Howtopaybackground.ReadOnly = true;
            this.Howtopaybackground.Size = new System.Drawing.Size(230, 142);
            this.Howtopaybackground.TabIndex = 12;
            this.Howtopaybackground.Text = "付款方式";
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.BackColor = System.Drawing.Color.Moccasin;
            this.discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discount.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.discount.Location = new System.Drawing.Point(363, 299);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(155, 21);
            this.discount.TabIndex = 13;
            this.discount.Text = "信用卡可享9折優惠！";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(527, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(264, 345);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "購買清單 (List)";
            // 
            // Homework3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 390);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.but_cleanlist);
            this.Controls.Add(this.tex_Shoplist);
            this.Controls.Add(this.but_bycard);
            this.Controls.Add(this.but_bycash);
            this.Controls.Add(this.tex_Totalprice);
            this.Controls.Add(this.Howtopaybackground);
            this.Controls.Add(this.butTequila);
            this.Controls.Add(this.butBear);
            this.Controls.Add(this.butWine);
            this.Controls.Add(this.butWhisky);
            this.Controls.Add(this.Menubackground);
            this.Controls.Add(this.Totalpricebackground);
            this.Controls.Add(this.textBox1);
            this.Name = "Homework3";
            this.Text = "Homework3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butBear;
        private System.Windows.Forms.Button butTequila;
        private System.Windows.Forms.Button butWhisky;
        private System.Windows.Forms.Button but_cleanlist;
        private System.Windows.Forms.TextBox tex_Totalprice;
        private System.Windows.Forms.Button butWine;
        private System.Windows.Forms.TextBox tex_Shoplist;
        private System.Windows.Forms.Button but_bycash;
        private System.Windows.Forms.Button but_bycard;
        private System.Windows.Forms.TextBox Menubackground;
        private System.Windows.Forms.TextBox Totalpricebackground;
        private System.Windows.Forms.TextBox Howtopaybackground;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.TextBox textBox1;
    }
}
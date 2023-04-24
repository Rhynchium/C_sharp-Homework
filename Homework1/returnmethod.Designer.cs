namespace Homework1
{
    partial class returnmethod
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tex_Age = new System.Windows.Forms.TextBox();
            this.forutility = new System.Windows.Forms.Button();
            this.cap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(453, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Return Method";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.find_bitrhyear);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(362, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // tex_Age
            // 
            this.tex_Age.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_Age.Location = new System.Drawing.Point(481, 33);
            this.tex_Age.Name = "tex_Age";
            this.tex_Age.Size = new System.Drawing.Size(186, 39);
            this.tex_Age.TabIndex = 2;
            // 
            // forutility
            // 
            this.forutility.Location = new System.Drawing.Point(453, 187);
            this.forutility.Name = "forutility";
            this.forutility.Size = new System.Drawing.Size(197, 35);
            this.forutility.TabIndex = 3;
            this.forutility.Text = "To MyClass";
            this.forutility.UseVisualStyleBackColor = true;
            this.forutility.Click += new System.EventHandler(this.MyClass);
            // 
            // cap
            // 
            this.cap.Location = new System.Drawing.Point(453, 247);
            this.cap.Name = "cap";
            this.cap.Size = new System.Drawing.Size(122, 35);
            this.cap.TabIndex = 4;
            this.cap.Text = "Capsule";
            this.cap.UseVisualStyleBackColor = true;
            this.cap.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "PARTIALClaSS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Partialclass);
            // 
            // returnmethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cap);
            this.Controls.Add(this.forutility);
            this.Controls.Add(this.tex_Age);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "returnmethod";
            this.Text = "returnmethod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tex_Age;
        private System.Windows.Forms.Button forutility;
        private System.Windows.Forms.Button cap;
        private System.Windows.Forms.Button button2;
    }
}
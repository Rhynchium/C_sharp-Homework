namespace Homework1
{
    partial class Homework_Final_Guess_type
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
            this.but_Enter = new System.Windows.Forms.Button();
            this.lab_TypeTitle = new System.Windows.Forms.Label();
            this.but_Cancel = new System.Windows.Forms.Button();
            this.tex_GuessNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // but_Enter
            // 
            this.but_Enter.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Enter.Location = new System.Drawing.Point(384, 36);
            this.but_Enter.Name = "but_Enter";
            this.but_Enter.Size = new System.Drawing.Size(100, 39);
            this.but_Enter.TabIndex = 4;
            this.but_Enter.Text = "Enter";
            this.but_Enter.UseVisualStyleBackColor = true;
            this.but_Enter.Click += new System.EventHandler(this.but_Enter_Click);
            // 
            // lab_TypeTitle
            // 
            this.lab_TypeTitle.AutoSize = true;
            this.lab_TypeTitle.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_TypeTitle.Location = new System.Drawing.Point(51, 35);
            this.lab_TypeTitle.Name = "lab_TypeTitle";
            this.lab_TypeTitle.Size = new System.Drawing.Size(317, 35);
            this.lab_TypeTitle.TabIndex = 3;
            this.lab_TypeTitle.Text = "Please input a number!";
            // 
            // but_Cancel
            // 
            this.but_Cancel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Cancel.Location = new System.Drawing.Point(384, 94);
            this.but_Cancel.Name = "but_Cancel";
            this.but_Cancel.Size = new System.Drawing.Size(100, 39);
            this.but_Cancel.TabIndex = 5;
            this.but_Cancel.Text = "Cancel";
            this.but_Cancel.UseVisualStyleBackColor = true;
            this.but_Cancel.Click += new System.EventHandler(this.but_Cancel_Click);
            // 
            // tex_GuessNumber
            // 
            this.tex_GuessNumber.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex_GuessNumber.Location = new System.Drawing.Point(48, 94);
            this.tex_GuessNumber.Name = "tex_GuessNumber";
            this.tex_GuessNumber.Size = new System.Drawing.Size(311, 33);
            this.tex_GuessNumber.TabIndex = 6;
            // 
            // Homework_Final_Guess_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 180);
            this.Controls.Add(this.tex_GuessNumber);
            this.Controls.Add(this.but_Cancel);
            this.Controls.Add(this.but_Enter);
            this.Controls.Add(this.lab_TypeTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Homework_Final_Guess_type";
            this.Text = "Homework_Final_Guess_type";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button but_Enter;
        private System.Windows.Forms.Label lab_TypeTitle;
        private System.Windows.Forms.Button but_Cancel;
        private System.Windows.Forms.TextBox tex_GuessNumber;
    }
}
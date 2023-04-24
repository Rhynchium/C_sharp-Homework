namespace Homework1
{
    partial class Homework_Final_Guess
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
            this.lab_Information = new System.Windows.Forms.Label();
            this.but_Guess = new System.Windows.Forms.Button();
            this.but_ShowAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_Information
            // 
            this.lab_Information.AutoSize = true;
            this.lab_Information.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Information.Location = new System.Drawing.Point(34, 29);
            this.lab_Information.Name = "lab_Information";
            this.lab_Information.Size = new System.Drawing.Size(438, 31);
            this.lab_Information.TabIndex = 0;
            this.lab_Information.Text = "Select a number between 1 and 100!";
            // 
            // but_Guess
            // 
            this.but_Guess.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Guess.Location = new System.Drawing.Point(118, 131);
            this.but_Guess.Name = "but_Guess";
            this.but_Guess.Size = new System.Drawing.Size(100, 39);
            this.but_Guess.TabIndex = 1;
            this.but_Guess.Text = "Guess!";
            this.but_Guess.UseVisualStyleBackColor = true;
            this.but_Guess.Click += new System.EventHandler(this.but_Guess_Click);
            // 
            // but_ShowAnswer
            // 
            this.but_ShowAnswer.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_ShowAnswer.Location = new System.Drawing.Point(296, 131);
            this.but_ShowAnswer.Name = "but_ShowAnswer";
            this.but_ShowAnswer.Size = new System.Drawing.Size(158, 39);
            this.but_ShowAnswer.TabIndex = 2;
            this.but_ShowAnswer.Text = "Show Answer";
            this.but_ShowAnswer.UseVisualStyleBackColor = true;
            this.but_ShowAnswer.Click += new System.EventHandler(this.but_ShowAnswer_Click);
            // 
            // Homework_Final_Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 197);
            this.Controls.Add(this.but_ShowAnswer);
            this.Controls.Add(this.but_Guess);
            this.Controls.Add(this.lab_Information);
            this.Name = "Homework_Final_Guess";
            this.Text = "Homework_Final_Guess";
            this.Load += new System.EventHandler(this.Homework_Final_Guess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Information;
        private System.Windows.Forms.Button but_Guess;
        private System.Windows.Forms.Button but_ShowAnswer;
    }
}
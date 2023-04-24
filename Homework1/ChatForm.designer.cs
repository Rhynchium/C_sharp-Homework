namespace Lab_Form
{
    partial class ChatForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.Starter = new System.Windows.Forms.Button();
            this.textform = new System.Windows.Forms.TextBox();
            this.labform = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Starter
            // 
            this.Starter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Starter.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Starter.Location = new System.Drawing.Point(574, 114);
            this.Starter.Name = "Starter";
            this.Starter.Size = new System.Drawing.Size(219, 72);
            this.Starter.TabIndex = 0;
            this.Starter.Text = "Start Chatting";
            this.Starter.UseVisualStyleBackColor = false;
            this.Starter.Click += new System.EventHandler(this.labform_Click);
            // 
            // textform
            // 
            this.textform.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textform.Location = new System.Drawing.Point(574, 59);
            this.textform.Name = "textform";
            this.textform.Size = new System.Drawing.Size(219, 39);
            this.textform.TabIndex = 1;
            // 
            // labform
            // 
            this.labform.AutoSize = true;
            this.labform.BackColor = System.Drawing.Color.Transparent;
            this.labform.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labform.Location = new System.Drawing.Point(177, 59);
            this.labform.Name = "labform";
            this.labform.Size = new System.Drawing.Size(391, 34);
            this.labform.TabIndex = 2;
            this.labform.Text = "Please write down your name:";
            this.labform.Click += new System.EventHandler(this.labform_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(933, 600);
            this.Controls.Add(this.labform);
            this.Controls.Add(this.textform);
            this.Controls.Add(this.Starter);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChatForm";
            this.Text = "Chat with It";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Starter;
        private System.Windows.Forms.TextBox textform;
        private System.Windows.Forms.Label labform;
    }
}


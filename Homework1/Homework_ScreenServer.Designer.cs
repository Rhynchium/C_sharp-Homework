namespace Homework
{
    partial class Homework_ScreenServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homework_ScreenServer));
            this.picture_Lemon = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Lemon)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_Lemon
            // 
            this.picture_Lemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_Lemon.Image = ((System.Drawing.Image)(resources.GetObject("picture_Lemon.Image")));
            this.picture_Lemon.Location = new System.Drawing.Point(12, 12);
            this.picture_Lemon.Name = "picture_Lemon";
            this.picture_Lemon.Size = new System.Drawing.Size(345, 300);
            this.picture_Lemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Lemon.TabIndex = 0;
            this.picture_Lemon.TabStop = false;
            this.picture_Lemon.Click += new System.EventHandler(this.picture_Lemon_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Homework_ScreenServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1259, 530);
            this.Controls.Add(this.picture_Lemon);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Homework_ScreenServer";
            this.ShowInTaskbar = false;
            this.Text = "Homework_ScreenServer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.Homework_ScreenServer_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Homework_ScreenServer_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Homework_ScreenServer_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Lemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_Lemon;
        private System.Windows.Forms.Timer timer;
    }
}
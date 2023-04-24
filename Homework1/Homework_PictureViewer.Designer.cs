namespace Homework1
{
    partial class Homework_PictureViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homework_PictureViewer));
            this.PictureList = new System.Windows.Forms.ImageList(this.components);
            this.PictureViewerPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PictureList
            // 
            this.PictureList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PictureList.ImageStream")));
            this.PictureList.TransparentColor = System.Drawing.Color.Transparent;
            this.PictureList.Images.SetKeyName(0, "Rhynchium brunneum.jpg");
            this.PictureList.Images.SetKeyName(1, "img_61968565eec3c.jpeg");
            this.PictureList.Images.SetKeyName(2, "9.jpg");
            this.PictureList.Images.SetKeyName(3, "Astray Red.jpg");
            this.PictureList.Images.SetKeyName(4, "jojos-noriaki-kakyoin.gif");
            this.PictureList.Images.SetKeyName(5, "PH.jpg");
            this.PictureList.Images.SetKeyName(6, "167df5_831e73b5e01c4200a7a70ad0952e8c24~mv2.jpg");
            this.PictureList.Images.SetKeyName(7, "UAmOUos.jpeg");
            this.PictureList.Images.SetKeyName(8, "RISESB.jpg");
            this.PictureList.Images.SetKeyName(9, "wallace-collection-insect-specimens-natural-history-museum-londonscience-photo-li" +
        "brary.jpg");
            // 
            // PictureViewerPanel
            // 
            this.PictureViewerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureViewerPanel.Location = new System.Drawing.Point(0, 0);
            this.PictureViewerPanel.Name = "PictureViewerPanel";
            this.PictureViewerPanel.Size = new System.Drawing.Size(800, 450);
            this.PictureViewerPanel.TabIndex = 0;
            this.PictureViewerPanel.Resize += new System.EventHandler(this.PictureViewerPanel_Resize);
            // 
            // Homework_PictureViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PictureViewerPanel);
            this.Name = "Homework_PictureViewer";
            this.Text = "Homework_PictureViewer";
            this.Load += new System.EventHandler(this.Homework_PictureViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList PictureList;
        private System.Windows.Forms.Panel PictureViewerPanel;
    }
}
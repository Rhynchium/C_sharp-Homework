namespace Homework1
{
    partial class Homework_Painter
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
            this.but_Color = new System.Windows.Forms.Button();
            this.pB_ShowColor = new System.Windows.Forms.PictureBox();
            this.trackBar_Brush = new System.Windows.Forms.TrackBar();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.PaintArea = new System.Windows.Forms.PictureBox();
            this.lab_BrushSize = new System.Windows.Forms.Label();
            this.but_ClearAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pB_ShowColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Brush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaintArea)).BeginInit();
            this.SuspendLayout();
            // 
            // but_Color
            // 
            this.but_Color.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Color.Location = new System.Drawing.Point(679, 12);
            this.but_Color.Name = "but_Color";
            this.but_Color.Size = new System.Drawing.Size(102, 38);
            this.but_Color.TabIndex = 0;
            this.but_Color.Text = "顏色";
            this.but_Color.UseVisualStyleBackColor = true;
            this.but_Color.Click += new System.EventHandler(this.but_Color_Click);
            // 
            // pB_ShowColor
            // 
            this.pB_ShowColor.BackColor = System.Drawing.Color.Black;
            this.pB_ShowColor.Location = new System.Drawing.Point(681, 68);
            this.pB_ShowColor.Name = "pB_ShowColor";
            this.pB_ShowColor.Size = new System.Drawing.Size(100, 50);
            this.pB_ShowColor.TabIndex = 1;
            this.pB_ShowColor.TabStop = false;
            // 
            // trackBar_Brush
            // 
            this.trackBar_Brush.Location = new System.Drawing.Point(710, 136);
            this.trackBar_Brush.Maximum = 100;
            this.trackBar_Brush.Minimum = 1;
            this.trackBar_Brush.Name = "trackBar_Brush";
            this.trackBar_Brush.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Brush.Size = new System.Drawing.Size(45, 148);
            this.trackBar_Brush.TabIndex = 2;
            this.trackBar_Brush.Value = 1;
            this.trackBar_Brush.Scroll += new System.EventHandler(this.trackBar_Brush_Scroll);
            // 
            // PaintArea
            // 
            this.PaintArea.Location = new System.Drawing.Point(0, 0);
            this.PaintArea.Name = "PaintArea";
            this.PaintArea.Size = new System.Drawing.Size(671, 446);
            this.PaintArea.TabIndex = 3;
            this.PaintArea.TabStop = false;
            this.PaintArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintArea_MouseDown);
            this.PaintArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintArea_MouseMove);
            // 
            // lab_BrushSize
            // 
            this.lab_BrushSize.AutoSize = true;
            this.lab_BrushSize.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_BrushSize.Location = new System.Drawing.Point(698, 306);
            this.lab_BrushSize.Name = "lab_BrushSize";
            this.lab_BrushSize.Size = new System.Drawing.Size(64, 24);
            this.lab_BrushSize.TabIndex = 4;
            this.lab_BrushSize.Text = "label1";
            // 
            // but_ClearAll
            // 
            this.but_ClearAll.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_ClearAll.Location = new System.Drawing.Point(681, 362);
            this.but_ClearAll.Name = "but_ClearAll";
            this.but_ClearAll.Size = new System.Drawing.Size(102, 38);
            this.but_ClearAll.TabIndex = 5;
            this.but_ClearAll.Text = "一鍵清空";
            this.but_ClearAll.UseVisualStyleBackColor = true;
            this.but_ClearAll.Click += new System.EventHandler(this.but_ClearAll_Click);
            // 
            // Homework_Painter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 464);
            this.Controls.Add(this.but_ClearAll);
            this.Controls.Add(this.lab_BrushSize);
            this.Controls.Add(this.PaintArea);
            this.Controls.Add(this.trackBar_Brush);
            this.Controls.Add(this.pB_ShowColor);
            this.Controls.Add(this.but_Color);
            this.Name = "Homework_Painter";
            this.Text = "Homework_Painter";
            this.Load += new System.EventHandler(this.Homework_Painter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB_ShowColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Brush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaintArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Color;
        private System.Windows.Forms.PictureBox pB_ShowColor;
        private System.Windows.Forms.TrackBar trackBar_Brush;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.PictureBox PaintArea;
        private System.Windows.Forms.Label lab_BrushSize;
        private System.Windows.Forms.Button but_ClearAll;
    }
}
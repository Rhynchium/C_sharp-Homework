using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Homework_Painter : Form
    {
        public Homework_Painter()
        {
            InitializeComponent();
        }
        private void Homework_Painter_Load(object sender, EventArgs e)
        {
            PaintArea.Image = new Bitmap(800, 600);     //開啟時建立新畫布
            Graphics g = Graphics.FromImage(PaintArea.Image);   //定義畫布(PaintArea.Image)上的繪圖物件g
            g.Clear(Color.White);
        }
        private void but_ClearAll_Click(object sender, EventArgs e)
        {
            Homework_Painter_Load(sender, e);
        }
        private void but_Color_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            pB_ShowColor.BackColor = colorDialog.Color;
            //筆刷.Color = colorDialog.Color;
        }
        private void trackBar_Brush_Scroll(object sender, EventArgs e)
        {
            lab_BrushSize.Text = trackBar_Brush.Value.ToString();
        }
        int x0, y0;
        private void PaintArea_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X; y0 = e.Y;     //定義游標位置 = 畫圖起點座標
        }
        private void PaintArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  //按下滑鼠左鍵時
            {
                Graphics g = Graphics.FromImage(PaintArea.Image);   //定義畫布(PaintArea.Image)上的繪圖物件g
                Pen pen = new Pen(colorDialog.Color, trackBar_Brush.Value);
                g.DrawLine(pen, x0, y0, e.X, e.Y);       //在畫布畫下(x0, y0)→(e.X, e.Y)的線段
                x0 = e.X; y0 = e.Y;     //結束時定義新的繪圖座標起點
                PaintArea.Refresh();    //更新畫布狀態
            }
        }
    }
}

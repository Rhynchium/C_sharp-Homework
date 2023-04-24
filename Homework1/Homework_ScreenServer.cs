using Homework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Homework_ScreenServer : Form
    {
        int stepX = 1, stepY = 1;
        public Homework_ScreenServer()
        {
            InitializeComponent();
        }
        private void Homework_ScreenServer_Click(object sender, EventArgs e)
        {
            this.Close();       //點擊滑鼠結束
        }

        private void Homework_ScreenServer_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();       //按任一按鍵結束
        }
        int x = System.Windows.Forms.Cursor.Position.X, y = System.Windows.Forms.Cursor.Position.Y; //設置滑鼠初始座標
        private void Homework_ScreenServer_MouseMove(object sender, MouseEventArgs e)
        {
            if (x != System.Windows.Forms.Cursor.Position.X || y != System.Windows.Forms.Cursor.Position.Y)     //當滑鼠座標改變
            {
                this.Close();
            }
        }
        private void picture_Lemon_Click(object sender, EventArgs e)
        {
            this.Close();       //點擊滑鼠結束
        }

        private void timer_Tick(object sender, EventArgs e)     //根據timer定期執行
        {
            if ((picture_Lemon.Location.X + picture_Lemon.Width) > this.ClientSize.Width || picture_Lemon.Location.X < 0) //圖片座標+圖片寬>右螢幕邊界 or 圖片碰觸左螢幕邊界
                stepX = -stepX;     //反轉圖片移動方向
            if ((picture_Lemon.Location.Y + picture_Lemon.Height) > this.ClientSize.Height || picture_Lemon.Location.Y < 0) //圖片座標+圖片高>上螢幕邊界 or 圖片碰觸下螢幕邊界
                stepY = -stepY;
            picture_Lemon.Location = new Point(picture_Lemon.Location.X + stepX, picture_Lemon.Location.Y + stepY);     //指定本次位置
        }
    }
}

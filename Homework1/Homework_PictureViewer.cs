using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://stackoverflow.com/questions/19193745/display-an-image-into-windows-forms
//
//
namespace Homework1
{
    public partial class Homework_PictureViewer : Form
    {
        public Homework_PictureViewer()
        {
            InitializeComponent();
        }
        private void Homework_PictureViewer_Load(object sender, EventArgs e)
        {
            int x = 10, y = 10;     //排版用固定間距
            string route = @"C:\Users\User\source\repos\Lab_C#\Homework1\bin\Debug\PIC";      //將資料夾路徑做成字串(換電腦要換路徑)
            string[] file = Directory.GetFiles(route);      //資料夾路徑→圖片路徑→做成陣列
            foreach (string image in file)  //將陣列中圖片路徑指定為image字串
            {
                PictureBox picture = new PictureBox();
                picture.Image = Image.FromFile(image);  // 由字串路徑抓取圖片(複數圖片無法從屬性設定)
                picture.Size = new Size(100, 100);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                if (x > this.Width - 100)     //排序將超出板面
                { x = 10; y += 110; }    //由座標設定換行
                picture.Location = new Point(x, y);
                x += 110;     //設定下一張圖座標
                picture.Click += new EventHandler(pictureBox_Click);    //新增按鈕事件
                PictureViewerPanel.Controls.Add(picture);    //新增圖片至版面
            }
        }
        private void PictureViewerPanel_Resize(object sender, EventArgs e)
        {
            PictureViewerPanel.Controls.Clear();
                Homework_PictureViewer_Load(sender, e);
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            Homework_pictureViewer_Viewer Viewer = new Homework_pictureViewer_Viewer();
            Viewer.Vpicture = picture;
            Viewer.Show();
        }
    }
}

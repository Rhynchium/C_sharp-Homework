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

namespace Homework1
{
    public partial class Homework_NotePad : Form
    {
        public Homework_NotePad()
        {
            InitializeComponent();
        }
        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = string.Empty;    //設定新檔名為空→進入另存新檔條件式
            tex_Mainspace.Clear();
        }
        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            新增NToolStripMenuItem_Click(sender, e);
        }
        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)        //開啟檔案選取視窗→(已於openFileDialog設定只可開txt檔)選擇檔案並按下"OK"
            {
                tex_Mainspace.Text = File.ReadAllText(openFileDialog.FileName, Encoding.Default);
            }
        }
        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            開啟OToolStripMenuItem_Click(sender, e);
        }
        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)        //開啟存檔視窗→(已於openFileDialog設定只可開txt檔)選擇檔案並按下"OK"
            {
                File.WriteAllText(saveFileDialog.FileName, tex_Mainspace.Text, Encoding.Default);
            }
        }
        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.FileName == string.Empty)       //檔案名稱為空(未有既有檔案)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)        //開啟存檔視窗另存新檔
                {
                    File.WriteAllText(saveFileDialog.FileName, tex_Mainspace.Text, Encoding.Default);
                }
            }
            else
            {
                File.WriteAllText(openFileDialog.FileName, tex_Mainspace.Text, Encoding.Default);      //原位址儲存，覆蓋原檔案
            }
        }
        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {
            儲存SToolStripMenuItem_Click(sender, e);
        }
        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Homework_NotePad_info info = new Homework_NotePad_info();
            info.ShowDialog();
        }
        private void 說明LToolStripButton_Click(object sender, EventArgs e)
        {
            關於AToolStripMenuItem_Click(sender, e);
        }
        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tex_Mainspace.Cut();
        }
        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            tex_Mainspace.Cut();
        }
        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tex_Mainspace.Copy();
        }
        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            tex_Mainspace.Copy();
        }
        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tex_Mainspace.Paste();
        }
        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            tex_Mainspace.Paste();
        }
        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tex_Mainspace.SelectAll();
        }
        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            tex_Mainspace.ForeColor = colorDialog.Color;
        }
        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            tex_Mainspace.Font = fontDialog.Font;
        }
        private void toUpperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string org = tex_Mainspace.Text;
            tex_Mainspace.Text = org.ToUpper();
        }
        private void ToLowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string org = tex_Mainspace.Text;
            tex_Mainspace.Text = org.ToLower();
        }
        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tex_Mainspace.WordWrap = !tex_Mainspace.WordWrap;
        }
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tex_Mainspace.ForeColor = Color.Black;
        }
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tex_Mainspace.ForeColor = Color.Red;
        }
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tex_Mainspace.ForeColor = Color.Blue;
        }
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tex_Mainspace.ForeColor = Color.Green;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            toolStrip_ShowTime.Text = DateTime.Now.ToString("T");
        }
    }
}

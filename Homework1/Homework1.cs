using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Homework1 : Form
    {
        public Homework1()
        {
            InitializeComponent();
        }
        private void ButHello_Click(object sender, EventArgs e)
        {
            String Cname = texform_CN.Text;
            String Ename = texform_EN.Text;
            String Gen = texform_G.Text;
            String C = texform_C.Text;
            MessageBox.Show("Hello! 我的名字是"+Cname+"、\n英文名字是"+Ename+"，\n我的性別是"+Gen+"，\n我的星座是" +C+"，\n很高興認識你！");
        }
        private void ButHi_Click(object sender, EventArgs e)
        {
            String Cname = texform_CN.Text;
            String Ename = texform_EN.Text;
            String Gen = texform_G.Text;
            String C = texform_C.Text;
            MessageBox.Show("Hi! 我的名字是" + Cname + "、" + Environment.NewLine + "英文名" +
                "字是" + Ename + "，" + Environment.NewLine + "我的性別是" + Gen + "，" + Environment.NewLine + "我" +
                "的星座是" + C + "，" + Environment.NewLine + "很高興認識你！");
        }
    }
}

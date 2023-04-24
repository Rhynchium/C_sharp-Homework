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
    public partial class returnmethod : Form
    {
        public returnmethod()
        {
            InitializeComponent();
        }

        private void find_bitrhyear(object sender, EventArgs e)
        {
           //tex_Age.
            string resultyear = BirthYear(20);
            MessageBox.Show(resultyear);
        }

        String BirthYear(int Age)  //int 輸入整數參數
        {
            int resultyear = DateTime.Now.Year - Age; //計算今年年份-輸入年齡
            return "出生年為"+resultyear+"年。";  //傳回字串 (字串+數值+字串 = 字串)
        }

        private void MyClass(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            //mc.Method01();
            //mc.Method02();
            mc.Method03();  //需internal或public才可跨類別使用
            mc.Method04();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            mc.Method05();  //可透過封存叫出private的類別
        }

        private void Partialclass(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            mc.Method06();  //透過partial從獨立類別寫出06後使用
        }
    }
}

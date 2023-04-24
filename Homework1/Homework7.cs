using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Homework1.HomeworkUtility;

namespace Homework1
{
    public partial class Homework7 : Form
    {
        public Homework7()
        {
            InitializeComponent();
        }

        private void but_Adddata_Click(object sender, EventArgs e)
        {

            //HW5SavedData data;      //結構不須先定義
            ////bool ChineseNum = double.Parse(tex_Chinese.Text, out tex_Chinese);
            ////bool EnglishNum = double.Parse(tex_English.Text, out );
            ////bool MathNum = double.Parse(tex_English.Text, out );

            //if (tex_Name.Text == string.Empty)
            //{
            //    MessageBox.Show("請輸入姓名！");
            //    return;
            //}
            //else if (tex_Chinese.Text == string.Empty)
            //{
            //    MessageBox.Show("請輸入國文成績！");
            //    tex_Chinese.Focus();
            //    return;
            //}
            //else if (tex_English.Text == string.Empty)
            //{
            //    MessageBox.Show("請輸入英文成績！");
            //    tex_English.Focus();
            //    return;
            //}
            //else if (tex_Math.Text == string.Empty)
            //{
            //    MessageBox.Show("請輸入數學成績！");
            //    tex_Math.Focus();
            //    return;
            //}
            //data.Name = tex_Name.Text;
            //data.Chinese = double.Parse(tex_Chinese.Text);
            //data.English = double.Parse(tex_English.Text);
            //data.Math = double.Parse(tex_Math.Text);

            //n += 1;
            //totalChinese += data.Chinese;
            //totalEnglish += data.English;
            //totalMath += data.Math;
            //if (bottomChinese >= data.Chinese)
            //    bottomChinese = data.Chinese;
            //if (bottomEnglish >= data.English)
            //    bottomEnglish = data.English;
            //if (bottomMath >= data.Math)
            //    bottomMath = data.Math;
            //if (topChinese <= data.Chinese)
            //    topChinese = data.Chinese;
            //if (topEnglish <= data.English)
            //    topEnglish = data.English;
            //if (topMath <= data.Math)
            //    topMath = data.Math;

            //String[] Subject = new string[] { "國文", "英文", "數學" };
            //double[] Score = new double[] { data.Chinese, data.English, data.Math };
            //////for (int i = 0; i < Score.Length; i++) { data.Sum += Score[i]; }
            //data.Sum = Score.Sum();
            //data.Average = Score.Average();
            //double HighScore = Score[0];
            //int k = 0;
            //for (int j = 0; j < Score.Length; j++)
            //{
            //    if (Score[j] > HighScore)
            //    {
            //        HighScore = Score[j];
            //        k = j;
            //    }
            //}
            //double LowScore = Score[0];
            //int m = 0;
            //for (int l = 0; l < Score.Length; l++)
            //{
            //    if (Score[l] < LowScore)
            //    {
            //        LowScore = Score[l];
            //        m = l;
            //    }
            //}
            //data.Top = Subject[k] + " " + HighScore;
            //data.Bottom = Subject[m] + " " + LowScore;

            //ListViewItem newdata = new ListViewItem(new string[] { data.Name, data.Chinese.ToString(), data.English.ToString(), data.Math.ToString(), data.Sum.ToString(), data.Average.ToString(), data.Bottom, data.Top });
            //list_Data.Items.Add(newdata);   //新增資料列
            //but_Caculate.Enabled = true;    //啟用按鈕
        }
    }
}

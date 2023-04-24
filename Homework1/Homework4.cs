using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Homework.HomeworkUtility;

namespace Homework
{
    public partial class Homework4 : Form
    {
        public Homework4()
        {
            InitializeComponent();
        }
        HW4SavedData saveddata = new HW4SavedData();
        private void but_Save_Click(object sender, EventArgs e)
        {
            bool CHisNumeric = tex_Chinese.Text.All(char.IsDigit);
            bool ENisNumeric = tex_English.Text.All(char.IsDigit);
            bool MAisNumeric = tex_Math.Text.All(char.IsDigit);
            if (string.IsNullOrEmpty(tex_Name.Text))
            {
                MessageBox.Show("請輸入姓名！");
                tex_Name.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_Chinese.Text) || CHisNumeric == false)
            {
                MessageBox.Show("請輸入國文成績！");
                tex_Chinese.Clear();
                tex_Chinese.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_English.Text) || ENisNumeric == false)
            {
                MessageBox.Show("請輸入英文成績！");
                tex_English.Clear();
                tex_English.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_Math.Text) || MAisNumeric == false)
            {
                MessageBox.Show("請輸入數學成績！");
                tex_Math.Clear();
                tex_Math.Focus();
                return;
            }
            saveddata.Name = tex_Name.Text;
            saveddata.Chinese = int.Parse(tex_Chinese.Text);
            saveddata.English = int.Parse(tex_English.Text);
            saveddata.Math = int.Parse(tex_Math.Text);
        }
        private void but_Showsave_Click(object sender, EventArgs e)
        {
            tex_Datalist.Text = "姓名：" + saveddata.Name + Environment.NewLine + "國文成績：" + saveddata.Chinese + Environment.NewLine +
                "英文成績：" + saveddata.English + Environment.NewLine + "數學成績：" + saveddata.Math;
        }
        private void but_Showscore_Click(object sender, EventArgs e)
        {
            String[] Subject = new string[] { "國文", "英文", "數學" };
            int[] Score = new int[] { saveddata.Chinese, saveddata.English, saveddata.Math };
            int ScoreHigh = Score[0];
            int j = 0;
            for (int i = 0; i < 3; i++)
            {
                if (Score[i] > ScoreHigh)
                {
                    ScoreHigh = Score[i];
                    j = i;
                }
            }
            int ScoreLow = Score[0];
            int l = 0;
            for (int k = 0; k < 3; k++)
            {
                if (Score[k] < ScoreLow)
                {
                    ScoreLow = Score[k];
                    l = k;
                }
            }
            tex_ShowScore.Text = "最高科目成績為：" + Subject[j] + ScoreHigh + "分\n最低科目成績為：" + Subject[l] + ScoreLow + "分";
        }
    }
}
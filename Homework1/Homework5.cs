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
using static Homework.HomeworkUtility;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Homework
{
    public partial class Homework5 : Form
    {
        public Homework5()
        { InitializeComponent(); }
        double totalChinese = 0;
        double bottomChinese = 100;
        double topChinese = 0;
        double totalEnglish = 0;
        double bottomEnglish = 100;
        double topEnglish = 0;
        double totalMath = 0;
        double bottomMath = 100;
        double topMath = 0;
        private void but_Adddata_Click(object sender, EventArgs e)
        {
            HW5SavedData data;      //結構不須先定義
            bool CHisNumeric = tex_Chinese.Text.All(char.IsDigit);   //檢測是否為數字，若為數字則isNumeric=true
            bool ENisNumeric = tex_English.Text.All(char.IsDigit);
            bool MAisNumeric = tex_Math.Text.All(char.IsDigit);
            if (string.IsNullOrEmpty(tex_Name.Text))        //識別輸入欄是否空白
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
            data.Name = tex_Name.Text;
            data.Chinese = double.Parse(tex_Chinese.Text);
            data.English = double.Parse(tex_English.Text);
            data.Math = double.Parse(tex_Math.Text);
            String[] Subject = new string[] { "國文", "英文", "數學" };
            double[] Score = new double[] { data.Chinese, data.English, data.Math };
            double LowScore = Score[0];
            int k = 0;
            for (int j = 0; j < Score.Length; j++)
            {
                if (Score[j] < LowScore)
                {
                    LowScore = Score[j];
                    k = j;
                }
            }
            double HighScore = Score[0];
            int m = 0;
            for (int l = 0; l < Score.Length; l++)
            {
                if (Score[l] > HighScore)
                {
                    HighScore = Score[l];
                    m = l;
                }
            }
            data.Sum = Score.Sum();     //←用語法直接計算；用迴圈計算→for (int i = 0; i < Score.Length; i++) { data.Sum += Score[i]; }
            data.Average = Math.Round(Score.Average(), 2);
            data.Bottom = Subject[k] + " " + LowScore;
            data.Top = Subject[m] + " " + HighScore;

            ListViewItem newdata = new ListViewItem(data.Name);
            newdata.SubItems.Add(data.Chinese.ToString());
            newdata.SubItems.Add(data.English.ToString());
            newdata.SubItems.Add(data.Math.ToString());
            newdata.SubItems.Add(data.Sum.ToString());
            newdata.SubItems.Add(data.Average.ToString());
            newdata.SubItems.Add(data.Bottom.ToString());
            newdata.SubItems.Add(data.Top.ToString());
            list_Data.Items.Add(newdata);
            but_Caculate.Enabled = true;    //啟用按鈕
        }
        internal void but_Random_Click(object sender, EventArgs e)
        {
            HW5SavedData randomdata;
            Random rand = new Random(Guid.NewGuid().GetHashCode());     //迴圈計算速度過快會造成亂數高度重複，使用Guid.NewGuid().GetHashCode()增加變異
            int rChinese = rand.Next(0, 100);
            randomdata.Chinese = Convert.ToDouble(rChinese);
            int rEnglish = rand.Next(0, 100);
            randomdata.English = Convert.ToDouble(rEnglish);
            int rMath = rand.Next(0, 100);
            randomdata.Math = Convert.ToDouble(rMath);
            String[] rSubject = new string[] { "國文", "英文", "數學" };
            double[] rScore = new double[] { randomdata.Chinese, randomdata.English, randomdata.Math };
            double LowScore = rScore[0];
            int k = 0;
            for (int j = 0; j < rScore.Length; j++)
            {
                if (rScore[j] < LowScore)
                {
                    LowScore = rScore[j];
                    k = j;
                }
            }
            double HighScore = rScore[0];
            int m = 0;
            for (int l = 0; l < rScore.Length; l++)
            {
                if (rScore[l] > HighScore)
                {
                    HighScore = rScore[l];
                    m = l;
                }
            }
            randomdata.Sum = rScore.Sum();
            randomdata.Average = Math.Round(rScore.Average(), 2);
            randomdata.Bottom = rSubject[k] + " " + LowScore;
            randomdata.Top = rSubject[m] + " " + HighScore;

            ListViewItem newdata = new ListViewItem((list_Data.Items.Count + 1).ToString());
            newdata.SubItems.Add(randomdata.Chinese.ToString());
            newdata.SubItems.Add(randomdata.English.ToString());
            newdata.SubItems.Add(randomdata.Math.ToString());
            newdata.SubItems.Add(randomdata.Sum.ToString());
            newdata.SubItems.Add(randomdata.Average.ToString());
            newdata.SubItems.Add(randomdata.Bottom.ToString());
            newdata.SubItems.Add(randomdata.Top.ToString());
            list_Data.Items.Add(newdata);
            but_Caculate.Enabled = true;
        }
        private void but_20Random_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                but_Random_Click(sender, e);
            }
            but_Caculate.Enabled = true;
        }
        private void but_Caculate_Click(object sender, EventArgs e)
        {
            for (int q = 0; q < list_Data.Items.Count; q++)
            {
                double cacuChinese = Convert.ToInt32(list_Data.Items[q].SubItems[1].Text);
                double cacuEnglish = Convert.ToInt32(list_Data.Items[q].SubItems[2].Text);
                double cacuMath = Convert.ToInt32(list_Data.Items[q].SubItems[3].Text);
                totalChinese += cacuChinese;
                totalEnglish += cacuEnglish;
                totalMath += cacuMath;
                if (bottomChinese >= cacuChinese)
                    bottomChinese = cacuChinese;
                if (bottomEnglish >= cacuEnglish)
                    bottomEnglish = cacuEnglish;
                if (bottomMath >= cacuMath)
                    bottomMath = cacuMath;
                if (topChinese <= cacuChinese)
                    topChinese = cacuChinese;
                if (topEnglish <= cacuEnglish)
                    topEnglish = cacuEnglish;
                if (topMath <= cacuMath)
                    topMath = cacuMath;
            }
            double averageChinese = Math.Round(totalChinese / list_Data.Items.Count, 2);
            double averageEnglish = Math.Round(totalEnglish / list_Data.Items.Count, 2);
            double averageMath = Math.Round(totalMath / list_Data.Items.Count, 2);

            ListViewItem cacuSum = new ListViewItem(new string[] { "總分", totalChinese.ToString(), totalEnglish.ToString(), totalMath.ToString() });
            list_Cacu.Items.Add(cacuSum);
            ListViewItem cacuAverage = new ListViewItem(new string[] { "平均", averageChinese.ToString(), averageEnglish.ToString(), averageMath.ToString() });
            list_Cacu.Items.Add(cacuAverage);
            ListViewItem cacuBottom = new ListViewItem(new string[] { "最低分", bottomChinese.ToString(), bottomEnglish.ToString(), bottomMath.ToString() });
            list_Cacu.Items.Add(cacuBottom);
            ListViewItem cacuTop = new ListViewItem(new string[] { "最高分", topChinese.ToString(), topEnglish.ToString(), topMath.ToString() });
            list_Cacu.Items.Add(cacuTop);

            but_Adddata.Enabled = false;
            but_Random.Enabled = false;
            but_Caculate.Enabled = false;
            but_20Random.Enabled = false;
        }
        private void but_Reset_Click(object sender, EventArgs e)
        {
            totalChinese = 0;
            bottomChinese = 100;
            topChinese = 0;
            totalEnglish = 0;
            bottomEnglish = 100;
            topEnglish = 0;
            totalMath = 0;
            bottomMath = 100;
            topMath = 0;
            tex_Name.Clear();
            tex_Chinese.Clear();
            tex_English.Clear();
            tex_Math.Clear();
            list_Data.Items.Clear();
            list_Cacu.Items.Clear();
            but_Adddata.Enabled = true;
            but_Random.Enabled = true;
            but_20Random.Enabled = true;
            but_Caculate.Enabled = false;
        }
    }
}

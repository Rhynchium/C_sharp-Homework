using System;
using System.Collections;
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
    public partial class Homework6 : Form
    {
        public Homework6()
        {
            InitializeComponent();
        }
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
            HW6SavedData data;
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
            data.Name = tex_Name.Text;
            data.Chinese = double.Parse(tex_Chinese.Text);
            data.English = double.Parse(tex_English.Text);
            data.Math = double.Parse(tex_Math.Text);
            String[] Subject = new string[] { "國文", "英文", "數學" };
            double[] Score = new double[] { double.Parse(tex_Chinese.Text), double.Parse(tex_English.Text), double.Parse(tex_Chinese.Text) };
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
            data.Sum = Score.Sum();
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
            but_RemoveAt.Enabled = true;
            but_Clear.Enabled = true;
            but_SEARCH.Enabled = true;
            but_Caculate.Enabled = true;
            tex_LowRange.Enabled = true;
            tex_HighRange.Enabled = true;
        }
        private void but_Insert_Click(object sender, EventArgs e)
        {
            HW6SavedData data;
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
            data.Name = tex_Name.Text;
            data.Chinese = double.Parse(tex_Chinese.Text);
            data.English = double.Parse(tex_English.Text);
            data.Math = double.Parse(tex_Math.Text);
            String[] Subject = new string[] { "國文", "英文", "數學" };
            double[] Score = new double[] { double.Parse(tex_Chinese.Text), double.Parse(tex_English.Text), double.Parse(tex_Chinese.Text) };
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
            data.Sum = Score.Sum();
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
            list_Data.Items.Insert(0, newdata);
            but_RemoveAt.Enabled = true;
            but_Clear.Enabled = true;
            but_SEARCH.Enabled = true;
            but_Caculate.Enabled = true;
            tex_LowRange.Enabled = true;
            tex_HighRange.Enabled = true;
        }
        private void but_RemoveAt_Click(object sender, EventArgs e)
        {
            list_Data.Items.RemoveAt(0);
            if (list_Data.Items.Count == 0)
            {
                but_RemoveAt.Enabled = false;
                but_Clear.Enabled = false;
                but_SEARCH.Enabled = false;
                but_Caculate.Enabled = false;
                tex_LowRange.Enabled = false;
                tex_HighRange.Enabled = false;
            }
        }
        private void but_Clear_Click(object sender, EventArgs e)
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
            tex_LowRange.Clear();
            tex_HighRange.Clear();
            list_Data.Items.Clear();
            list_Cacu.Items.Clear();
            but_Adddata.Enabled = true;
            but_Insert.Enabled = true;
            but_RemoveAt.Enabled = false;
            but_Clear.Enabled = false;
            but_SEARCH.Enabled = false;
            but_Caculate.Enabled = false;
            tex_LowRange.Enabled = false;
            tex_HighRange.Enabled = false;
        }
        private void but_SEARCH_Click(object sender, EventArgs e)
        {
            bool LRisNumeric = tex_LowRange.Text.All(char.IsDigit);
            bool HRisNumeric = tex_HighRange.Text.All(char.IsDigit);
            if (string.IsNullOrEmpty(tex_LowRange.Text) || LRisNumeric == false)
            {
                MessageBox.Show("請輸入查詢成績下限！");
                tex_LowRange.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_HighRange.Text) || HRisNumeric == false)
            {
                MessageBox.Show("請輸入查詢成績上限！");
                tex_HighRange.Focus();
                return;
            }
            else if (double.Parse(tex_LowRange.Text) > double.Parse(tex_HighRange.Text))
            {
                MessageBox.Show("成績下限請輸在左側，\n上限請輸在右方！");
                tex_LowRange.Clear();
                tex_HighRange.Clear();
                tex_LowRange.Focus();
                return;
            }
            double LowRange = double.Parse(tex_LowRange.Text);
            double HighRange = double.Parse(tex_HighRange.Text);
            for (int p = 0; p < list_Data.Items.Count; p++)
            {
                double Chinesetester = Convert.ToInt32(list_Data.Items[p].SubItems[1].Text); // ← [ListView].Items[第幾row].SubItems[第幾colum].Text
                if (Chinesetester < LowRange || Chinesetester > HighRange)
                {
                    list_Data.Items.RemoveAt(p);
                    p--;
                }
            }
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
            but_Insert.Enabled = false;
            but_RemoveAt.Enabled = false;
            but_SEARCH.Enabled = false;
            but_Caculate.Enabled = false;
            tex_LowRange.Enabled = false;
            tex_HighRange.Enabled = false;
        }
    }
}

using Homework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Homework
{
    public partial class Homework2 : Form
    {
        public Homework2()
        {
            InitializeComponent();
        }
        public void but_PMT_Click(object sender, EventArgs e)
        {
            bool LOisNumeric = tex_loan.Text.All(char.IsDigit);
            bool YDisNumeric = tex_yearduration.Text.All(char.IsDigit);
            bool YRisNumeric = tex_yearratio.Text.All(char.IsDigit);
            bool HAisNumeric = tex_head.Text.All(char.IsDigit);
            if (string.IsNullOrEmpty(tex_loan.Text) || LOisNumeric == false)
            {
                MessageBox.Show("請輸入貸款金額！");
                tex_loan.Clear();
                tex_loan.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_yearduration.Text) || YDisNumeric == false)
            {
                MessageBox.Show("請輸入期限 (年)！");
                tex_yearduration.Clear();
                tex_yearduration.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_yearratio.Text) || YRisNumeric == false)
            {
                MessageBox.Show("請輸入利率 (%)！");
                tex_yearratio.Clear();
                tex_yearratio.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_head.Text) || HAisNumeric == false)
            {
                MessageBox.Show("請輸入頭期款！");
                tex_head.Clear();
                tex_head.Focus();
                return;
            }
            double Loan = double.Parse(tex_loan.Text);        //讀取輸入貸款金額
            double Year_Duration = double.Parse(tex_yearduration.Text);        //讀取輸入期限(年)
            double Year_Ratio = double.Parse(tex_yearratio.Text);        //讀取輸入年利率
            double Head = double.Parse(tex_head.Text);        //讀取輸入頭期款
            double month_duration = Year_Duration * 12;
            double month_ratio = (Year_Ratio * 0.01) / 12;
            //每月應付本息金額之平均攤還率 ＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
            //(公式中：月利率 ＝ 年利率／12 ； 月數=貸款年期 ｘ 12)
            //求次方的方式:Math.Pow(double 底數,double 幾次方)
            double PMT = (Math.Pow(1 + (month_ratio), month_duration) * month_ratio) / (Math.Pow(1 + (month_ratio), month_duration) - 1);        //寫+-號注意空格
            double result = (Loan - Head) * PMT;
            var monthly_fullnumber = Math.Round(result, 0);      //四捨五入公式:{round}  無條件進位到整數:{Ceiling}  無條件捨去到整數{floor}      (result, 0)→(欲處理數字, 四捨五入小數位數)
            MessageBox.Show("月付額：" + monthly_fullnumber + "元。");
        }
        public void but_total_Click(object sender, EventArgs e)
        {
            bool LOisNumeric = tex_loan.Text.All(char.IsDigit);
            bool YDisNumeric = tex_yearduration.Text.All(char.IsDigit);
            bool YRisNumeric = tex_yearratio.Text.All(char.IsDigit);
            bool HAisNumeric = tex_head.Text.All(char.IsDigit);
            if (string.IsNullOrEmpty(tex_loan.Text) || LOisNumeric == false)
            {
                MessageBox.Show("請輸入貸款金額！");
                tex_loan.Clear();
                tex_loan.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_yearduration.Text) || YDisNumeric == false)
            {
                MessageBox.Show("請輸入期限 (年)！");
                tex_yearduration.Clear();
                tex_yearduration.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_yearratio.Text) || YRisNumeric == false)
            {
                MessageBox.Show("請輸入利率 (%)！");
                tex_yearratio.Clear();
                tex_yearratio.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_head.Text) || HAisNumeric == false)
            {
                MessageBox.Show("請輸入頭期款！");
                tex_head.Clear();
                tex_head.Focus();
                return;
            }
            double Loan = double.Parse(tex_loan.Text);
            double Year_Duration = double.Parse(tex_yearduration.Text);
            double Year_Ratio = double.Parse(tex_yearratio.Text);
            double Head = double.Parse(tex_head.Text);
            double month_duration = Year_Duration * 12;
            double month_ratio = (Year_Ratio * 0.01) / 12;
            double PMT = (Math.Pow(1 + (month_ratio), month_duration) * month_ratio) / (Math.Pow(1 + (month_ratio), month_duration) - 1);        //寫+-號注意空格
            double result = (Loan - Head) * PMT;
            var monthly_fullnumber = Math.Round(result, 0);
            double Totalmoney = monthly_fullnumber * month_duration;        //月付額*總月份
            MessageBox.Show("總付額：" + Totalmoney + "元。");
        }
        private void but_report_Click(object sender, EventArgs e)
        {
            bool LOisNumeric = tex_loan.Text.All(char.IsDigit);
            bool YDisNumeric = tex_yearduration.Text.All(char.IsDigit);
            bool YRisNumeric = tex_yearratio.Text.All(char.IsDigit);
            bool HAisNumeric = tex_head.Text.All(char.IsDigit);
            if (string.IsNullOrEmpty(tex_loan.Text) || LOisNumeric == false)
            {
                MessageBox.Show("請輸入貸款金額！");
                tex_loan.Clear();
                tex_loan.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_yearduration.Text) || YDisNumeric == false)
            {
                MessageBox.Show("請輸入期限 (年)！");
                tex_yearduration.Clear();
                tex_yearduration.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_yearratio.Text) || YRisNumeric == false)
            {
                MessageBox.Show("請輸入利率 (%)！");
                tex_yearratio.Clear();
                tex_yearratio.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_head.Text) || HAisNumeric == false)
            {
                MessageBox.Show("請輸入頭期款！");
                tex_head.Clear();
                tex_head.Focus();
                return;
            }
            double Loan = double.Parse(tex_loan.Text);
            double Year_Duration = double.Parse(tex_yearduration.Text);
            double Year_Ratio = double.Parse(tex_yearratio.Text);
            double Head = double.Parse(tex_head.Text);
            double month_duration = Year_Duration * 12;
            double month_ratio = (Year_Ratio * 0.01) / 12;
            double PMT = (Math.Pow(1 + (month_ratio), month_duration) * month_ratio) / (Math.Pow(1 + (month_ratio), month_duration) - 1);
            double result = (Loan - Head) * PMT;
            var monthly_fullnumber = Math.Round(result, 0);
            double Totalmoney = monthly_fullnumber * month_duration;
            string mmoney = monthly_fullnumber.ToString();
            Homework2appendix hw2loan = new Homework2appendix(tex_loan.Text, tex_yearduration.Text, tex_yearratio.Text, monthly_fullnumber.ToString(), Totalmoney.ToString());
            //[目標表單] [實體] = new [目標表單](參數←來源輸入欄.Text)
            hw2loan.Show();       //叫出表單
        }

    }
}

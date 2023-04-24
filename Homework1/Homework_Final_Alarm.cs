using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Homework1
{
    public partial class Homework_Final_Alarm : Form
    {
        public Homework_Final_Alarm()
        {
            InitializeComponent();
        }
        bool alarm = false;     //布林值(是否到時)，預設為否
        int h, m, s;
        private void SetAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (SetAlarm.CheckState == CheckState.Checked)  //勾選時
            {
                alarm = false;
                bool HourisNumeric = tex_Hour.Text.All(char.IsDigit);
                bool MinisNumeric = tex_Min.Text.All(char.IsDigit);
                bool SecisNumeric = tex_Sec.Text.All(char.IsDigit);
                if (string.IsNullOrEmpty(tex_Hour.Text) || HourisNumeric == false || int.Parse(tex_Hour.Text) > 24 || int.Parse(tex_Hour.Text) < 0)
                {
                    MessageBox.Show("請輸入正確的鬧鐘整點時數！");
                    tex_Hour.Clear();
                    tex_Hour.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(tex_Min.Text) || MinisNumeric == false || int.Parse(tex_Min.Text) > 59 || int.Parse(tex_Min.Text) < 0)
                {
                    MessageBox.Show("請輸入正確的鬧鐘分鐘數！");
                    tex_Min.Clear();
                    tex_Min.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(tex_Sec.Text) || SecisNumeric == false || int.Parse(tex_Sec.Text) > 59 || int.Parse(tex_Sec.Text) < 0)
                {
                    MessageBox.Show("請輸入正確的鬧鐘秒數！");
                    tex_Sec.Clear();
                    tex_Sec.Focus();
                    return;
                }
                h = int.Parse(tex_Hour.Text);
                m = int.Parse(tex_Min.Text);
                s = int.Parse(tex_Sec.Text);
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lab_Clock.Text = DateTime.Now.ToString("H:mm:ss");
            if (alarm == false)
            {
                if (h == DateTime.Now.Hour)
                {
                    if (m == DateTime.Now.Minute)
                    {
                        if (s == DateTime.Now.Second)
                        {
                            alarm = true;
                            MessageBox.Show("(鬧鐘響了！)");
                        }
                    }
                }
            }
        }
    }
}
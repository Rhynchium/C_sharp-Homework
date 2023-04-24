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
    public partial class Homework8 : Form
    {
        public Homework8()
        {
            InitializeComponent();
        }
        private void but_plus_Click(object sender, EventArgs e)
        {
            bool N1isNumeric = tex_N1.Text.All(char.IsDigit);
            bool N2isNumeric = tex_N2.Text.All(char.IsDigit);
            if (string.IsNullOrEmpty(tex_N1.Text) || N1isNumeric == false)
            {
                MessageBox.Show("請輸入數字！");
                tex_N1.Clear();
                tex_N1.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_N2.Text) || N2isNumeric == false)
            {
                MessageBox.Show("請輸入數字！");
                tex_N2.Clear();
                tex_N2.Focus();
                return;
            }
            double N1 = double.Parse(tex_N1.Text);
            double N2 = double.Parse(tex_N2.Text);
            tex_Ans.Text = (N1 + N2).ToString();
        }
        private void but_minus_Click(object sender, EventArgs e)
        {
            bool N1isNumeric = tex_N1.Text.All(char.IsDigit);
            bool N2isNumeric = tex_N2.Text.All(char.IsDigit);
            if (string.IsNullOrEmpty(tex_N1.Text) || N1isNumeric == false)
            {
                MessageBox.Show("請輸入數字！");
                tex_N1.Clear();
                tex_N1.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_N2.Text) || N2isNumeric == false)
            {
                MessageBox.Show("請輸入數字！");
                tex_N2.Clear();
                tex_N2.Focus();
                return;
            }
            double N1 = double.Parse(tex_N1.Text);
            double N2 = double.Parse(tex_N2.Text);
            tex_Ans.Text = (N1 - N2).ToString();
        }
        private void but_cross_Click(object sender, EventArgs e)
        {
            bool N1isNumeric = tex_N1.Text.All(char.IsDigit);
            bool N2isNumeric = tex_N2.Text.All(char.IsDigit);
            if (string.IsNullOrEmpty(tex_N1.Text) || N1isNumeric == false)
            {
                MessageBox.Show("請輸入數字！");
                tex_N1.Clear();
                tex_N1.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_N2.Text) || N2isNumeric == false)
            {
                MessageBox.Show("請輸入數字！");
                tex_N2.Clear();
                tex_N2.Focus();
                return;
            }
            double N1 = double.Parse(tex_N1.Text);
            double N2 = double.Parse(tex_N2.Text);
            tex_Ans.Text = (N1 * N2).ToString();
        }
        private void but_div_Click(object sender, EventArgs e)
        {
            bool N1isNumeric = tex_N1.Text.All(char.IsDigit);
            bool N2isNumeric = tex_N2.Text.All(char.IsDigit);
            if (string.IsNullOrEmpty(tex_N1.Text) || N1isNumeric == false)
            {
                MessageBox.Show("請輸入數字！");
                tex_N1.Clear();
                tex_N1.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_N2.Text) || N2isNumeric == false)
            {
                MessageBox.Show("請輸入數字！");
                tex_N2.Clear();
                tex_N2.Focus();
                return;
            }
            double N1 = double.Parse(tex_N1.Text);
            double N2 = double.Parse(tex_N2.Text);
            tex_Ans.Text = (N1 / N2).ToString();
        }
    }
}

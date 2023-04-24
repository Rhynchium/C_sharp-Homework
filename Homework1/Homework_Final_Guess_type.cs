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
    public partial class Homework_Final_Guess_type : Form
    {
        public Homework_Final_Guess_type(int answer)
        {
            InitializeComponent();
            this.answer = answer;   //定義本地端的answer = 傳值來的answer
        }
        int answer;     //建立answer
        string message = string.Empty;
        int max = 99, min = 1;
        public delegate void ReturnMessage(string returnmessage);
        public event ReturnMessage ReturnmessageCallback;
        private void but_Enter_Click(object sender, EventArgs e)
        {
            bool isNumeric = tex_GuessNumber.Text.All(char.IsDigit);
            if (string.IsNullOrEmpty(tex_GuessNumber.Text) || isNumeric == false || int.Parse(tex_GuessNumber.Text) < 1 || int.Parse(tex_GuessNumber.Text) > 100)
            {
                MessageBox.Show("請輸入1~100間的數字！");
                tex_GuessNumber.Clear();
                tex_GuessNumber.Focus();
                return;
            }
            int guess = int.Parse(tex_GuessNumber.Text);
            if (guess == answer)
            {
                MessageBox.Show("Congradulations! You got " + guess + "!");
                message = "Select a number between 1 and 100!";
            }
            else if (guess > answer)
            {
                if (max < guess) { MessageBox.Show("猜比" + max + "小的數字啦！"); }
                else { max = guess; }
                message = "Too Large!\nBewteen " + max + " and " + min + "!";
            }
            else
            {
                if (min > guess) { MessageBox.Show("猜比" + min + "大的數字啦！"); }
                else { min = guess; }
                message = "Too Small!\nBewteen " + max + " and " + min + "!";
            }
            tex_GuessNumber.Focus();
            tex_GuessNumber.Clear();
            ReturnmessageCallback(message);
        }
        private void but_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

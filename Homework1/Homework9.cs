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
    public partial class Homework9 : Form
    {
        public Homework9()
        {
            InitializeComponent();
        }
        int[] Arr1 = { 212, 11, 35, 65, 69, 4, 806, 2124, 510, 2988 };
        string[] Arr_str = { "Nanaura", "Rhynchium", "普通昆蟲學", "Exist", "維生素C", "Song", "虛數", "Vespa" };
        private void but_CheckInput_Click(object sender, EventArgs e)
        {
            bool isNumeric = tex_Number.Text.All(char.IsDigit);
            if (string.IsNullOrEmpty(tex_Number.Text) || isNumeric == false)
            {
                MessageBox.Show("請輸入數字！");
                tex_Number.Clear();
                tex_Number.Focus();
                return;
            }
            int a = int.Parse(tex_Number.Text);
            string Reply = (a % 2 == 0) ? "輸入的數: " + a + " 為偶數" : "輸入的數：" + a + " 為奇數";
            lab_Result.Text = Reply;
        }
        private void but_MakeTree_Click(object sender, EventArgs e)
        {
            bool isNumeric = tex_Row.Text.All(char.IsDigit);
            if (string.IsNullOrEmpty(tex_Row.Text) || isNumeric == false || int.Parse(tex_Row.Text) == 0)
            {
                MessageBox.Show("請輸入正整數！");
                tex_Row.Clear();
                tex_Row.Focus();
                return;
            }
            string tree = string.Empty;
            string leaf = string.Empty;
            for (int t = 0; t < int.Parse(tex_Row.Text); t++)
            {
                leaf += "♂";
                tree += leaf + "\n";
            }
            lab_Result.Text = tree;
        }
        private void but_ClearAll_Click(object sender, EventArgs e)
        {
            tex_Number.Clear();
            tex_From.Clear();
            tex_To.Clear();
            tex_Step.Clear();
            tex_Row.Clear();
            lab_Result.Text = "結果：";
        }
        void Swap(ref int A, ref int B)
        { int T = A; A = B; B = T; }
        private void but_Swap_Click(object sender, EventArgs e)
        {
            int n1 = 100, n2 = 200;
            string before = "換位前 n1=" + n1 + ", n2=" + n2;
            Swap(ref n1, ref n2);
            string after = "換位後 n1=" + n1 + ", n2=" + n2;
            lab_Result.Text = before + "\n" + after;
        }
        private void but_FindMaxMin_Click(object sender, EventArgs e)
        { //int min = Arr1[0], max = Arr1[0]; for (int i = 0; i < Arr1.Length; i++) { if (min > Arr1[i]) min = Arr1[i]; if (max < Arr1[i]) max = Arr1[i]; } lab_Result.Text = "int陣列Arr [212, 11, 35, 65, 69, 4, 806, 2124, 510, 2988]\n最大值為: " + max + ".\n最小值為: " + min + ".";
            lab_Result.Text = "int陣列Arr [212, 11, 35, 65, 69, 4, 806, 2124, 510, 2988]\n最大值為: " + Arr1.Max() + ".\n最小值為: " + Arr1.Min() + ".";
        }
        private void but_CountEvenOdd_Click(object sender, EventArgs e)
        {
            int odd = 0; int even = 0;
            for (int j = 0; j < Arr1.Length; j++)
            {
                if (Arr1[j] % 2 == 1)
                    odd++;
                else even++;
            }
            lab_Result.Text = "int陣列Arr [212, 11, 35, 65, 69, 4, 806, 2124, 510, 2988]\n奇數共: " + odd + " 個.\n偶數共: " + even + " 個.";
        }
        private void but_Sum_Click(object sender, EventArgs e)
        {
            lab_Result.Text = "int陣列Arr [212, 11, 35, 65, 69, 4, 806, 2124, 510, 2988]\n加總為: " + Arr1.Sum() + ".";
        }
        private void but_Max_Click(object sender, EventArgs e)
        {
            lab_Result.Text = "int陣列Arr [212, 11, 35, 65, 69, 4, 806, 2124, 510, 2988]\n最大值為: " + Arr1.Max() + ".";
        }
        private void butt_Min_Click(object sender, EventArgs e)
        {
            lab_Result.Text = "int陣列Arr [212, 11, 35, 65, 69, 4, 806, 2124, 510, 2988]\n最小值為: " + Arr1.Min() + ".";
        }
        private void butt_FindLongest_Click(object sender, EventArgs e)
        {
            int[] strlength = new int[Arr_str.Length];
            int m = 0;
            for (int k = 0; k < Arr_str.Length; k++)
            {
                strlength[k] = Arr_str[k].Length;
                int max = strlength[0];
                if (max < strlength[k])
                {
                    max = strlength[k];
                    m = k;
                }
            }
            lab_Result.Text = "陣列Arr_str [Nanaura, Rhynchium, 普通昆蟲學, Exist, 維生素C, Song, 虛數, Vespa]\n最長的單詞為：" + Arr_str[m] + ".";
        }
        private void but_100to2_Click(object sender, EventArgs e)
        {
            int f = 100;
            //int n = 0;
            //while (Math.Pow(2, n) <= f)
            //{ n++; }
            //string[] arrfor2 = new string[n];
            //for (int k = n - 1; k >= 0; k--)
            //{ arrfor2[k] = (f % 2).ToString();
            //    f = (f - (f % 2)) / 2; }
            //string binary = string.Empty;
            //for (int r = 0; r < arrfor2.Length; r++)
            //{ binary += arrfor2[r]; }
            string binary = Convert.ToString(f, 2);
            lab_Result.Text = binary;
        }
        private void but_Convert_toBinary_Click(object sender, EventArgs e)
        {
            bool isNumeric = tex_Convert_toBinary.Text.All(char.IsDigit);
            if (string.IsNullOrEmpty(tex_Convert_toBinary.Text) || isNumeric == false)
            {
                MessageBox.Show("請輸入數字！");
                tex_Convert_toBinary.Clear();
                tex_Convert_toBinary.Focus();
                return;
            }
            int f = int.Parse(tex_Convert_toBinary.Text);
            string binary = Convert.ToString(f, 2);
            lab_Result.Text = binary;
        }
        private void but_FindwithC_Click(object sender, EventArgs e)
        {
            int n = 0;
            for (int r = 0; r < Arr_str.Length; r++)
            {
                n += (Arr_str[r].Contains("C") || Arr_str[r].Contains("c")) ? 1 : 0;
            }
            lab_Result.Text = "陣列Arr_str [Nanaura, Rhynchium, 普通昆蟲學, Exist, 維生素C, Song, 虛數, Vespa]中\n含有字母C或c的元素共有" + n + "個。";
        }
        private void but_Lottery_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            List<int> Lottery = new List<int>();
            string lottery = string.Empty;
            do
            {
                int number = rand.Next(1, 99);
                int q = Lottery.IndexOf(number);
                if (q < 0)
                {
                    Lottery.Add(number);
                    lottery += number.ToString() + " ";
                }
            } while (Lottery.Count < 6);
            lab_Result.Text = "樂透號碼：" + lottery;
        }
        private void but_Show9x9_Click(object sender, EventArgs e)
        {
            string cross = string.Empty;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    cross += $"{j} * {i} = " + (i * j).ToString("00") + " |      ";
                }
                cross += "\n";
            }
            lab_Result.Text = "九九乘法表：\n" + cross;
        }
        private void but_1cover0_Click(object sender, EventArgs e)
        {
            int[,] array1001 = new int[8, 8];
            string content = string.Empty;
            for (int i = 0; i < array1001.GetLength(0); i++)
            {
                for (int j = 0; j < array1001.GetLength(1); j++)
                {
                    if (i == 0 || i == (array1001.GetLength(0) - 1) || j == 0 || j == (array1001.GetLength(1) - 1))
                    {
                        content += "1   ";
                    }
                    else
                    {
                        content += "0   ";
                    }
                }
                content += "\n";
            }
            lab_Result.Text = content;
        }
        private void but_0cover1_Click(object sender, EventArgs e)
        {
            int[,] array0110 = new int[8, 8];
            string content = string.Empty;
            for (int i = 0; i < array0110.GetLength(0); i++)
            {
                for (int j = 0; j < array0110.GetLength(1); j++)
                {
                    if (i == 0 || i == (array0110.GetLength(0) - 1) || j == 0 || j == (array0110.GetLength(1) - 1))
                    {
                        content += "0   ";
                    }
                    else
                    {
                        content += "1   ";
                    }
                }
                content += "\n";
            }
            lab_Result.Text = content;
        }
        private void but_1X0_Click(object sender, EventArgs e)
        {
            int[,] array1010 = new int[8, 8];
            string content = string.Empty;
            for (int i = 0; i < array1010.GetLength(0); i++)
            {
                for (int j = 0; j < array1010.GetLength(1); j++)
                {
                    content += ((i + j) % 2 == 0) ? "1   " : "0   ";
                }
                content += "\n";
            }
            lab_Result.Text = content;
        }
        private void but_For_Click(object sender, EventArgs e)
        {
            bool FormisNumeric = tex_From.Text.All(char.IsDigit);
            bool ToisNumeric = tex_To.Text.All(char.IsDigit);
            bool StepisNumeric = tex_Step.Text.All(char.IsDigit);
            if (string.IsNullOrEmpty(tex_From.Text) || FormisNumeric == false)
            {
                MessageBox.Show("請輸入數字：From");
                tex_From.SelectAll();
                tex_From.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_To.Text) || ToisNumeric == false)
            {
                MessageBox.Show("請輸入數字：To");
                tex_To.SelectAll();
                tex_To.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_Step.Text) || StepisNumeric == false)
            {
                MessageBox.Show("請輸入數字：Step");
                tex_Step.SelectAll();
                tex_Step.Focus();
                return;
            }
            int from = int.Parse(tex_From.Text), to = int.Parse(tex_To.Text), step = int.Parse(tex_Step.Text);
            int result = 0;
            for (int i = from; i <= to; i += step)
            {
                result += i;
            }
            lab_Result.Text = from.ToString() + "到" + to.ToString() + "間隔" + (step).ToString() + "\n加總為：" + result.ToString();
        }
        private void but_While_Click(object sender, EventArgs e)
        {
            bool FormisNumeric = tex_From.Text.All(char.IsDigit);
            bool ToisNumeric = tex_To.Text.All(char.IsDigit);
            bool StepisNumeric = tex_Step.Text.All(char.IsDigit);
            if (string.IsNullOrEmpty(tex_From.Text) || FormisNumeric == false)
            {
                MessageBox.Show("請輸入數字：From");
                tex_From.SelectAll();
                tex_From.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_To.Text) || ToisNumeric == false)
            {
                MessageBox.Show("請輸入數字：To");
                tex_To.SelectAll();
                tex_To.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_Step.Text) || StepisNumeric == false)
            {
                MessageBox.Show("請輸入數字：Step");
                tex_Step.SelectAll();
                tex_Step.Focus();
                return;
            }
            int from = int.Parse(tex_From.Text), to = int.Parse(tex_To.Text), step = int.Parse(tex_Step.Text);
            int result = 0;
            int i = from;
            while (i <= to) { result += step; }
            lab_Result.Text = from.ToString() + "到" + to.ToString() + "間隔" + (step).ToString() + "\n加總為：" + result.ToString();
        }
        private void but_Do_Click(object sender, EventArgs e)
        {
            bool FormisNumeric = tex_From.Text.All(char.IsDigit);
            bool ToisNumeric = tex_To.Text.All(char.IsDigit);
            bool StepisNumeric = tex_Step.Text.All(char.IsDigit);
            if (string.IsNullOrEmpty(tex_From.Text) || FormisNumeric == false)
            {
                MessageBox.Show("請輸入數字：From");
                tex_From.SelectAll();
                tex_From.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_To.Text) || ToisNumeric == false)
            {
                MessageBox.Show("請輸入數字：To");
                tex_To.SelectAll();
                tex_To.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tex_Step.Text) || StepisNumeric == false)
            {
                MessageBox.Show("請輸入數字：Step");
                tex_Step.SelectAll();
                tex_Step.Focus();
                return;
            }
            int from = int.Parse(tex_From.Text), to = int.Parse(tex_To.Text), step = int.Parse(tex_Step.Text);
            int result = 0;
            int i = from;
            do { result += step; } while (i <= to);
            lab_Result.Text = from.ToString() + "到" + to.ToString() + "間隔" + (step).ToString() + "\n加總為：" + result.ToString();
        }
    }
}

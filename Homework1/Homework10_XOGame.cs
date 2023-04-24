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
    public partial class Homework10_XOGame : Form
    {
        Button[] but_Control = new Button[9];
        Boolean isGameOver = false;
        Boolean isO = true;
        static private int[,] WinGroup = new int[8, 3]
        {   {0,1,2}, {3,4,5}, {6,7,8}, {0,3,6}, {1,4,7}, {2,5,8}, {0,4,8}, {2,4,6}  };  //獲勝的連線組合
        public Homework10_XOGame()
        {
            InitializeComponent();
            but_Control = new Button[9] { but_0, but_1, but_2, but_3, but_4, but_5, but_6, but_7, but_8 };  //建立九宮格按鍵
            initButtons();
        }
        private void initButtons()  //設定按鈕屬性重製
        {
            isGameOver = false;
            isO = true;
            for (int i = 0; i < but_Control.Length; i++)
            {
                but_Control[i].Text = string.Empty;
                but_Control[i].BackColor = Color.LemonChiffon;
                but_Control[i].ForeColor = Color.White;
            }
        }
        private void but_0_Click(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            if (isGameOver)
            {
                MessageBox.Show("遊戲結束....請重新開始遊戲!", "遊戲結束", MessageBoxButtons.OK);
                return;
            }
            if (tmpButton.Text != string.Empty)     //按鈕內容不為空→按鈕已按過
            {
                MessageBox.Show("請選擇其他位置！", "警告", MessageBoxButtons.OK);
                return;
            }
            if (isO)
            {
                tmpButton.Text = "O";
                tmpButton.BackColor = Color.LightBlue;
            }
            else
            {
                tmpButton.Text = "X";
                tmpButton.BackColor = Color.LightCoral;
            }
            isO = !isO;

            bool[] GameStatus = ChechWinGroup(but_Control);
            isGameOver = GameStatus[1];

            //獲勝檢定
            if (GameStatus[0])
            {
                DialogResult dr = MessageBox.Show(tmpButton.Text + "方獲勝，\r\n重新開始遊戲。", "勝負已分", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    initButtons();
                return;
            }
            //平手檢定
            if (GameStatus[1])
            {
                DialogResult dr = MessageBox.Show("平手！\r\n重新開始遊戲。", "勝負未分", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    initButtons();
                return;
            }
        }
        private void but_1_Click(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            if (isGameOver)
            {
                MessageBox.Show("遊戲結束....請重新開始遊戲!", "遊戲結束", MessageBoxButtons.OK);
                return;
            }
            if (tmpButton.Text != string.Empty)
            {
                MessageBox.Show("請選擇其他位置！", "警告", MessageBoxButtons.OK);
                return;
            }
            if (isO)
            {
                tmpButton.Text = "O";
                tmpButton.BackColor = Color.LightBlue;
            }
            else
            {
                tmpButton.Text = "X";
                tmpButton.BackColor = Color.LightCoral;
            }
            isO = !isO;
            bool[] GameStatus = ChechWinGroup(but_Control);
            isGameOver = GameStatus[1];
            if (GameStatus[0])
            {
                DialogResult dr = MessageBox.Show(tmpButton.Text + "方獲勝，\r\n重新開始遊戲。", "勝負已分", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    initButtons();
                return;
            }
            if (GameStatus[1])
            {
                DialogResult dr = MessageBox.Show("平手！\r\n重新開始遊戲。", "勝負未分", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    initButtons();
                return;
            }
        }
        private void but_2_Click(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            if (isGameOver)
            {
                MessageBox.Show("遊戲結束....請重新開始遊戲!", "遊戲結束", MessageBoxButtons.OK);
                return;
            }
            if (tmpButton.Text != string.Empty)
            {
                MessageBox.Show("請選擇其他位置！", "警告", MessageBoxButtons.OK);
                return;
            }
            if (isO)
            {
                tmpButton.Text = "O";
                tmpButton.BackColor = Color.LightBlue;
            }
            else
            {
                tmpButton.Text = "X";
                tmpButton.BackColor = Color.LightCoral;
            }
            isO = !isO;
            bool[] GameStatus = ChechWinGroup(but_Control);
            isGameOver = GameStatus[1];
            if (GameStatus[0])
            {
                DialogResult dr = MessageBox.Show(tmpButton.Text + "方獲勝，\r\n重新開始遊戲。", "勝負已分", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    initButtons();
                return;
            }
            if (GameStatus[1])
            {
                DialogResult dr = MessageBox.Show("平手！\r\n重新開始遊戲。", "勝負未分", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    initButtons();
                return;
            }
        }
        private void but_3_Click(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            if (isGameOver)
            {
                MessageBox.Show("遊戲結束....請重新開始遊戲!", "遊戲結束", MessageBoxButtons.OK);
                return;
            }
            if (tmpButton.Text != string.Empty)
            {
                MessageBox.Show("請選擇其他位置！", "警告", MessageBoxButtons.OK);
                return;
            }
            if (isO)
            {
                tmpButton.Text = "O";
                tmpButton.BackColor = Color.LightBlue;
            }
            else
            {
                tmpButton.Text = "X";
                tmpButton.BackColor = Color.LightCoral;
            }
            isO = !isO;
            bool[] GameStatus = ChechWinGroup(but_Control);
            isGameOver = GameStatus[1];
            if (GameStatus[0])
            {
                DialogResult dr = MessageBox.Show(tmpButton.Text + "方獲勝，\r\n重新開始遊戲。", "勝負已分", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    initButtons();
                return;
            }
            if (GameStatus[1])
            {
                DialogResult dr = MessageBox.Show("平手！\r\n重新開始遊戲。", "勝負未分", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    initButtons();
                return;
            }
        }
        private void but_4_Click(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            if (isGameOver)
            {
                MessageBox.Show("遊戲結束....請重新開始遊戲!", "遊戲結束", MessageBoxButtons.OK);
                return;
            }
            if (tmpButton.Text != string.Empty)
            {
                MessageBox.Show("請選擇其他位置！", "警告", MessageBoxButtons.OK);
                return;
            }
            if (isO)
            {
                tmpButton.Text = "O";
                tmpButton.BackColor = Color.LightBlue;
            }
            else
            {
                tmpButton.Text = "X";
                tmpButton.BackColor = Color.LightCoral;
            }
            isO = !isO;
            bool[] GameStatus = ChechWinGroup(but_Control);
            isGameOver = GameStatus[1];
            if (GameStatus[0])
            {
                DialogResult dr = MessageBox.Show(tmpButton.Text + "方獲勝，\r\n重新開始遊戲。", "勝負已分", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    initButtons();
                return;
            }
            if (GameStatus[1])
            {
                DialogResult dr = MessageBox.Show("平手！\r\n重新開始遊戲。", "勝負未分", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    initButtons();
                return;
            }
        }
        private void but_5_Click(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            if (isGameOver)
            {
                MessageBox.Show("遊戲結束....請重新開始遊戲!", "遊戲結束", MessageBoxButtons.OK);
                return;
            }
            if (tmpButton.Text != string.Empty)
            {
                MessageBox.Show("請選擇其他位置！", "警告", MessageBoxButtons.OK);
                return;
            }
            if (isO)
            {
                tmpButton.Text = "O";
                tmpButton.BackColor = Color.LightBlue;
            }
            else
            {
                tmpButton.Text = "X";
                tmpButton.BackColor = Color.LightCoral;
            }
            isO = !isO;
            bool[] GameStatus = ChechWinGroup(but_Control);
            isGameOver = GameStatus[1];
            if (GameStatus[0])
            {
                DialogResult dr = MessageBox.Show(tmpButton.Text + "方獲勝，\r\n重新開始遊戲。", "勝負已分", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    initButtons();
                return;
            }
            if (GameStatus[1])
            {
                DialogResult dr = MessageBox.Show("平手！\r\n重新開始遊戲。", "勝負未分", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    initButtons();
                return;
            }
        }
        private void but_6_Click(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            if (isGameOver)
            {
                MessageBox.Show("遊戲結束....請重新開始遊戲!", "遊戲結束", MessageBoxButtons.OK);
                return;
            }
            if (tmpButton.Text != string.Empty)
            {
                MessageBox.Show("請選擇其他位置！", "警告", MessageBoxButtons.OK);
                return;
            }
            if (isO)
            {
                tmpButton.Text = "O";
                tmpButton.BackColor = Color.LightBlue;
            }
            else
            {
                tmpButton.Text = "X";
                tmpButton.BackColor = Color.LightCoral;
            }
            isO = !isO;
            bool[] GameStatus = ChechWinGroup(but_Control);
            isGameOver = GameStatus[1];
            if (GameStatus[0])
            {
                DialogResult dr = MessageBox.Show(tmpButton.Text + "方獲勝，\r\n重新開始遊戲。", "勝負已分", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    initButtons();
                return;
            }
            if (GameStatus[1])
            {
                DialogResult dr = MessageBox.Show("平手！\r\n重新開始遊戲。", "勝負未分", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    initButtons();
                return;
            }
        }
        private void but_7_Click(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            if (isGameOver)
            {
                MessageBox.Show("遊戲結束....請重新開始遊戲!", "遊戲結束", MessageBoxButtons.OK);
                return;
            }
            if (tmpButton.Text != string.Empty)
            {
                MessageBox.Show("請選擇其他位置！", "警告", MessageBoxButtons.OK);
                return;
            }
            if (isO)
            {
                tmpButton.Text = "O";
                tmpButton.BackColor = Color.LightBlue;
            }
            else
            {
                tmpButton.Text = "X";
                tmpButton.BackColor = Color.LightCoral;
            }
            isO = !isO;
            bool[] GameStatus = ChechWinGroup(but_Control);
            isGameOver = GameStatus[1];
            if (GameStatus[0])
            {
                DialogResult dr = MessageBox.Show(tmpButton.Text + "方獲勝，\r\n重新開始遊戲。", "勝負已分", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    initButtons();
                return;
            }
            if (GameStatus[1])
            {
                DialogResult dr = MessageBox.Show("平手！\r\n重新開始遊戲。", "勝負未分", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    initButtons();
                return;
            }
        }
        private void but_8_Click(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            if (isGameOver)
            {
                MessageBox.Show("遊戲結束....請重新開始遊戲!", "遊戲結束", MessageBoxButtons.OK);
                return;
            }
            if (tmpButton.Text != string.Empty)
            {
                MessageBox.Show("請選擇其他位置！", "警告", MessageBoxButtons.OK);
                return;
            }
            if (isO)
            {
                tmpButton.Text = "O";
                tmpButton.BackColor = Color.LightBlue;
            }
            else
            {
                tmpButton.Text = "X";
                tmpButton.BackColor = Color.LightCoral;
            }
            isO = !isO;
            bool[] GameStatus = ChechWinGroup(but_Control);
            isGameOver = GameStatus[1];
            if (GameStatus[0])
            {
                DialogResult dr = MessageBox.Show(tmpButton.Text + "方獲勝，\r\n重新開始遊戲。", "勝負已分", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    initButtons();
                return;
            }
            if (GameStatus[1])
            {
                DialogResult dr = MessageBox.Show("平手！\r\n重新開始遊戲。", "勝負未分", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                    initButtons();
                return;
            }
        }
        private bool[] ChechWinGroup(Button[] myControls)   //檢定是否連線
        {
            bool[] GameWinOver = new bool[2] { false, false };
            int butIsUse = 1;
            for (int i = 0; i < WinGroup.GetLength(0); i++)
            {
                int a = WinGroup[i, 0];     //前面設定的陣列(成功連線的情境)
                int b = WinGroup[i, 1];
                int c = WinGroup[i, 2];
                Button b1 = myControls[a];
                Button b2 = myControls[b];
                Button b3 = myControls[c];

                if (b1.Text == "" || b2.Text == "" || b3.Text == "")    //未連成線，繼續執行
                    continue;
                if (b1.Text == b2.Text && b2.Text == b3.Text)    //成功連線
                {
                    b1.BackColor = b2.BackColor = b3.BackColor = Color.DarkRed;
                    b1.ForeColor = b2.ForeColor = b3.ForeColor = Color.White;
                    GameWinOver = new bool[2] { true, true };
                    break;
                }
                if (myControls[i].Text != "")   //已無未選取的格子
                {
                    butIsUse++;
                    if (butIsUse == 9)
                        GameWinOver[1] = true;
                }
            }
            return GameWinOver;
        }
        private void but_Restart_Click(object sender, EventArgs e)
        {
            initButtons();
        }
        private void but_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Homework10_XOGame_KeyDown(object sender, KeyEventArgs e)   //須將KeyPreview屬性設置為True，不然按鍵會進行輸入
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.R)
            {
                initButtons();
            }
        }
    }
}

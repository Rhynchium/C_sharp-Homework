using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Homework1.Homework_Final_Guess_type;

namespace Homework1
{
    public partial class Homework_Final_Guess : Form
    {
        public Homework_Final_Guess()
        {
            InitializeComponent();
        }
        public delegate void SetTextValueCallback(string returnto);
        public SetTextValueCallback SetTextValue;
        int answer;
        private void Homework_Final_Guess_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            answer = random.Next(1, 100);
        }
        private void but_ShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The answer is " + answer.ToString() + ".");
        }
        private void but_Guess_Click(object sender, EventArgs e)
        {
            Homework_Final_Guess_type guesstype = new Homework_Final_Guess_type(answer);
            guesstype.ReturnmessageCallback += new Homework_Final_Guess_type.ReturnMessage(this.SetReturnmessageCallback);
            guesstype.ShowDialog();
            Homework_Final_Guess_Load(sender, e);
        }
        private void SetReturnmessageCallback(string returnto)
        {
            lab_Information.Text = returnto;
        }
    }
}

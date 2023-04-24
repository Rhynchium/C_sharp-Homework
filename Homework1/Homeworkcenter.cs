using Homework;
using Homework1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Homework
{
    public partial class Homeworkcenter : Form
    {
        public Homeworkcenter()
        {
            InitializeComponent();
        }
        private void Tohomework1(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework1 link1 = new Homework1();
            link1.TopLevel = false;
            link1.Parent = this;
            link1.Show();
            splitContainer2.Panel2.Controls.Add(link1);
        }
        private void Tohomework2(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework2 link2 = new Homework2();
            link2.TopLevel = false;
            link2.Parent = this;
            link2.Show();
            splitContainer2.Panel2.Controls.Add(link2);
        }
        private void Tohomework3(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework3 link3 = new Homework3();
            link3.TopLevel = false;
            link3.Parent = this;
            link3.Show();
            splitContainer2.Panel2.Controls.Add(link3);
        }
        private void Tohomework4(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework4 link4 = new Homework4();
            link4.TopLevel = false;
            link4.Parent = this;
            link4.Show();
            splitContainer2.Panel2.Controls.Add(link4);
        }
        private void Tohomework5(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework5 link5 = new Homework5();
            link5.TopLevel = false;
            link5.Parent = this;
            link5.Show();
            splitContainer2.Panel2.Controls.Add(link5);
        }
        private void Tohomework6(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework6 link6 = new Homework6();
            link6.TopLevel = false;
            link6.Parent = this;
            link6.Show();
            splitContainer2.Panel2.Controls.Add(link6);
        }
        private void Tohomework8(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework8 link8 = new Homework8();
            link8.TopLevel = false;
            link8.Parent = this;
            link8.Show();
            splitContainer2.Panel2.Controls.Add(link8);
        }
        private void Tohomework9(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework9 link9 = new Homework9();
            link9.TopLevel = false;
            link9.Parent = this;
            link9.Show();
            splitContainer2.Panel2.Controls.Add(link9);
        }
        private void Tohomework10(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework10_XOGame link10 = new Homework10_XOGame();
            link10.TopLevel = false;
            link10.Parent = this;
            link10.Show();
            splitContainer2.Panel2.Controls.Add(link10);
        }
        private void Tohomework_ScreenServer(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework_ScreenServer linkScreenServer = new Homework_ScreenServer();
            linkScreenServer.Show();
        }
        private void Tohomework_NotePad_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework_NotePad linkNotePad = new Homework_NotePad();
            linkNotePad.Show();
        }
        private void homeworklinkPainter_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework_Painter linkPainter = new Homework_Painter();
            linkPainter.TopLevel = false;
            linkPainter.Parent = this;
            linkPainter.Show();
            splitContainer2.Panel2.Controls.Add(linkPainter);
        }
        private void homeworklinkPV_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework_PictureViewer linkPictureViewer = new Homework_PictureViewer();
            linkPictureViewer.TopLevel = false;
            linkPictureViewer.Parent = this;
            linkPictureViewer.Show();
            splitContainer2.Panel2.Controls.Add(linkPictureViewer);
        }
        private void homeworklinkGuess_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework_Final_Guess linkGuess = new Homework_Final_Guess();
            linkGuess.TopLevel = false;
            linkGuess.Parent = this;
            linkGuess.Show();
            splitContainer2.Panel2.Controls.Add(linkGuess);
        }
        private void homeworklinkAlarm_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework_Final_Alarm linkAlarm = new Homework_Final_Alarm();
            linkAlarm.TopLevel = false;
            linkAlarm.Parent = this;
            linkAlarm.Show();
            splitContainer2.Panel2.Controls.Add(linkAlarm);
        }
    }
}

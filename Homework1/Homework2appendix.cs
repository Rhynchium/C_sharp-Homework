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
    public partial class Homework2appendix : Form       //類別名稱有時會根據某種東西取得跟想的不一樣
    {
        public Homework2appendix()
        {
            InitializeComponent();
        }
        public Homework2appendix(string loan, string yearduration, string yearratio, string mmoney, string tmoney)  //public [表單](資料來源字串(對應順序))
        {
            InitializeComponent();
            Outputloan.Text = loan;     //[欲變更label].Text = value;
            Outputduration.Text = yearduration;
            Outputratio.Text = yearratio;
            OutputPMT.Text = mmoney;
            Outputtotal.Text = tmoney;
        }
    }
}

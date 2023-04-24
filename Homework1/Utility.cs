using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class MyClass  //將存取修飾詞自預設internal改為public以供其他專案讀取
            {
        void Method01()  //給予不同存取修飾詞，測試跨類別使用效果
        {
            MessageBox.Show("defult01");
        }
        private void Method02()  //限制該類別下方可使用
        {
            MessageBox.Show("private02");
        }
        internal void Method03()  //限制同一專案下跨類別
        {
            MessageBox.Show("internal03");
        }
        public void Method04()   //無限制跨類別
        {
            MessageBox.Show("public04");
        }

        public void Method05()   //將複數方法封存於05，於其他指令同時使用
        {
            Method01();
            Method02(); 
            Method03(); 
            Method04();
        }
    }
}

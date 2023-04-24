using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Homework.HomeworkUtility;

namespace Homework
{
    public partial class Homework3 : Form
    {
        public Homework3()
        {
            InitializeComponent();
        }

        HW3MenuList menulist = new HW3MenuList();
        public void butBear_Click(object sender, EventArgs e)
        {
            menulist.Beer += 120;
            menulist.Beerunit += 1;
            tex_Shoplist.Text = menulist.Beerunit.ToString();
            tex_Shoplist.Text = menulist.Beer.ToString();
            tex_Totalprice.Text = menulist.Beer.ToString();
        }
        private void butTequila_Click(object sender, EventArgs e)
        {
            menulist.Tequila += 180;
            menulist.Tequilaunit += 1;
            tex_Shoplist.Text = menulist.Tequilaunit.ToString();
            tex_Shoplist.Text = menulist.Tequila.ToString();
            tex_Totalprice.Text = menulist.Tequila.ToString();
        }
        private void butWhisky_Click(object sender, EventArgs e)
        {
            menulist.Whisky += 350;
            menulist.Whiskyunit += 1;
            tex_Shoplist.Text = menulist.Whiskyunit.ToString();
            tex_Shoplist.Text = menulist.Whisky.ToString();
            tex_Totalprice.Text = menulist.Whisky.ToString();
        }
        private void butWine_Click(object sender, EventArgs e)
        {
            menulist.Wine += 320;
            menulist.Wineunit += 1;
            tex_Shoplist.Text = menulist.Wineunit.ToString();
            tex_Shoplist.Text = menulist.Wine.ToString();
            tex_Totalprice.Text = menulist.Wine.ToString();
        }
        private void tex_Shoplist_TextChanged(object sender, EventArgs e)
        {
            String AllOrder;
            if (menulist.Beerunit + menulist.Tequilaunit + menulist.Whiskyunit + menulist.Wineunit == 0)
            { AllOrder = "尚未點餐"; }
            else
            {
                String ShowBeer;
                if (menulist.Beerunit >= 1)
                { ShowBeer = "啤酒 Beer " + menulist.Beerunit + "杯，共" + menulist.Beer + "NT$" + Environment.NewLine; }
                else { ShowBeer = String.Empty; }

                String ShowTequila;
                if (menulist.Tequilaunit >= 1)
                { ShowTequila = "龍舌蘭 Tequila " + menulist.Tequilaunit + "瓶，共" + menulist.Tequila + "NT$" + Environment.NewLine; }
                else { ShowTequila = String.Empty; }

                String ShowWhisky;
                if (menulist.Whiskyunit >= 1)
                { ShowWhisky = "威士忌 Whisky " + menulist.Whiskyunit + "瓶，共" + menulist.Whisky + "NT$" + Environment.NewLine; }
                else { ShowWhisky = String.Empty; }

                String ShowWine;
                if (menulist.Wineunit >= 1)
                { ShowWine = "紅酒 Wine " + menulist.Wineunit + "瓶，共" + menulist.Wine + "NT$"; }
                else { ShowWine = String.Empty; }

                AllOrder = ShowBeer + ShowTequila + ShowWhisky + ShowWine;
            }
            tex_Shoplist.Text = AllOrder;
        }
        private void tex_Totalprice_TextChanged(object sender, EventArgs e)
        {
            int Totalprice = menulist.Beer + menulist.Tequila + menulist.Whisky + menulist.Wine;
            tex_Totalprice.Text = Totalprice + " NT$";
        }
        private void but_bycash_Click(object sender, EventArgs e)
        {
            int Totalprice = menulist.Beer + menulist.Tequila + menulist.Whisky + menulist.Wine;
            if (Totalprice == 0)
            { MessageBox.Show("尚未點餐！"); }
            else
            { MessageBox.Show("總金額：" + Totalprice + "NT$"); }
        }
        private void but_bycard_Click(object sender, EventArgs e)
        {
            int Totalprice = menulist.Beer + menulist.Tequila + menulist.Whisky + menulist.Wine;
            double Discountprice = Totalprice * 0.9;
            var intDiscountprice = Math.Round(Discountprice, 0);
            if (Totalprice == 0)
            { MessageBox.Show("尚未點餐！"); }
            else
            { MessageBox.Show("總金額：" + Totalprice + "NT$" + Environment.NewLine + "折扣後金額：" + intDiscountprice + "NT$"); }
        }
        private void but_cleanlist_Click(object sender, EventArgs e)
        {
            menulist.Beer = 0;            //指定數值歸零
            menulist.Tequila = 0;
            menulist.Whisky = 0;
            menulist.Wine = 0;
            menulist.Beerunit = 0;
            menulist.Tequilaunit = 0;
            menulist.Whiskyunit = 0;
            menulist.Wineunit = 0;
            tex_Totalprice.Text = "0 NT$";
            tex_Shoplist.Text = String.Empty;
        }
        //TextBox tb = text_reference;        //[功能名稱] [指定實體] = [目標功能塊]
    }
}

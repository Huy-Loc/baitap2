using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bn_tiep_Click(object sender, EventArgs e)
        {
            Txt_Nhap.Text = "";
            Txt_Dayvuanhap.Text = "";
            Txt_Tong.Text = Tongdayso.ToString();
            Txt_TC.Text = TC.ToString();
            Txt_TL.Text = TL.ToString();
        }
        int TC = 0, TL = 0, Tongdayso = 0;
        
        private void Btn_Nhap_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(Txt_Nhap.Text);
            Txt_Dayvuanhap.Text += x + ",";
            if (x % 2 == 0)
            {
                TC += x;
                
            }
            else
            {
                TL += x;
                
            }
            Tongdayso += x;
            

            Txt_Nhap.Clear();

        }

       
    }
}

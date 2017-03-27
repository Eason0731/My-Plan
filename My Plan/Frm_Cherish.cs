using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_Plan
{
    public partial class Frm_Cherish : Form
    {
        public Frm_Cherish()
        {
            InitializeComponent();
            
        }

        private void Frm_Cherish_Load(object sender, EventArgs e)
        {
            lbl_title.Text = "在AutoDesk工作的日子";
            lbl_startdate.Text = "入职日期：";
            lbl_start.Text = "2015年8月24日";
            lbl_enddate.Text = "离职日期：";
            lbl_end.Text = "2017年2月17日";
            lbl_total.Text = "一共在AutoDesk奋斗了";
            lbl_day.Text = "天";
            lbl_comeon.Text = "骚年，不要气馁，尽管因为自己的过失造成了后果，相信未来的一切会更好！";

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Select frm1 = new Frm_Select();
            frm1.ShowDialog();
        }
    }
}

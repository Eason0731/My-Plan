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
    public partial class Frm_AutoDesk : Form
    {
        public Frm_AutoDesk()
        {
            InitializeComponent();
            
        }

        private void Frm_Cherish_Load(object sender, EventArgs e)
        {
            CalDate();
            lbl_title.Text = "在AutoDesk工作的日子";
            lbl_startdate.Text = "入职日期：";
            lbl_start.Text = "2015年8月24日";
            lbl_enddate.Text = "离职日期：";
            lbl_end.Text = "2017年2月17日";
            lbl_type.Text = "工作性质：";
            lbl_worktype.Text = "外派";
            lbl_qyxz.Text = "所在企业性质:";
            lbl_gsxz.Text = "外企";
            lbl_dz.Text = "外企工作地址：";
            lbl_wqdz.Text = "浦电路399号陆家嘴软件园7号楼1层";
            lbl_wpgs.Text = "所属外派公司：";
            lbl_wpgsmc.Text = "遨为（上海）数字技术有限公司";
            lbl_wpgsldz.Text = "外派公司原地址：";
            lbl_gsldz.Text = "逸仙路3000号6号楼105-2室";
            lbl_wpgsdz.Text = "外派公司新地址：";
            lbl_gsdz.Text = "沪太路1895弄51号诺诚1895创意园1号楼2层";
            lbl_total.Text = "一共在AutoDesk奋斗了";
            lbl_day.Text = "天";
            lbl_summarize.Text = "毕业之后的第一份正式工作就是入职知名外企AutoDesk，工作氛围不错，同事都很谦虚且相处的比较融洽，都以探讨工作和技术为主，也学习到一定的知识，并取得了一定的提高，是个学习技术知识和做事方式的好公司！";
            lbl_comeon.Text = "骚年，不要气馁，尽管因为自己的过失造成了后果，相信未来的一切会更好！Everything will be OK!";

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Work frm1 = new Frm_Work();
            frm1.Show();
        }

        public void CalDate()
        {
            //判断时间的小函数
            DateTime startDate = new DateTime(2015, 8, 24);
            DateTime endDate = new DateTime(2017, 2, 17);
            // Difference in days, hours, and minutes. 
            TimeSpan ts = endDate - startDate;
            // Difference in days. 
            int differenceInDays = ts.Days;
            lbl_count.Text = differenceInDays.ToString();
      
            
        }
    }
}

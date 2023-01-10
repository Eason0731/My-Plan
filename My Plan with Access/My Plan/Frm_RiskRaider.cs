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
    public partial class Frm_RiskRaider : Form
    {
        public Frm_RiskRaider()
        {
            InitializeComponent();
        }

        private void Frm_RiskRaider_Load(object sender, EventArgs e)
        {
            CalDate();
            lbl_title.Text = "在斯睿德工作的日子";
            lbl_startdate.Text = "入职日期：";
            lbl_start.Text = "2014年9月1日";
            lbl_enddate.Text = "离职日期：";
            lbl_end.Text = "2015年6月26日";
            lbl_type.Text = "工作性质：";
            lbl_worktype.Text = "实习（毕业后可转正式编制，但选择离职去外企）";
            lbl_qyxz.Text = "所在企业性质:";
            lbl_gsxz.Text = "私企";
            lbl_dz.Text = "私企旧工作地址：";
            lbl_sqdz.Text = "哈雷路1133号凯信国际广场1号楼506室";
            lbl_newdz.Text = "私企新工作地址：";
            lbl_newsqdz.Text = "盛夏路666号5幢7楼01单元";
            lbl_total.Text = "一共在斯睿德奋斗了";
            lbl_day.Text = "天";
            lbl_summarize.Text = "大四实习期间找的一份工作，与当时班里其他3位同学一起入职工作，后期有2位离职，与GYT最后一起工作了一段时间，并想与其有过发展的请求，但未成功，不过没关系，也算是有过一段这样的回忆了。总体而言是一家上升期的创业公司，还是能够学到一定的技术知识，与其他同事相处不错，至今还与部分该公司前同事保持联系，希望GYT同学在那边一切都好，哈哈！";
      
        }

        public void CalDate()
        {
            //判断时间的小函数
            DateTime startDate = new DateTime(2014, 9, 1);
            DateTime endDate = new DateTime(2015, 6, 26);
            // Difference in days, hours, and minutes. 
            TimeSpan ts = endDate - startDate;
            // Difference in days. 
            int differenceInDays = ts.Days;
            lbl_count.Text = differenceInDays.ToString();


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Work frm1 = new Frm_Work();
            frm1.Show();
        }
    }
}

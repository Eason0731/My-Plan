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
    public partial class Frm_ChinaTelecom : Form
    {
        public Frm_ChinaTelecom()
        {
            InitializeComponent();
        }

        private void Frm_ChinaTelecom_Load(object sender, EventArgs e)
        {
            CalDate();
            lbl_title.Text = "在中国电信工作的日子";
            lbl_startdate.Text = "入职日期：";
            lbl_start.Text = "2017年4月17日";
            lbl_enddate.Text = "打算跳槽日期：";
            lbl_end.Text = "2019年2月11日";
            lbl_type.Text = "工作性质:";
            lbl_worktype.Text = "外派";
            lbl_wpgs.Text = "所属外派公司:";
            lbl_wpgsmc.Text = "上海埃帕信息科技有限公司";
            lbl_total.Text = "目前在中国电信工作了";
            lbl_day.Text = "天";
            lbl_leaveday.Text = "天";
            lbl_leavetime.Text = "距离打算跳槽日期还有";
            lbl_summarize.Text = "不同于上一家工作的外企AutoDesk，国企中国电信工作氛围很宽松，上班9点，下班5点的工作时间。外加两个小时的午休，基本上除了业务知识，也学不到任何技术方面的新知识。闲暇无事的情况居多，做事比较佛系，完成了就行。同事相比上一家没有上进心，都不太关注工作，而都更多关注玩和小便宜上，不和我的胃口，不过相处还算融洽。在闲暇时只能靠自学技术，主要学Python，那就在接下来需要跳槽的日期这段时间，继续巩固学习Python,Python Selenium和Django以及其他用的到的知识，升级自己的技能，早日逃出无所事事的国企，希望能够重回外企展现自己的能力！并且力争以后能坐上经理的位置！";
          
        }

        public void CalDate()
        {
            //判断时间的小函数
            DateTime Today = DateTime.Now; //CurrentDate
            DateTime startDate = new DateTime(2017, 4, 17);
            DateTime leaveDate = new DateTime(2019, 2, 11);
            // Difference in days, hours, and minutes. 
            TimeSpan ts = Today - startDate;
            TimeSpan ts2 = leaveDate - Today;
            // Difference in days. 
            int differenceInDays = ts.Days;
            int differenceInDays2 = ts2.Days;
            lbl_count.Text = differenceInDays.ToString();
            lbl_leavecount.Text = differenceInDays2.ToString();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Work frm1 = new Frm_Work();
            frm1.Show();
        }
    }
}

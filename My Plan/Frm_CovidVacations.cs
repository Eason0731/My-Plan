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
    public partial class Frm_CovidVacations : Form
    {
        public Frm_CovidVacations()
        {
            InitializeComponent();
        }
        
        private void Frm_CovidVacations_Load(object sender, EventArgs e)
        {
            CalDate();
            lbl_title.Text = "2020年初受新冠疫情影响在家办公和休假情况统计";

            lbl_startdate.Text = "公司开始休假日期:";
            lbl_start.Text = "2020年1月23日（除夕）";

            lbl_actualstartdate.Text = "实际开始休假日期:";
            lbl_actualstart.Text = "2020年1月21日（大年廿八）";

            lbl_workathome.Text = "在家远程办公开始日期:";
            lbl_workathomedate.Text = "2020年2月12日（正月十九）";

            lbl_enddate.Text = "休假和在家远程办公结束日期:";
            lbl_end.Text = "2020年3月15日（二月廿二）";

            lbl_workathometotal.Text = "在家办公天数:";
            lbl_total.Text = "公司休息天数:";
            lbl_actualtotal.Text = "实际休息天数:";

            label1.Text = "天";
            label2.Text = "天";
            label3.Text = "天";

            lbl_summarize.Text = "1.在家办公期间,开启了远程VPN登录权限,但基本上没有什么事情,且事情沈健都会做掉,不用操心,之后回去上班了照旧如此;电信公司也不通知什么时候上班,像死人一样;老曹,李栋什么都不懂,无视他们就好!" +
            Environment.NewLine + "2.在家休息期间,学会烹饪了易上手的家常菜,解锁烧菜技能!" + //Environment.NewLine实现TextBox换行
            Environment.NewLine + "3.在家休息期间,复习了Java和Python配合Selenium的浏览器获取方法,以及学习了接口测试及其脚本撰写!" +
            Environment.NewLine + "4.在家休息期间,更换了VirtualBox作为虚拟机使用软件,并安装了XP,Win7,Win10,Linux(Cent OS)和Mac OS X系统,且联想3110打印机可以在XP虚拟机中正常运行!" +
            Environment.NewLine + "5.在家休息期间,将私家车加了一次100元的95号汽油,且动了3次车,车况一切正常!" +
            Environment.NewLine + "6.在家休息期间,重新安装了Windows 8.1系统在一体机上,排查了问题后保证rFactor游戏可以在该系统上正常运行!" +
            Environment.NewLine + "7.等待此次疫情过后,再重新开启跳槽之旅,最早可能在2020年6月,最晚可能在2021年春节,一切以安全健康为准!";
      
        }

        public void CalDate()
        {
            //判断时间的小函数
            DateTime Actual_Start_Date = new DateTime(2020, 1, 21);
            DateTime Company_Start_Date = new DateTime(2020, 1, 23);
            DateTime Work_At_Home_Start_Date = new DateTime(2020, 2, 12);
            DateTime End_Date = new DateTime(2020, 3, 15);
            // Difference in days, hours, and minutes. 
            TimeSpan ts = End_Date - Work_At_Home_Start_Date;
            TimeSpan ts2 = End_Date - Company_Start_Date;
            TimeSpan ts3 = End_Date - Actual_Start_Date; ;
            // Difference in days. 
            int differenceInDays = ts.Days;
            int differenceInDays2 = ts2.Days;
            int differenceInDays3 = ts3.Days;
            lbl_workathomecount.Text = differenceInDays.ToString();
            lbl_count.Text = differenceInDays2.ToString();
            lbl_actualcount.Text = differenceInDays3.ToString();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_ChinaTelecom frm1 = new Frm_ChinaTelecom();
            frm1.Show();
        }

    }
}

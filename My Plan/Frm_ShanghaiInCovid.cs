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
    public partial class Frm_ShanghaiInCovid : Form
    {
        public Frm_ShanghaiInCovid()
        {
            InitializeComponent();
        }

        private void Frm_ShanghaiInCovid_Load(object sender, EventArgs e)
        {
            CalDate();
            lbl_title.Text = "2022年因新冠疫情导致上海封城而在家办公和休假情况统计";

            lbl_firststartdate.Text = "第一次小区封闭时间:";
            lbl_firststart.Text = "2022年3月9日";

            lbl_firstenddate.Text = "第一次小区解封时间:";
            lbl_firstend.Text = "2022年3月11日";

            lbl_workathome.Text = "第二次小区解封时间即在家远程办公开始日期:";
            lbl_workathomedate.Text = "2022年3月24日";

            lbl_secondenddate.Text = "第二次小区解封即全上海解封时间:";
            lbl_secondend.Text = "2022年6月1日";

            lbl_workenddate.Text = "在家休息和远程办公结束日期:";
            lbl_workend.Text = "2022年8月7日";

            lbl_firstclosetime.Text = "第一次小区封闭时间:";
            lbl_secondclosetime.Text = "第二次小区封闭时间:";
            lbl_workathometime.Text = "实际休息和在家远程办公天数:";

            label1.Text = "天";
            label2.Text = "天";
            label3.Text = "天";

            lbl_summarize.Text = "1.在家办公期间,与上次2020年情况不同,不需要做测试工作了,而是重新做回了需求统计工作。在每周五远程通过VPN登陆,整理出下周需要统计的需求并登陆到电信内部OA系统,查询需求对口负责人,在下周四整理好邮件发送给相关领导和负责人" +
            Environment.NewLine + "2.在家休息期间,于4月7日新冠抗原自测呈阳性,6天后的4月13日再次进行抗原呈阴性,躲过了一劫,期间有核酸复测,并未告知核酸阳性。在4月13日之后至今无论是抗原自测还是核酸,均为阴性！" +
            Environment.NewLine + "3.在家休息期间,于4月22日在重装系统后发现联想一体机出现故障,并于6月12日在京东商城上购买了电脑配件于6月15日组装完毕,但在6月28日出现电源问题,并又在7月20日重新安装修复完毕,至今未发现又有问题,还需持续观察中！" +
            Environment.NewLine + "4.在家休息期间,于6月28日预约去了奉贤海湾寝园,去看望老爸并给他上香。本因在2022年4月5日清明期间去探望,但因那时候在封城期间无法出门,所以改到该日去" +
            Environment.NewLine + "5.在家休息期间,外公于6月19日晚在家摔倒不幸去世,之后三天为其操办后事并守夜,在6月24日下午到梅岭北路400弄24号1009室(外公家)进行断七守夜" +
            Environment.NewLine + "6.在家休息期间,于小区第二次封闭的日子3月24日,因25楼租户的花盆砸到了我的车的顶部,找到了该租户并赔偿得到1000元。并在7月18日送到伟闽汽车公司进行修理,于一周后的7月25日拿回,花费1000元!" +
            Environment.NewLine + "7.在家休息期间,自6月1日小区彻底解封后,开了7次车,并加了200元油费" +
            Environment.NewLine + "8.在家休息期间,给新电脑安装了微软最新的Windows 11操作系统,但总感觉该系统小Bug不断,因从Windows 10开始,微软操作系统都是由印度阿三主导开发,出现类似问题也不意外!" +
            Environment.NewLine + "9.在家休息期间,8月2日美国老巫婆佩洛西访台,于8月3日下午离开。解放军宣布8月4日至7日围台湾岛进行军事封锁演练,结果拭目以待" +
            Environment.NewLine + "10.在家休息期间,继续烹饪了易上手的家常菜!"+
            Environment.NewLine + "11.等待此次疫情过后,再重新开启跳槽之旅!"+
            Environment.NewLine + "12.出门在外,进出场所(单位,公交,地铁,商场,饭店等地方)都需要扫场所码,必须持有72小时内核酸阴性报告!超过7天不做核酸就会转为黄码,生活方式发生了重大改变!" +
            Environment.NewLine + "13.在8月7日重新回单位办公后,希望能和欣欣子(戴应欣)有更多的接触吧,发现好像有点喜欢她!" ;//Environment.NewLine实现TextBox换行
        }

        public void CalDate()
        {
            //判断时间的小函数
            DateTime First_Start_Date = new DateTime(2022, 3, 9);
            DateTime First_End_Date = new DateTime(2022, 3, 11);
            
            DateTime Work_At_Home_Start_Date = new DateTime(2022, 3, 24);
            DateTime Second_End_Date = new DateTime(2022, 6, 1);
            DateTime End_Date = new DateTime(2022, 8, 7);
            
            // Difference in days, hours, and minutes. 
            TimeSpan ts = First_End_Date - First_Start_Date;
            TimeSpan ts2 = Second_End_Date - Work_At_Home_Start_Date;
            TimeSpan ts3 = End_Date - Work_At_Home_Start_Date;
            
            // Difference in days. 
            int differenceInDays = ts.Days;
            int differenceInDays2 = ts2.Days;
            int differenceInDays3 = ts3.Days;
            
            lbl_firstclosecount.Text = differenceInDays.ToString();
            lbl_secondclosecount.Text = differenceInDays2.ToString();
            lbl_workathometimecount.Text = differenceInDays3.ToString();
            

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Plan
{
    public partial class Frm_WorkAtHome2023 : Form
    {
        public Frm_WorkAtHome2023()
        {
            InitializeComponent();
        }

        private void Frm_WorkAtHome2023_Load(object sender, EventArgs e)
        {
            CalDate();
            lbl_title.Text = "2023年因柳林分局5楼装修在家办公的情况统计";

            lbl_workathome.Text = "在家休息和远程办公开始日期:";
            lbl_workathomedate.Text = "2023年9月27日";

            lbl_workenddate.Text = "在家休息和远程办公结束日期:";
            lbl_workend.Text = "2024年2月3日";

            lbl_workathometime.Text = "实际休息和在家远程办公天数:";
            label3.Text = "天";

            lbl_summarize.Text = "1.2023年9月26日下班后就结束楼在柳林5楼的现场办公，该周前一周去了医院治疗了味觉嗅觉失灵问题，还有洗了耳朵，现在都已经恢复!" +
            Environment.NewLine + "2.到了2023.10月末，将用了6年之久的iPhone 8 Plus更换成了iPhone 15 Plus" +
            Environment.NewLine + "3.2023.10.28:本来想追求的对象,苏北扬中乡下农村土女DYX宣布结婚,目标-1,对爱情失望程度也-1,祝她婚姻一定要'幸福'啊！另外该日码头狗依靠陈戌源的一路保驾护航下，终于拿到楼无耻的冠军!" +
            Environment.NewLine + "4.2023.11初因老妈与外婆他们去外地旅游一周，所以决定与FO老朋友老总督和老鸽子在七宝老街聚餐，其他几日也坐公交车弥补了缺少的历程数据" +
            Environment.NewLine + "5.2023.12.8:多年前追求的大学同学上海南汇乡下农村土女GYT也宣布结婚,目标再-1,对爱情失望程度也再-1。让我也知道了所谓的宅女内向女慢热女一个个都是反差婊子!逐渐彻底走上反女男拳道路!也祝她婚姻一定要'幸福'啊！之后无论是DYX还是GYT及其他们的朋友需要我帮忙，能敷衍推脱，就能推脱！关我什么事！彻底和他们划清界限！" +
            Environment.NewLine + "6.2023.12.31:与FO老朋友老总督,猫头鹰和老猫继续相聚于虹口龙之梦吃火锅,饭后陪老总督去南京路步行街购买苹果手表和蓝牙耳机" +
            Environment.NewLine + "7.2024元旦：开始新游戏原神,这个游戏没有想象中那么差,可玩性还可以。类似暗黑破坏神,永劫无间结合版的二次元游戏。可以把它当作大型单机游戏玩!" +
            Environment.NewLine + "8.2024.1.2左右开始追剧上海话沪语电视剧《繁花》,拍得还可以,最后两集比较好看!约1.18结束" +
            Environment.NewLine + "9.2024.1.14:去楼园帮助舅公老邻居处理电脑问题,很快就解决了,还陪其中午出门购买长者食堂和周边生鲜超市的蔬菜,总体还算便宜,性价比挺高!" +
            Environment.NewLine + "10.2024.1.16:车子被1905室掉落的玻璃砸到导致车受损,目前已进保险且定价完毕,年后再去修理,与1905的赔偿也在协商中,希望早日解决吧!期间因为在家办公来来回回看监控调查取证也花了不少精力,也给警察提交了玻璃碎片和放大版的视频监控证据" +
            Environment.NewLine + "11.2024.1.27:与FO老朋友老总督,猫头鹰和老猫继续相聚于七宝老街,与老猫下午见面吃了油墩子,汤团,羊肉面。晚上与猫头鹰在七宝农家菜一起吃了晚餐,算是年夜饭!" +
            Environment.NewLine + "12.2024.1.29:支付宝开始楼2024龙年的集五福活动,在1.31那天三个号(爸妈我)都扫出了敬业福/万能福,且在6天后基本都完成了攒福气达到最高等级的活动,可额外平分5000万,都在2.9除夕夜开奖,希望好运!" +
            Environment.NewLine + "13.2024.2.2:与老妈去淮海中路老人和吃年夜饭,饭后还去了对面的光明邨买月饼,去了哈尔滨食品厂商店买了冰淇淋筒当零食吃" +
            Environment.NewLine + "14.2024年初将台式机电脑的杀毒软件从卡巴斯基换成楼ESET,主要原因是感觉有点占用内存,而且受俄罗斯乌克兰战争影响,查杀率开始下降,ESET也还能用,之后若将电脑内存升级为32G及以上,那么再考虑换回卡巴斯基" +
            Environment.NewLine + "15.2023年11月左右,以'电视家'为首的电视直播软件全被取缔,无法观看。替代方案:抓取了Github上其他仓库的源,必汇总到自己的仓库,随后将这些地址生成出来,并在智能电视上安装DIYP影音软件,将地址放到该APP内进行观看。另外还在电报上找到了'影视APP',也可以观看体育赛事,点播电影电视剧等在线观看!" +
            Environment.NewLine + "16.2024.2.5:阿根廷'囚王'里奥梅西因所谓身体不适拒绝在香港上场,两天后2.7在日本,在60分钟替补出场,被称为'里奥哟西'!风评彻底被逆转!C罗才是GOAT" +
            Environment.NewLine + "17.在居家办公结束后恰逢农历龙年春节,与老妈说定在春节期间年初二去外婆家,年初四去嘉定州桥老街游玩，年初六去打浦桥避风塘吃饭!今年也是我妈本命年,60岁了,这辈子如果不结婚,那么最大的任务就是把她一定要照顾好!" +
            Environment.NewLine + "18.码头狗公交卡里的余额都用完清零,接下来就用支付宝刷公交和地铁了,公交卡就当是出入柳林的门禁卡,要是以后离职了不在柳林电信分局工作,那就把它扔了!" +
            Environment.NewLine + "19.回柳林办公后,也恰逢年后,有机会还是要寻找跳槽机会！外企最佳!尽管现在经济大环境都不好,但是有机会一定也要把握住!另外,如果遇到合适的女孩,也别错过了!"+
            Environment.NewLine + "20.自从上次更新本程序以来,现在在很多政治事件，不怎么太愿意相信国内所谓粉红媒体的言辞,更喜欢去外网看，诸如X,Youtube,Reddit.甚至还用海外号码注册楼Telegram进行端到端的加密键政聊天!我相信民主!相信自由!";//Environment.NewLine实现TextBox换行

            this.lbl_summarize.Select(0, 0);
        }

        public void CalDate()
        {
            //判断时间的小函数
            DateTime Work_At_Home_Start_Date = new DateTime(2023, 9, 27);
            DateTime End_Date = new DateTime(2024, 2, 3);

            // Difference in days, hours, and minutes. 
            
            TimeSpan ts = End_Date - Work_At_Home_Start_Date;

            // Difference in days. 
            int differenceInDays = ts.Days;

            lbl_workathometimecount.Text = differenceInDays.ToString();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

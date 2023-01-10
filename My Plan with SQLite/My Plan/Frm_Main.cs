using System;
using System.Windows.Forms;

namespace My_Plan
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void choose1() 
        {

            MessageBoxButtons messButton = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("小伙子三年时间还没到呢,到时间了再来找我吧,难道是提前转正了？", "", messButton);

            if (dr == DialogResult.Yes)//如果点击“确定”按钮
            {
                MessageBoxButtons messButton1 = MessageBoxButtons.YesNo;
                DialogResult dr2 = MessageBox.Show("恭喜恭喜，那么目前有没有跳槽的打算呢？", "", messButton1);
                if (dr2 == DialogResult.Yes)//如果点击“确定”按钮
                {
                    MessageBox.Show("好吧,遵从自己的抉择,看准了再跳！");
                }
                else
                {
                    MessageBox.Show("那么就继续在AutoDesk好好做下去吧！");
                }
            }
            else
            {
                MessageBoxButtons messButton1 = MessageBoxButtons.YesNo;
                DialogResult dr2 = MessageBox.Show("那么继续等待，那么目前有没有跳槽的打算呢？", "", messButton1);
                if (dr2 == DialogResult.Yes)//如果点击“确定”按钮
                {
                    MessageBox.Show("好吧,遵从自己的抉择,看准了再跳！");
                }
                else
                {
                    MessageBox.Show("三年时间到了再来找我抉择吧！");
                }
            }
 
        }

        private void choose2() 
        {
            MessageBoxButtons messButton = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("三年时间到了,现在转入Autodesk正式员工编制了吗？", "", messButton);

            if (dr == DialogResult.Yes)//如果点击“确定”按钮
            {
                MessageBoxButtons messButton1 = MessageBoxButtons.YesNo;
                DialogResult dr2 = MessageBox.Show("恭喜恭喜，尽管转正了但现在有没有跳槽的打算呢？", "", messButton1);
                if (dr2 == DialogResult.Yes)//如果点击“确定”按钮
                {
                    MessageBox.Show("相信自己,看准了再跳！");
                }
                else
                {
                    MessageBox.Show("嗯,就在AutoDesk好好做下去吧！");
                }
            }

            else 
            {
                MessageBoxButtons messButton1 = MessageBoxButtons.YesNo;
                DialogResult dr2 = MessageBox.Show("真坑啊,三年了都没转正,那么目前有没有跳槽的打算呢？", "", messButton1);
                if (dr2 == DialogResult.Yes)//如果点击“确定”按钮
                {
                    MessageBox.Show("好吧,这几年也收获不少了,看准了再跳！");
                }
                else
                {
                    MessageBox.Show("那就继续等待转正机会吧！");
                }
            }
 
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            //判断时间的小函数
            DateTime oldDate = new DateTime(2015, 8, 24);
            DateTime newDate = DateTime.Now;
            // Difference in days, hours, and minutes. 
            TimeSpan ts = newDate - oldDate;
            // Difference in days. 
            int differenceInDays = ts.Days;
            label2.Text = "我已经在Autodesk已经工作了";
            label1.Text = differenceInDays.ToString() ;
            label4.Text = "个风风雨雨的日子";


            label3.Text = "当前时间："+ DateTime.Now.ToString();
            if( differenceInDays < 1096){ //1096为3年的天数
                choose1();
            }
            else 
            {
                MessageBox.Show("三年时间到了,进行进一步的抉择吧！");
                choose2();

            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Select frm = new Frm_Select();
            frm.Show();
        }

       

       
    }
}

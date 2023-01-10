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
    public partial class Frm_Select : Form
    {
        public Frm_Select()
        {
            InitializeComponent();
        }


        private void Frm_Select_Load(object sender, EventArgs e)
        {
            //label1.Text = "今天是";
            //label2.Text = "天";
           // lblNowDate.Text = DateTime.Now.ToLongDateString(); //ToLongDateString()会将日期输出为长日期字符输出
            //CalDate();
        }

        private void btn_choice_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Main frm1 = new Frm_Main();
            frm1.Show();
        }

        private void btn_gotoAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_AddNote frm2 = new Frm_AddNote();
            frm2.Show();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_View frm3 = new Frm_View();
            frm3.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //彻底退出程序
        }

        private void btn_viewDate_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Work frm4 = new Frm_Work();
            frm4.Show();
        }


        /*
         private void CalDate()
         {
             DateTime TargetDate = new DateTime(2018, 8, 24); //DateTime定义三年后的日期,2018年8月24日
             DateTime Today = DateTime.Now; //获取当前日期
             TimeSpan delta = TargetDate - Today; //实例化TimeSpan类型对日期做一个计算
             int deltaDays = delta.Days; //将其转化为int类型
             if (deltaDays > 0) //距离三年期限还有多少时间的计算
             {
                 lblCustom.Text = "距离三年期限还有";
                 lblDeltaDays.Text = deltaDays.ToString();
             }

             else { //三年期限过去的时间计算
                 //TimeSpan delta2 =  Today - TargetDate;
                 //int deltaDays2 = delta2.Days;
                 deltaDays = 0 - deltaDays;
                 lblCustom.Text = "三年期限已经过去";
                 lblDeltaDays.Text = deltaDays.ToString();
             }
         */



    }
}

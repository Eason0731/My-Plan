using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace My_Plan
{
    public partial class Frm_Edit : Form
    {
        DataRow row_Frm_Edit;
        string Conn = "provider=microsoft.jet.oledb.4.0;data source=AutoDesk.mdb";
        String idnumber;

       
        public Frm_Edit(DataRow row_Edit)
        {
            InitializeComponent();
            row_Frm_Edit = row_Edit;
            idnumber = row_Frm_Edit["ID"].ToString(); //获取当前id值并赋给变量idnumber
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            OleDbConnection myCon = new OleDbConnection(Conn); //连接到数据库
            myCon.Open();

            string Title = "";
            string Content = "";
            
            if (txt标题.Text == "" || txt内容.Text == "" || cmb分类.Text == "")
            {
                MessageBox.Show("标题,内容或分类中有空值,空的笔记没有任何意义,是不会更新的！");
            }
            
            else
            {
            

                if (txt标题.Text.Contains("'"))
                {
                    Title = txt标题.Text.Replace("'", "''");//将单引号被替换为两个单引号的结果，存到临时变量中，该临时变量作为更新内容。每次遇到有单引号的字符，则需要通过该方法去替换
                }

                else
                {
                    Title = txt标题.Text; //若字符中不包含单引号，则还是按照文本框输入的字符进入更新
                }

                if (txt内容.Text.Contains("'"))
                {
                    Content = txt内容.Text.Replace("'", "''"); //将单引号被替换为两个单引号的结果，存到临时变量中，该临时变量作为更新内容。每次遇到有单引号的字符，则需要通过该方法去替换
                }

                else
                {
                    Content = txt内容.Text; //若字符中不包含单引号，则还是按照文本框输入的字符进入更新
                }


                // 将txt内容.Text读取到的包含单引号的值，替换为两个单引号字符。例如'r',会转成r。否则不转换无法写进数据库。因为不转换就是''r''包含单引号的字符无法写入数据库
                // 转换前：insert into [Note] ([title],[content],[datetime]) values ('111' , 'files = open (r‘D\Abc\1.txt’,'r')', '2016/9/10')
                // 转换后：insert into [Note] ([title],[content],[datetime]) values ('GFFG' , 'files = open (r‘D\Abc\1.txt’,''r'')', '2016/9/10')
                // 显示的结果还是会显示为一个单引号的值

                string updateStr = " update [Note] set [title] ='" + Title + "',[content] ='" + Content + "', [datetime] = '" + dateTimePicker1.Value.ToShortDateString() + "', [class] = '"+ cmb分类.Text+"' where ID=" + idnumber + "";
                OleDbCommand myCmd = new OleDbCommand(updateStr, myCon);
                myCmd.ExecuteNonQuery();
                myCon.Close();
                MessageBox.Show("更新笔记成功！");
            }
        }

        private void txtStatus_KeyDown(object sender, KeyEventArgs e) //全选CTRL + A 的方法
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Edit_Load(object sender, EventArgs e)
        {
            this.Text = txt标题.Text;
        }
    }
}

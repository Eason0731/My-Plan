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
    public partial class Frm_AddNote : Form
    {
       

        public Frm_AddNote()
        {
            InitializeComponent();
        }

        private void Frm_AddNote_Load(object sender, EventArgs e)
        {
            cmb分类.SelectedIndex = 0; //将第一项作为默认选项，显示在下拉列表中

        }  

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Select frm = new Frm_Select();
            frm.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Conn = "provider=microsoft.jet.oledb.4.0;";
            Conn += " data source=AutoDesk.mdb";
            OleDbConnection myconn = new OleDbConnection(Conn);
            myconn.Open();

            string Title = "";
            string Content = "";
            if ( txt标题.Text == "" || txt内容.Text == "" || cmb分类.Text == "")
            {
                MessageBox.Show("标题,内容或者分类中有空值,空的笔记没有任何意义,是不会添加的！");
            }

       
            else
            {

                if (txt标题.Text.Contains("'"))
                {
                    Title = txt标题.Text.Replace("'", "''");//将单引号被替换为两个单引号的结果，存到临时变量中，该临时变量作为插入内容。每次遇到有单引号的字符，则需要通过该方法去替换
                }

                else
                {
                    Title = txt标题.Text; //若字符中不包含单引号，则还是按照文本框输入的字符进入插入
                }

                if (txt内容.Text.Contains("'"))
                {
                    Content = txt内容.Text.Replace("'", "''"); //将单引号被替换为两个单引号的结果，存到临时变量中，该临时变量作为插入内容。每次遇到有单引号的字符，则需要通过该方法去替换
                }

                else
                {
                    Content = txt内容.Text; //若字符中不包含单引号，则还是按照文本框输入的字符进入插入
                }


                // 将txt内容.Text读取到的包含单引号的值，替换为两个单引号字符。例如'r',会转成r。否则不转换无法写进数据库。因为不转换就是''r''包含单引号的字符无法写入数据库
                // 转换前：insert into [Note] ([title],[content],[datetime]) values ('111' , 'files = open (r‘D\Abc\1.txt’,'r')', '2016/9/10')
                // 转换后：insert into [Note] ([title],[content],[datetime]) values ('GFFG' , 'files = open (r‘D\Abc\1.txt’,''r'')', '2016/9/10')
                // 显示的结果还是会显示为一个单引号的值

                string insStr = "insert into [Note] ([title],[content],[datetime],[class]) values ('" + Title + "' , '" + Content + "', '" + dateTimePicker1.Value.ToShortDateString() + "', '" + cmb分类.Text + "')";

                //将表和字段名都加上中括号，否则可能会出现语法错误
                OleDbCommand myCmd = new OleDbCommand(insStr, myconn);
                myCmd.ExecuteNonQuery();
                myconn.Close();
                MessageBox.Show("添加笔记成功!");

                txt标题.Text = "";
                txt内容.Text = "";

            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt标题.Text = "";
            txt内容.Text = "";
        }

        private void txtStatus_KeyDown(object sender, KeyEventArgs e) //全选CTRL + A 的方法
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        
    }
}

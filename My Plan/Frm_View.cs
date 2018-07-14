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
    public partial class Frm_View : Form
    {
        string Conn = "provider=microsoft.jet.oledb.4.0;data source=MyData.mdb";
        
        public Frm_View()
        {
            InitializeComponent();
            
        }

        private void Frm_View_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            //将Datagridview设置为列宽自适应
            dataGridView1.AllowUserToAddRows = false;
            //不显示datagridview的最后一行
            dataGridView1.DataSource = "";
            cmbClassification.SelectedIndex = 3; //笔记分类下拉框默认选择全部
            cmbCompany.SelectedIndex = 2; //公司选择下拉框默认选择全部

        }

       
        private void btn_selectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

       

        private void btn_select_Click(object sender, EventArgs e)
        {
            OleDbConnection myCon = new OleDbConnection(Conn); //连接到数据库

            string myStr1 = "select [id],[title] as 笔记标题,[content] as 笔记内容,[datetime] as 记录时间, [class] as 笔记分类, [company] as 所在公司 from [Note] where 1=1";
            if ( txtTitle.Text != "" )
            {
                string TempTitle = "";
                if (txtTitle.Text.Contains("'"))
                {
                    TempTitle = txtTitle.Text.Replace("'", "''");
                    myStr1 += " and [title] like '%" + TempTitle + "%'"; //将单引号被替换为两个单引号的结果，存到临时变量中，该临时变量作为搜索条件。每次遇到有单引号的字符，则需要通过该方法去替换
                }

                else
                {
                    myStr1 += " and [title] like '%" + txtTitle.Text + "%'"; //若字符中不包含单引号，则还是按照文本框输入的字符进入搜索
                }


            }

            if ( txtContent.Text != "")
            {
                string TempContent = "";
                if (txtContent.Text.Contains("'"))
                {
                    TempContent = txtContent.Text.Replace("'", "''");
                    myStr1 += " and [content] like '%" + TempContent + "%'"; //将单引号被替换为两个单引号的结果，存到临时变量中，该临时变量作为搜索条件。每次遇到有单引号的字符，则需要通过该方法去替换
                }

                else
                {
                    myStr1 += " and [content] like '%" + txtContent.Text + "%'"; //若字符中不包含单引号，则还是按照文本框输入的字符进入搜索
                }
                
            }

            if (cmbClassification.Text != "全部") {
                myStr1 += " and [class] = '" + cmbClassification.Text + "' ";
            }

            else {
                myStr1 += "";
            }

            if (cmbCompany.Text != "全部")
            {
                myStr1 += " and [company] = '"+ cmbCompany.Text + "'";
            }

            else
            {
                myStr1 += "";
            }

            myStr1 += " order by [datetime] desc";
            // 将txtContent.Text读取到的包含单引号的值，替换为两个单引号字符。例如'r',会转成r。否则不转换无法写进数据库。因为不转换就是''r''包含单引号的字符无法写入数据库
            // 转换前：insert into [Note] ([title],[content],[datetime]) values ('111' , 'files = open (r‘D\Abc\1.txt’,'r')', '2016/9/10')
            // 转换后：insert into [Note] ([title],[content],[datetime]) values ('GFFG' , 'files = open (r‘D\Abc\1.txt’,''r'')', '2016/9/10')
            // 显示的结果还是会显示为一个单引号的值

            OleDbDataAdapter myAda = new OleDbDataAdapter(myStr1, myCon); //在连接好的数据库中打开已连接的表
            DataSet mySet = new DataSet(); //声明一个记录集
            myAda.Fill(mySet, "myData"); //将表中读取到的数据填充到记录集中，并取名为myData
            dataGridView1.DataSource = mySet; //设定显示控件的数据源
            dataGridView1.DataMember = "myData"; //将表格myData的内容绑定到显示控件
            dataGridView1.Columns[0].Visible = false; //搜索结果不显示第一列ID的内容，但因为后续查询中需要ID作为搜索字段，故隐藏之
            myCon.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Select frm = new Frm_Select();
            frm.Show();
        }

      
        private void btn_del_Click(object sender, EventArgs e)
        {

            OleDbConnection myCon = new OleDbConnection(Conn); //连接到数据库
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("你没有选中数据啊,无数据可删除！");
            }
            //try
            //{

           
            else
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("是否确定删除？", "提示", messButton);

            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    myCon.Open();
                    string idname = dataGridView1.SelectedRows[i].Cells["ID"].Value.ToString(); //获取dgv中选中行的id的值
                    string delStr = "delete from [Note] where [id]=" + idname + " ";
                    OleDbCommand myCmd = new OleDbCommand(delStr, myCon);
                    myCmd.ExecuteNonQuery();
                    myCon.Close();
                    MessageBox.Show("删除笔记成功");
                    SelectAll(); //刷新datagridview
                }
            }

            }

           
            

        }


        private void btn_viewnote_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("你没有选中数据啊,无数据可查看！");
            }
            
            /*else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("请选中一条以进行编辑，不可多条一同查看", "来自系统的消息");
            }
            */
            else
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("确定要查看笔记？", "提示", messButton);

                if (dr == DialogResult.OK)//如果点击“确定”按钮
                {
                    DataRow row = (dataGridView1.CurrentRow.DataBoundItem as DataRowView).Row;


                    Frm_ViewNoteDetail frm_viewdetail = new Frm_ViewNoteDetail(row);
                    //为查看准备数据
                    //frm_viewdetail.label4.Text = row["id"].ToString();
                    frm_viewdetail.txtTitle.Text = row["笔记标题"].ToString();
                    frm_viewdetail.txtContent.Text = row["笔记内容"].ToString();
                    frm_viewdetail.dateTimePicker1.Text = row["记录时间"].ToString();
                    frm_viewdetail.txtClassification.Text = row["笔记分类"].ToString();
                    frm_viewdetail.txtCompany.Text = row["所在公司"].ToString();

                    frm_viewdetail.ShowDialog();


                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("你没有选中数据啊,无数据可更新！");
            }

            /*else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("请选中一条以进行编辑，不可多条一同更新", "来自系统的消息");
            }*/

            else
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("确定要更新数据？", "提示", messButton);

            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                DataRow row = (dataGridView1.CurrentRow.DataBoundItem as DataRowView).Row;


                Frm_Edit frm_update = new Frm_Edit(row);
                //为查看准备数据
                //frm_update.label5.Text = row["id"].ToString();
                frm_update.txtTitle.Text = row["笔记标题"].ToString();
                frm_update.txtContent.Text = row["笔记内容"].ToString();
                frm_update.dateTimePicker1.Text = row["记录时间"].ToString();
                frm_update.cmbClassification.Text = row["笔记分类"].ToString();
                frm_update.cmbCompany.Text = row["所在公司"].ToString();

                frm_update.ShowDialog();
                SelectAll(); //刷新数据

            }

            }

           

           
        }

        private void SelectAll()
        {
            OleDbConnection myCon = new OleDbConnection(Conn); //连接到数据库

            string myStr1 = "select [id],[title] as 笔记标题,[content] as 笔记内容,[datetime] as 记录时间, [class] as 笔记分类, [company] as 所在公司 from [Note] order by [datetime] desc";

            OleDbDataAdapter myAda = new OleDbDataAdapter(myStr1, myCon); //在连接好的数据库中打开已连接的表
            DataSet mySet = new DataSet(); //声明一个记录集
            myAda.Fill(mySet, "myData"); //将表中读取到的数据填充到记录集中，并取名为myData
            dataGridView1.DataSource = mySet; //设定显示控件的数据源
            dataGridView1.DataMember = "myData"; //将表格myData的内容绑定到显示控件
            dataGridView1.Columns[0].Visible = false; //搜索结果不显示第一列ID的内容，但因为后续查询中需要ID作为搜索字段，故隐藏之
            myCon.Close();
        }

        private void txtStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtContent.Text = "";
            cmbClassification.Text = "";
            cmbCompany.Text = "";
        }

        private void btn_cleanresult_Click(object sender, EventArgs e)
        {
            //通过搜索一个不存在的字符，去清空当前搜索结果
            OleDbConnection myCon = new OleDbConnection(Conn); //连接到数据库

            string myStr1 = "select [id],[title] as 笔记标题,[content] as 笔记内容,[datetime] as 记录时间, [class] as 笔记分类,[company] as 所在公司 from [Note] where [content] = 'It is impossible to search current result!' ";

            OleDbDataAdapter myAda = new OleDbDataAdapter(myStr1, myCon); //在连接好的数据库中打开已连接的表
            DataSet mySet = new DataSet(); //声明一个记录集
            myAda.Fill(mySet, "myData"); //将表中读取到的数据填充到记录集中，并取名为myData
            dataGridView1.DataSource = mySet; //设定显示控件的数据源
            dataGridView1.DataMember = "myData"; //将表格myData的内容绑定到显示控件
            myCon.Close();
        }

    }
}

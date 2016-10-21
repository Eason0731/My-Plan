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
            this.Close();
            Frm_View frm3 = new Frm_View();
            frm3.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //彻底退出程序
        }

    }
}

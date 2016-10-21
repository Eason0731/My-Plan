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
    public partial class Frm_ViewNoteDetail : Form
    {
        DataRow Row_ViewDetail;
       
        public Frm_ViewNoteDetail(DataRow row_VND)
        {
            InitializeComponent();
            Row_ViewDetail = row_VND;
            
        }

     

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void Frm_ViewNoteDetail_Load(object sender, EventArgs e)
        {
            this.Text = txt标题.Text;
        }

        private void txtStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }
    }
}

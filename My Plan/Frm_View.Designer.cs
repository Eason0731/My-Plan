namespace My_Plan
{
    partial class Frm_View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_selectAll = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btn_viewnote = new System.Windows.Forms.Button();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_cleanresult = new System.Windows.Forms.Button();
            this.cmbClassification = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_back.Location = new System.Drawing.Point(791, 756);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(123, 49);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_selectAll
            // 
            this.btn_selectAll.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_selectAll.Location = new System.Drawing.Point(41, 756);
            this.btn_selectAll.Margin = new System.Windows.Forms.Padding(4);
            this.btn_selectAll.Name = "btn_selectAll";
            this.btn_selectAll.Size = new System.Drawing.Size(156, 49);
            this.btn_selectAll.TabIndex = 2;
            this.btn_selectAll.Text = "查询所有笔记";
            this.btn_selectAll.UseVisualStyleBackColor = true;
            this.btn_selectAll.Click += new System.EventHandler(this.btn_selectAll_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_update.Location = new System.Drawing.Point(436, 756);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(123, 49);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "更新笔记";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_del.Location = new System.Drawing.Point(619, 756);
            this.btn_del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(123, 49);
            this.btn_del.TabIndex = 4;
            this.btn_del.Text = "删除笔记";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_select.Location = new System.Drawing.Point(502, 489);
            this.btn_select.Margin = new System.Windows.Forms.Padding(4);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(161, 49);
            this.btn_select.TabIndex = 5;
            this.btn_select.Text = "指定条件查询";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("宋体", 12F);
            this.txtTitle.Location = new System.Drawing.Point(113, 337);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(343, 34);
            this.txtTitle.TabIndex = 23;
            this.txtTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStatus_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(37, 419);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "内容：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(37, 346);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "标题：";
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("宋体", 12F);
            this.txtContent.Location = new System.Drawing.Point(113, 415);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(343, 196);
            this.txtContent.TabIndex = 24;
            this.txtContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStatus_KeyDown);
            // 
            // btn_viewnote
            // 
            this.btn_viewnote.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_viewnote.Location = new System.Drawing.Point(257, 756);
            this.btn_viewnote.Margin = new System.Windows.Forms.Padding(4);
            this.btn_viewnote.Name = "btn_viewnote";
            this.btn_viewnote.Size = new System.Drawing.Size(123, 49);
            this.btn_viewnote.TabIndex = 25;
            this.btn_viewnote.Text = "查看笔记";
            this.btn_viewnote.UseVisualStyleBackColor = true;
            this.btn_viewnote.Click += new System.EventHandler(this.btn_viewnote_Click);
            // 
            // btn_clean
            // 
            this.btn_clean.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_clean.Location = new System.Drawing.Point(502, 562);
            this.btn_clean.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(161, 49);
            this.btn_clean.TabIndex = 26;
            this.btn_clean.Text = "清除搜索条件";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btn_cleanresult
            // 
            this.btn_cleanresult.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_cleanresult.Location = new System.Drawing.Point(697, 489);
            this.btn_cleanresult.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cleanresult.Name = "btn_cleanresult";
            this.btn_cleanresult.Size = new System.Drawing.Size(161, 49);
            this.btn_cleanresult.TabIndex = 27;
            this.btn_cleanresult.Text = "清空搜索内容";
            this.btn_cleanresult.UseVisualStyleBackColor = true;
            this.btn_cleanresult.Click += new System.EventHandler(this.btn_cleanresult_Click);
            // 
            // cmbClassification
            // 
            this.cmbClassification.DropDownHeight = 116;
            this.cmbClassification.FormattingEnabled = true;
            this.cmbClassification.IntegralHeight = false;
            this.cmbClassification.Items.AddRange(new object[] {
            "工作类",
            "技术类",
            "其他类",
            "全部"});
            this.cmbClassification.Location = new System.Drawing.Point(620, 341);
            this.cmbClassification.Name = "cmbClassification";
            this.cmbClassification.Size = new System.Drawing.Size(270, 23);
            this.cmbClassification.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(498, 341);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "笔记分类：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(498, 415);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "所在公司：";
            // 
            // cmbCompany
            // 
            this.cmbCompany.DropDownHeight = 116;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.IntegralHeight = false;
            this.cmbCompany.Items.AddRange(new object[] {
            "AutoDesk",
            "中国电信",
            "全部"});
            this.cmbCompany.Location = new System.Drawing.Point(620, 416);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(270, 23);
            this.cmbCompany.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(944, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // Frm_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 848);
            this.ControlBox = false;
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbClassification);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_cleanresult);
            this.Controls.Add(this.btn_clean);
            this.Controls.Add(this.btn_viewnote);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_selectAll);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_View";
            this.ShowIcon = false;
            this.Text = "查询我的笔记";
            this.Load += new System.EventHandler(this.Frm_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_selectAll;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_select;
        public System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btn_viewnote;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_cleanresult;
        private System.Windows.Forms.ComboBox cmbClassification;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
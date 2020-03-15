namespace My_Plan
{
    partial class Frm_ViewNoteDetail
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClassification = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(28, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "记录时间：";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_back.Location = new System.Drawing.Point(283, 605);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 34);
            this.btn_back.TabIndex = 23;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("宋体", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 550);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(61, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "内容：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "标题：";
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("宋体", 12F);
            this.txtContent.Location = new System.Drawing.Point(123, 97);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(479, 337);
            this.txtContent.TabIndex = 27;
            this.txtContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStatus_KeyDown);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("宋体", 12F);
            this.txtTitle.Location = new System.Drawing.Point(124, 36);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(258, 28);
            this.txtTitle.TabIndex = 26;
            this.txtTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStatus_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(31, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "笔记分类：";
            // 
            // txtClassification
            // 
            this.txtClassification.Font = new System.Drawing.Font("宋体", 12F);
            this.txtClassification.Location = new System.Drawing.Point(124, 466);
            this.txtClassification.Multiline = true;
            this.txtClassification.Name = "txtClassification";
            this.txtClassification.ReadOnly = true;
            this.txtClassification.Size = new System.Drawing.Size(258, 28);
            this.txtClassification.TabIndex = 29;
            this.txtClassification.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStatus_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(29, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "所在公司：";
            // 
            // txtCompany
            // 
            this.txtCompany.Font = new System.Drawing.Font("宋体", 12F);
            this.txtCompany.Location = new System.Drawing.Point(124, 508);
            this.txtCompany.Multiline = true;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.ReadOnly = true;
            this.txtCompany.Size = new System.Drawing.Size(258, 28);
            this.txtCompany.TabIndex = 31;
            // 
            // Frm_ViewNoteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 677);
            this.ControlBox = false;
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClassification);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frm_ViewNoteDetail";
            this.ShowIcon = false;
            this.Text = "查看笔记";
            this.Load += new System.EventHandler(this.Frm_ViewNoteDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_back;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtContent;
        public System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtClassification;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtCompany;
    }
}
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
            this.txt内容 = new System.Windows.Forms.TextBox();
            this.txt标题 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt笔记分类 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(39, 671);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "记录时间：";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_back.Location = new System.Drawing.Point(378, 743);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 42);
            this.btn_back.TabIndex = 23;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("宋体", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 665);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 30);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(81, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "内容：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(81, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "标题：";
            // 
            // txt内容
            // 
            this.txt内容.Font = new System.Drawing.Font("宋体", 12F);
            this.txt内容.Location = new System.Drawing.Point(164, 121);
            this.txt内容.Margin = new System.Windows.Forms.Padding(4);
            this.txt内容.Multiline = true;
            this.txt内容.Name = "txt内容";
            this.txt内容.ReadOnly = true;
            this.txt内容.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt内容.Size = new System.Drawing.Size(637, 420);
            this.txt内容.TabIndex = 27;
            this.txt内容.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStatus_KeyDown);
            // 
            // txt标题
            // 
            this.txt标题.Font = new System.Drawing.Font("宋体", 12F);
            this.txt标题.Location = new System.Drawing.Point(165, 45);
            this.txt标题.Margin = new System.Windows.Forms.Padding(4);
            this.txt标题.Multiline = true;
            this.txt标题.Name = "txt标题";
            this.txt标题.ReadOnly = true;
            this.txt标题.Size = new System.Drawing.Size(343, 34);
            this.txt标题.TabIndex = 26;
            this.txt标题.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStatus_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(41, 586);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "笔记分类：";
            // 
            // txt笔记分类
            // 
            this.txt笔记分类.Font = new System.Drawing.Font("宋体", 12F);
            this.txt笔记分类.Location = new System.Drawing.Point(165, 583);
            this.txt笔记分类.Margin = new System.Windows.Forms.Padding(4);
            this.txt笔记分类.Multiline = true;
            this.txt笔记分类.Name = "txt笔记分类";
            this.txt笔记分类.ReadOnly = true;
            this.txt笔记分类.Size = new System.Drawing.Size(343, 34);
            this.txt笔记分类.TabIndex = 29;
            this.txt笔记分类.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStatus_KeyDown);
            // 
            // Frm_ViewNoteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 809);
            this.ControlBox = false;
            this.Controls.Add(this.txt笔记分类);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt内容);
            this.Controls.Add(this.txt标题);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ViewNoteDetail";
            this.ShowIcon = false;
            this.Text = "查看我的工作笔记";
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
        public System.Windows.Forms.TextBox txt内容;
        public System.Windows.Forms.TextBox txt标题;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt笔记分类;
    }
}
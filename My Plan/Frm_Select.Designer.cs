namespace My_Plan
{
    partial class Frm_Select
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
            this.btn_gotoAdd = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNowDate = new System.Windows.Forms.Label();
            this.lblCustom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDeltaDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_gotoAdd
            // 
            this.btn_gotoAdd.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_gotoAdd.Location = new System.Drawing.Point(182, 150);
            this.btn_gotoAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gotoAdd.Name = "btn_gotoAdd";
            this.btn_gotoAdd.Size = new System.Drawing.Size(556, 50);
            this.btn_gotoAdd.TabIndex = 1;
            this.btn_gotoAdd.Text = "添加点工作笔记吧";
            this.btn_gotoAdd.UseVisualStyleBackColor = true;
            this.btn_gotoAdd.Click += new System.EventHandler(this.btn_gotoAdd_Click);
            // 
            // btn_view
            // 
            this.btn_view.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_view.Location = new System.Drawing.Point(182, 257);
            this.btn_view.Margin = new System.Windows.Forms.Padding(4);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(556, 50);
            this.btn_view.TabIndex = 2;
            this.btn_view.Text = "查看工作笔记咯";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_exit.Location = new System.Drawing.Point(181, 375);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(556, 50);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "彻底离开";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(176, 533);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 4;
            // 
            // lblNowDate
            // 
            this.lblNowDate.AutoSize = true;
            this.lblNowDate.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.lblNowDate.ForeColor = System.Drawing.Color.Blue;
            this.lblNowDate.Location = new System.Drawing.Point(269, 533);
            this.lblNowDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNowDate.Name = "lblNowDate";
            this.lblNowDate.Size = new System.Drawing.Size(0, 24);
            this.lblNowDate.TabIndex = 5;
            // 
            // lblCustom
            // 
            this.lblCustom.AutoSize = true;
            this.lblCustom.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.lblCustom.Location = new System.Drawing.Point(177, 580);
            this.lblCustom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(0, 24);
            this.lblCustom.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(455, 580);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 7;
            // 
            // lblDeltaDays
            // 
            this.lblDeltaDays.AutoSize = true;
            this.lblDeltaDays.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.lblDeltaDays.ForeColor = System.Drawing.Color.Red;
            this.lblDeltaDays.Location = new System.Drawing.Point(397, 580);
            this.lblDeltaDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeltaDays.Name = "lblDeltaDays";
            this.lblDeltaDays.Size = new System.Drawing.Size(0, 24);
            this.lblDeltaDays.TabIndex = 8;
            // 
            // Frm_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 656);
            this.ControlBox = false;
            this.Controls.Add(this.lblDeltaDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCustom);
            this.Controls.Add(this.lblNowDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_gotoAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Select";
            this.ShowIcon = false;
            this.Text = "命运的抉择";
            this.Load += new System.EventHandler(this.Frm_Select_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_gotoAdd;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNowDate;
        private System.Windows.Forms.Label lblCustom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDeltaDays;
    }
}
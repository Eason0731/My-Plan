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
            this.btn_choice = new System.Windows.Forms.Button();
            this.btn_gotoAdd = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_choice
            // 
            this.btn_choice.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_choice.Location = new System.Drawing.Point(136, 74);
            this.btn_choice.Name = "btn_choice";
            this.btn_choice.Size = new System.Drawing.Size(417, 40);
            this.btn_choice.TabIndex = 0;
            this.btn_choice.Text = "来做个抉择吧！";
            this.btn_choice.UseVisualStyleBackColor = true;
            this.btn_choice.Click += new System.EventHandler(this.btn_choice_Click);
            // 
            // btn_gotoAdd
            // 
            this.btn_gotoAdd.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_gotoAdd.Location = new System.Drawing.Point(136, 167);
            this.btn_gotoAdd.Name = "btn_gotoAdd";
            this.btn_gotoAdd.Size = new System.Drawing.Size(417, 40);
            this.btn_gotoAdd.TabIndex = 1;
            this.btn_gotoAdd.Text = "添加点工作笔记吧";
            this.btn_gotoAdd.UseVisualStyleBackColor = true;
            this.btn_gotoAdd.Click += new System.EventHandler(this.btn_gotoAdd_Click);
            // 
            // btn_view
            // 
            this.btn_view.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_view.Location = new System.Drawing.Point(136, 265);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(417, 40);
            this.btn_view.TabIndex = 2;
            this.btn_view.Text = "查看工作笔记咯";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_exit.Location = new System.Drawing.Point(136, 362);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(417, 40);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "彻底离开";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Frm_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 532);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_gotoAdd);
            this.Controls.Add(this.btn_choice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frm_Select";
            this.ShowIcon = false;
            this.Text = "命运的抉择";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_choice;
        private System.Windows.Forms.Button btn_gotoAdd;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_exit;
    }
}
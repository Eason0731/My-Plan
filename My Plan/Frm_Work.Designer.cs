namespace My_Plan
{
    partial class Frm_Work
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
            this.btn_AutoDesk = new System.Windows.Forms.Button();
            this.btn_Telecom = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_RiskRaider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AutoDesk
            // 
            this.btn_AutoDesk.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_AutoDesk.Location = new System.Drawing.Point(176, 253);
            this.btn_AutoDesk.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AutoDesk.Name = "btn_AutoDesk";
            this.btn_AutoDesk.Size = new System.Drawing.Size(556, 50);
            this.btn_AutoDesk.TabIndex = 10;
            this.btn_AutoDesk.Text = "AutoDesk";
            this.btn_AutoDesk.UseVisualStyleBackColor = true;
            this.btn_AutoDesk.Click += new System.EventHandler(this.btn_AutoDesk_Click);
            // 
            // btn_Telecom
            // 
            this.btn_Telecom.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_Telecom.Location = new System.Drawing.Point(176, 386);
            this.btn_Telecom.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Telecom.Name = "btn_Telecom";
            this.btn_Telecom.Size = new System.Drawing.Size(556, 50);
            this.btn_Telecom.TabIndex = 11;
            this.btn_Telecom.Text = "中国电信";
            this.btn_Telecom.UseVisualStyleBackColor = true;
            this.btn_Telecom.Click += new System.EventHandler(this.btn_Telecom_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_Back.Location = new System.Drawing.Point(176, 516);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(556, 50);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.Text = "返回";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_RiskRaider
            // 
            this.btn_RiskRaider.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_RiskRaider.Location = new System.Drawing.Point(176, 117);
            this.btn_RiskRaider.Margin = new System.Windows.Forms.Padding(4);
            this.btn_RiskRaider.Name = "btn_RiskRaider";
            this.btn_RiskRaider.Size = new System.Drawing.Size(556, 50);
            this.btn_RiskRaider.TabIndex = 13;
            this.btn_RiskRaider.Text = "斯睿德";
            this.btn_RiskRaider.UseVisualStyleBackColor = true;
            this.btn_RiskRaider.Click += new System.EventHandler(this.btn_RiskRaider_Click);
            // 
            // Frm_Work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 648);
            this.Controls.Add(this.btn_RiskRaider);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Telecom);
            this.Controls.Add(this.btn_AutoDesk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frm_Work";
            this.Text = "查看工作情况";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AutoDesk;
        private System.Windows.Forms.Button btn_Telecom;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_RiskRaider;
    }
}
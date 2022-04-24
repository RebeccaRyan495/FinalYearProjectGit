namespace PolygraphGUIFeb
{
    partial class FormMainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExamConfig = new System.Windows.Forms.Button();
            this.btnViewSub = new System.Windows.Forms.Button();
            this.btnViewQuest = new System.Windows.Forms.Button();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 96);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(140, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assessment - Main Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(257, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Select an Option:";
            // 
            // btnExamConfig
            // 
            this.btnExamConfig.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnExamConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamConfig.Location = new System.Drawing.Point(98, 207);
            this.btnExamConfig.Name = "btnExamConfig";
            this.btnExamConfig.Size = new System.Drawing.Size(206, 50);
            this.btnExamConfig.TabIndex = 7;
            this.btnExamConfig.Text = "Configure Exam";
            this.btnExamConfig.UseVisualStyleBackColor = false;
            this.btnExamConfig.Click += new System.EventHandler(this.btnExamConfig_Click);
            // 
            // btnViewSub
            // 
            this.btnViewSub.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnViewSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSub.Location = new System.Drawing.Point(98, 326);
            this.btnViewSub.Name = "btnViewSub";
            this.btnViewSub.Size = new System.Drawing.Size(206, 50);
            this.btnViewSub.TabIndex = 8;
            this.btnViewSub.Text = "View Subjects";
            this.btnViewSub.UseVisualStyleBackColor = false;
            this.btnViewSub.Click += new System.EventHandler(this.btnViewSub_Click);
            // 
            // btnViewQuest
            // 
            this.btnViewQuest.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnViewQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewQuest.Location = new System.Drawing.Point(550, 207);
            this.btnViewQuest.Name = "btnViewQuest";
            this.btnViewQuest.Size = new System.Drawing.Size(238, 50);
            this.btnViewQuest.TabIndex = 9;
            this.btnViewQuest.Text = "View Questions";
            this.btnViewQuest.UseVisualStyleBackColor = false;
            this.btnViewQuest.Click += new System.EventHandler(this.btnViewQuest_Click);
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUpdateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.Location = new System.Drawing.Point(550, 326);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(238, 50);
            this.btnUpdateInfo.TabIndex = 10;
            this.btnUpdateInfo.Text = "Update Credentials";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(361, 412);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(141, 50);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(855, 522);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.btnViewQuest);
            this.Controls.Add(this.btnViewSub);
            this.Controls.Add(this.btnExamConfig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExamConfig;
        private System.Windows.Forms.Button btnViewSub;
        private System.Windows.Forms.Button btnViewQuest;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Button btnLogout;
    }
}
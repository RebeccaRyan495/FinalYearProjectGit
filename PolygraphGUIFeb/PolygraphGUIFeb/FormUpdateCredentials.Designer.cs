namespace PolygraphGUIFeb
{
    partial class FormUpdateCredentials
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
            this.tbUsername1 = new System.Windows.Forms.TextBox();
            this.tbPassword1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelVerify = new System.Windows.Forms.Label();
            this.labelIncorrect = new System.Windows.Forms.Label();
            this.lblEnterAll = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbUsername2 = new System.Windows.Forms.TextBox();
            this.tbPassword2 = new System.Windows.Forms.TextBox();
            this.lblAccept = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 96);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(141, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verification";
            // 
            // tbUsername1
            // 
            this.tbUsername1.Location = new System.Drawing.Point(164, 186);
            this.tbUsername1.Name = "tbUsername1";
            this.tbUsername1.Size = new System.Drawing.Size(168, 26);
            this.tbUsername1.TabIndex = 5;
            // 
            // tbPassword1
            // 
            this.tbPassword1.Location = new System.Drawing.Point(164, 252);
            this.tbPassword1.Name = "tbPassword1";
            this.tbPassword1.PasswordChar = '*';
            this.tbPassword1.Size = new System.Drawing.Size(168, 26);
            this.tbPassword1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(256, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Verify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelVerify
            // 
            this.labelVerify.AutoSize = true;
            this.labelVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerify.Location = new System.Drawing.Point(71, 130);
            this.labelVerify.Name = "labelVerify";
            this.labelVerify.Size = new System.Drawing.Size(387, 25);
            this.labelVerify.TabIndex = 10;
            this.labelVerify.Text = "Please enter your credentials for verification";
            // 
            // labelIncorrect
            // 
            this.labelIncorrect.AutoSize = true;
            this.labelIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncorrect.Location = new System.Drawing.Point(144, 130);
            this.labelIncorrect.Name = "labelIncorrect";
            this.labelIncorrect.Size = new System.Drawing.Size(191, 25);
            this.labelIncorrect.TabIndex = 11;
            this.labelIncorrect.Text = "Incorrect Credentials";
            // 
            // lblEnterAll
            // 
            this.lblEnterAll.AutoSize = true;
            this.lblEnterAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterAll.Location = new System.Drawing.Point(141, 130);
            this.lblEnterAll.Name = "lblEnterAll";
            this.lblEnterAll.Size = new System.Drawing.Size(206, 25);
            this.lblEnterAll.TabIndex = 12;
            this.lblEnterAll.Text = "Please enter all details";
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBack.Location = new System.Drawing.Point(108, 320);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 40);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbUsername2
            // 
            this.tbUsername2.Location = new System.Drawing.Point(165, 186);
            this.tbUsername2.Name = "tbUsername2";
            this.tbUsername2.Size = new System.Drawing.Size(168, 26);
            this.tbUsername2.TabIndex = 14;
            // 
            // tbPassword2
            // 
            this.tbPassword2.Location = new System.Drawing.Point(164, 252);
            this.tbPassword2.Name = "tbPassword2";
            this.tbPassword2.PasswordChar = '*';
            this.tbPassword2.Size = new System.Drawing.Size(168, 26);
            this.tbPassword2.TabIndex = 15;
            // 
            // lblAccept
            // 
            this.lblAccept.AutoSize = true;
            this.lblAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccept.Location = new System.Drawing.Point(76, 130);
            this.lblAccept.Name = "lblAccept";
            this.lblAccept.Size = new System.Drawing.Size(356, 25);
            this.lblAccept.TabIndex = 16;
            this.lblAccept.Text = "Accepted - please enter updated details";
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Location = new System.Drawing.Point(256, 320);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 40);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormUpdateCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(506, 398);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblAccept);
            this.Controls.Add(this.tbPassword2);
            this.Controls.Add(this.tbUsername2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblEnterAll);
            this.Controls.Add(this.labelIncorrect);
            this.Controls.Add(this.labelVerify);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPassword1);
            this.Controls.Add(this.tbUsername1);
            this.Controls.Add(this.panel1);
            this.Name = "FormUpdateCredentials";
            this.Text = "Please Verify Details";
            this.Load += new System.EventHandler(this.FormUpdateCredentials_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername1;
        private System.Windows.Forms.TextBox tbPassword1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelVerify;
        private System.Windows.Forms.Label labelIncorrect;
        private System.Windows.Forms.Label lblEnterAll;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbUsername2;
        private System.Windows.Forms.TextBox tbPassword2;
        private System.Windows.Forms.Label lblAccept;
        private System.Windows.Forms.Button btnUpdate;
    }
}
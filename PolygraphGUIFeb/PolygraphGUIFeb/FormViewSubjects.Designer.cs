namespace PolygraphGUIFeb
{
    partial class FormViewSubjects
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
            this.listBoxSubjects = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddSub = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbIncar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrevTest = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSubAdd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.btnDeleteSub = new System.Windows.Forms.Button();
            this.btnEditSub = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSubID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 96);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(302, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Subjects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(34, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "List of all subjects on system";
            // 
            // listBoxSubjects
            // 
            this.listBoxSubjects.FormattingEnabled = true;
            this.listBoxSubjects.ItemHeight = 20;
            this.listBoxSubjects.Location = new System.Drawing.Point(60, 183);
            this.listBoxSubjects.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSubjects.Name = "listBoxSubjects";
            this.listBoxSubjects.Size = new System.Drawing.Size(355, 344);
            this.listBoxSubjects.TabIndex = 4;
            this.listBoxSubjects.SelectedIndexChanged += new System.EventHandler(this.listBoxSubjects_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddSub
            // 
            this.btnAddSub.Location = new System.Drawing.Point(188, 550);
            this.btnAddSub.Name = "btnAddSub";
            this.btnAddSub.Size = new System.Drawing.Size(127, 41);
            this.btnAddSub.TabIndex = 8;
            this.btnAddSub.Text = "Add Subject";
            this.btnAddSub.UseVisualStyleBackColor = true;
            this.btnAddSub.Click += new System.EventHandler(this.btnAddSub_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(487, 221);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(155, 26);
            this.tbFirstName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(658, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(662, 221);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(177, 26);
            this.tbLastName.TabIndex = 11;
            // 
            // tbIncar
            // 
            this.tbIncar.Location = new System.Drawing.Point(487, 299);
            this.tbIncar.Name = "tbIncar";
            this.tbIncar.Size = new System.Drawing.Size(155, 26);
            this.tbIncar.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Previously In Custody";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(658, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Previous Tests";
            // 
            // tbPrevTest
            // 
            this.tbPrevTest.Location = new System.Drawing.Point(662, 299);
            this.tbPrevTest.Name = "tbPrevTest";
            this.tbPrevTest.Size = new System.Drawing.Size(177, 26);
            this.tbPrevTest.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Subject Address";
            // 
            // tbSubAdd
            // 
            this.tbSubAdd.Location = new System.Drawing.Point(487, 372);
            this.tbSubAdd.Multiline = true;
            this.tbSubAdd.Name = "tbSubAdd";
            this.tbSubAdd.Size = new System.Drawing.Size(352, 61);
            this.tbSubAdd.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Custodian Name";
            // 
            // tbCustName
            // 
            this.tbCustName.Location = new System.Drawing.Point(487, 481);
            this.tbCustName.Multiline = true;
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(237, 46);
            this.tbCustName.TabIndex = 19;
            // 
            // btnDeleteSub
            // 
            this.btnDeleteSub.Location = new System.Drawing.Point(487, 550);
            this.btnDeleteSub.Name = "btnDeleteSub";
            this.btnDeleteSub.Size = new System.Drawing.Size(155, 41);
            this.btnDeleteSub.TabIndex = 21;
            this.btnDeleteSub.Text = "Delete Selected";
            this.btnDeleteSub.UseVisualStyleBackColor = true;
            this.btnDeleteSub.Click += new System.EventHandler(this.btnDeleteSub_Click);
            // 
            // btnEditSub
            // 
            this.btnEditSub.Location = new System.Drawing.Point(684, 550);
            this.btnEditSub.Name = "btnEditSub";
            this.btnEditSub.Size = new System.Drawing.Size(155, 41);
            this.btnEditSub.TabIndex = 22;
            this.btnEditSub.Text = "Edit Subject";
            this.btnEditSub.UseVisualStyleBackColor = true;
            this.btnEditSub.Click += new System.EventHandler(this.btnEditSub_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(485, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Subject ID";
            // 
            // tbSubID
            // 
            this.tbSubID.Location = new System.Drawing.Point(487, 169);
            this.tbSubID.Name = "tbSubID";
            this.tbSubID.ReadOnly = true;
            this.tbSubID.Size = new System.Drawing.Size(155, 26);
            this.tbSubID.TabIndex = 23;
            // 
            // FormViewSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(909, 628);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbSubID);
            this.Controls.Add(this.btnEditSub);
            this.Controls.Add(this.btnDeleteSub);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCustName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSubAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPrevTest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbIncar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.btnAddSub);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxSubjects);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FormViewSubjects";
            this.Text = "FormViewSubjects";
            this.Load += new System.EventHandler(this.FormViewSubjects_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxSubjects;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddSub;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbIncar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrevTest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSubAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCustName;
        private System.Windows.Forms.Button btnDeleteSub;
        private System.Windows.Forms.Button btnEditSub;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSubID;
    }
}
namespace PolygraphGUIFeb
{
    partial class FormAddSubject
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
            this.tbSubFName = new System.Windows.Forms.TextBox();
            this.tbSubLName = new System.Windows.Forms.TextBox();
            this.comboIncar = new System.Windows.Forms.ComboBox();
            this.tbPrevTest = new System.Windows.Forms.TextBox();
            this.tbSubAdd = new System.Windows.Forms.TextBox();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 96);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(171, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Subject";
            // 
            // tbSubFName
            // 
            this.tbSubFName.Location = new System.Drawing.Point(85, 165);
            this.tbSubFName.Name = "tbSubFName";
            this.tbSubFName.Size = new System.Drawing.Size(182, 26);
            this.tbSubFName.TabIndex = 4;
            // 
            // tbSubLName
            // 
            this.tbSubLName.Location = new System.Drawing.Point(379, 165);
            this.tbSubLName.Name = "tbSubLName";
            this.tbSubLName.Size = new System.Drawing.Size(182, 26);
            this.tbSubLName.TabIndex = 5;
            // 
            // comboIncar
            // 
            this.comboIncar.FormattingEnabled = true;
            this.comboIncar.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.comboIncar.Location = new System.Drawing.Point(85, 303);
            this.comboIncar.Name = "comboIncar";
            this.comboIncar.Size = new System.Drawing.Size(182, 28);
            this.comboIncar.TabIndex = 6;
            // 
            // tbPrevTest
            // 
            this.tbPrevTest.Location = new System.Drawing.Point(379, 230);
            this.tbPrevTest.Name = "tbPrevTest";
            this.tbPrevTest.Size = new System.Drawing.Size(182, 26);
            this.tbPrevTest.TabIndex = 7;
            // 
            // tbSubAdd
            // 
            this.tbSubAdd.Location = new System.Drawing.Point(85, 230);
            this.tbSubAdd.Name = "tbSubAdd";
            this.tbSubAdd.Size = new System.Drawing.Size(182, 26);
            this.tbSubAdd.TabIndex = 8;
            // 
            // tbCustName
            // 
            this.tbCustName.Location = new System.Drawing.Point(379, 305);
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(182, 26);
            this.tbCustName.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(119, 376);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 41);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(414, 376);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(102, 41);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Subject Previously in Custody?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Subject Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Current Custodian Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Number of Previous Tests";
            // 
            // FormAddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 489);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbCustName);
            this.Controls.Add(this.tbSubAdd);
            this.Controls.Add(this.tbPrevTest);
            this.Controls.Add(this.comboIncar);
            this.Controls.Add(this.tbSubLName);
            this.Controls.Add(this.tbSubFName);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddSubject";
            this.Text = "FormAddSubject";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSubFName;
        private System.Windows.Forms.TextBox tbSubLName;
        private System.Windows.Forms.ComboBox comboIncar;
        private System.Windows.Forms.TextBox tbPrevTest;
        private System.Windows.Forms.TextBox tbSubAdd;
        private System.Windows.Forms.TextBox tbCustName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
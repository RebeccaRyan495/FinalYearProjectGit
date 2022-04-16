namespace PolygraphGUIFeb
{
    partial class FormExamSelectQuestion
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
            this.btnBack = new System.Windows.Forms.Button();
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.tbSubID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lbSelected = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeselect = new System.Windows.Forms.Button();
            this.btnDebug = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 96);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(285, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Questions";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(144, 547);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 41);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.ItemHeight = 20;
            this.listBoxQuestions.Location = new System.Drawing.Point(53, 181);
            this.listBoxQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(340, 344);
            this.listBoxQuestions.TabIndex = 9;
            this.listBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(306, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Please select questions";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(424, 281);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(76, 41);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = ">>>";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // tbSubID
            // 
            this.tbSubID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbSubID.Location = new System.Drawing.Point(436, 208);
            this.tbSubID.Name = "tbSubID";
            this.tbSubID.ReadOnly = true;
            this.tbSubID.Size = new System.Drawing.Size(53, 26);
            this.tbSubID.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(420, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Question ID";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(639, 547);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(141, 41);
            this.btnContinue.TabIndex = 42;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lbSelected
            // 
            this.lbSelected.FormattingEnabled = true;
            this.lbSelected.ItemHeight = 20;
            this.lbSelected.Location = new System.Drawing.Point(533, 181);
            this.lbSelected.Margin = new System.Windows.Forms.Padding(4);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.Size = new System.Drawing.Size(339, 344);
            this.lbSelected.TabIndex = 43;
            this.lbSelected.SelectedIndexChanged += new System.EventHandler(this.lbSelected_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(635, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Currently Selected";
            // 
            // btnDeselect
            // 
            this.btnDeselect.Location = new System.Drawing.Point(424, 347);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(76, 41);
            this.btnDeselect.TabIndex = 45;
            this.btnDeselect.Text = "<<<";
            this.btnDeselect.UseVisualStyleBackColor = true;
            this.btnDeselect.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(424, 547);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(76, 41);
            this.btnDebug.TabIndex = 46;
            this.btnDebug.Text = "debug";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // FormExamSelectQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(931, 624);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.btnDeselect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSelected);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbSubID);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listBoxQuestions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FormExamSelectQuestion";
            this.Text = "FormExamSelectQuestion";
            this.Load += new System.EventHandler(this.FormExamSelectQuestion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox tbSubID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.ListBox lbSelected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeselect;
        private System.Windows.Forms.Button btnDebug;
    }
}
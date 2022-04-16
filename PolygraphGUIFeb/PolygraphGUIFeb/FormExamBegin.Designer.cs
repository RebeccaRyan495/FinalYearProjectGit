
namespace PolygraphGUIFeb
{
    partial class FormExamBegin
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
            this.pleaseConfirm = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.examCountInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 96);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(285, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Examination Start";
            // 
            // pleaseConfirm
            // 
            this.pleaseConfirm.AutoSize = true;
            this.pleaseConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pleaseConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pleaseConfirm.Location = new System.Drawing.Point(176, 114);
            this.pleaseConfirm.Name = "pleaseConfirm";
            this.pleaseConfirm.Size = new System.Drawing.Size(648, 32);
            this.pleaseConfirm.TabIndex = 9;
            this.pleaseConfirm.Text = "Please confirm subject is attached to sensor(s)";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(397, 188);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(118, 39);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // examCountInfo
            // 
            this.examCountInfo.AutoSize = true;
            this.examCountInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examCountInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.examCountInfo.Location = new System.Drawing.Point(223, 114);
            this.examCountInfo.Name = "examCountInfo";
            this.examCountInfo.Size = new System.Drawing.Size(462, 32);
            this.examCountInfo.TabIndex = 11;
            this.examCountInfo.Text = "Examination begins in 5 seconds";
            // 
            // FormExamBegin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(930, 519);
            this.Controls.Add(this.examCountInfo);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pleaseConfirm);
            this.Controls.Add(this.panel1);
            this.Name = "FormExamBegin";
            this.Text = "FormExamBegin";
            this.Load += new System.EventHandler(this.FormExamBegin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pleaseConfirm;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label examCountInfo;
    }
}
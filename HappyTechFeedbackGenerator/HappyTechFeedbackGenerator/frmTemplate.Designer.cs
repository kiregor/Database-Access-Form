using System.Windows.Forms;

namespace HappyTechFeedbackGenerator
{
    partial class frmTemplate
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
            this.txtTemplate = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtTemplate
            // 
            this.txtTemplate.AcceptsTab = true;
            this.txtTemplate.Location = new System.Drawing.Point(43, 83);
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.Size = new System.Drawing.Size(368, 446);
            this.txtTemplate.TabIndex = 0;
            this.txtTemplate.Text = "\n\n\n\n<date>\nDear <Honorific> <firstName> <LastName> \n\n\n Y" +
    "ours Sincerely,\n<staffName>";
            this.txtTemplate.SelectionAlignment = HorizontalAlignment.Right;
            this.txtTemplate.SelectedText = "<firstName> <lastName>\n<address>";
            // 
            // frmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 655);
            this.Controls.Add(this.txtTemplate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTemplate";
            this.Text = "Temple Generator";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtTemplate;
    }
}
using System.Windows.Forms;

namespace HappyTechFeedbackGenerator
{
    partial class TemplateForm
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
            this.txtTemplateBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtTemplateBox
            // 
            this.txtTemplateBox.AcceptsTab = true;
            this.txtTemplateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTemplateBox.Location = new System.Drawing.Point(12, 12);
            this.txtTemplateBox.Name = "txtTemplateBox";
            this.txtTemplateBox.Size = new System.Drawing.Size(446, 498);
            this.txtTemplateBox.TabIndex = 0;
            //Default text in the template. In later versions, angle bracket tags will be used to load data from database. Treat them as placegolders.
            this.txtTemplateBox.Text = "\n\n\n\n<date>\nDear <Honorific> <firstName> <LastName> \n\n\n Yours Sincerely,\n<staffName>";
            //Property which aligns selected text. Here, it's used to make a letter head.
            this.txtTemplateBox.SelectionAlignment = HorizontalAlignment.Right;
            //Text which is aligned right.
            this.txtTemplateBox.SelectedText = "<firstName> <lastName>\n<address>";

            /*If no text in the 'frmtemplate' is aligned right, this means that the event handler has been added 
            and previous changes to text formatting were rejected by the program. When that happens the selected 
            text will merge with the general text. Just watch out for that.*/

            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 522);
            this.Controls.Add(this.txtTemplateBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TemplateForm";
            this.Text = "Template generator";
            this.Load += new System.EventHandler(this.frmTemplate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTemplateBox;
    }
}
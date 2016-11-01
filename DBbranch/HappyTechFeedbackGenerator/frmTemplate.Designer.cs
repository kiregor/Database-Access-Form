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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateForm));
            this.txtTemplateBox = new System.Windows.Forms.RichTextBox();
            this.txtBoxTemplateInfo = new System.Windows.Forms.TextBox();
            this.btnDirectoryfinder = new System.Windows.Forms.Button();
            this.txtBoxSaveDirectory = new System.Windows.Forms.TextBox();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTemplateBox
            // 
            this.txtTemplateBox.AcceptsTab = true;
            this.txtTemplateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTemplateBox.Location = new System.Drawing.Point(12, 78);
            this.txtTemplateBox.Name = "txtTemplateBox";
            this.txtTemplateBox.Size = new System.Drawing.Size(545, 483);
            this.txtTemplateBox.TabIndex = 0;
            this.txtTemplateBox.Text = "";
            // 
            // txtBoxTemplateInfo
            // 
            this.txtBoxTemplateInfo.Location = new System.Drawing.Point(12, 12);
            this.txtBoxTemplateInfo.Multiline = true;
            this.txtBoxTemplateInfo.Name = "txtBoxTemplateInfo";
            this.txtBoxTemplateInfo.ReadOnly = true;
            this.txtBoxTemplateInfo.Size = new System.Drawing.Size(545, 60);
            this.txtBoxTemplateInfo.TabIndex = 1;
            this.txtBoxTemplateInfo.Text = resources.GetString("txtBoxTemplateInfo.Text");
            // 
            // btnDirectoryfinder
            // 
            this.btnDirectoryfinder.Location = new System.Drawing.Point(386, 568);
            this.btnDirectoryfinder.Name = "btnDirectoryfinder";
            this.btnDirectoryfinder.Size = new System.Drawing.Size(75, 23);
            this.btnDirectoryfinder.TabIndex = 2;
            this.btnDirectoryfinder.Text = "Browse";
            this.btnDirectoryfinder.UseVisualStyleBackColor = true;
            this.btnDirectoryfinder.Click += new System.EventHandler(this.btnDirectoryfinder_Click);
            // 
            // txtBoxSaveDirectory
            // 
            this.txtBoxSaveDirectory.Location = new System.Drawing.Point(12, 570);
            this.txtBoxSaveDirectory.Name = "txtBoxSaveDirectory";
            this.txtBoxSaveDirectory.Size = new System.Drawing.Size(368, 20);
            this.txtBoxSaveDirectory.TabIndex = 3;
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Location = new System.Drawing.Point(467, 568);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(90, 23);
            this.btnSaveTemplate.TabIndex = 4;
            this.btnSaveTemplate.Text = "Save Template";
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 600);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.txtBoxSaveDirectory);
            this.Controls.Add(this.btnDirectoryfinder);
            this.Controls.Add(this.txtBoxTemplateInfo);
            this.Controls.Add(this.txtTemplateBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TemplateForm";
            this.Text = "Template generator";
            this.Load += new System.EventHandler(this.TemplateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTemplateBox;
        private TextBox txtBoxTemplateInfo;
        private Button btnDirectoryfinder;
        private TextBox txtBoxSaveDirectory;
        private Button btnSaveTemplate;
    }
}
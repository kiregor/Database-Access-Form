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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTemplateBox
            // 
            this.txtTemplateBox.AcceptsTab = true;
            this.txtTemplateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTemplateBox.Location = new System.Drawing.Point(12, 98);
            this.txtTemplateBox.Name = "txtTemplateBox";
            this.txtTemplateBox.Size = new System.Drawing.Size(446, 498);
            this.txtTemplateBox.TabIndex = 0;
            this.txtTemplateBox.Text = "<firstName> <lastName>\n<address>\n\n\n\n<date>\nDear <Honorific> <firstName> <LastName" +
    "> \n\n\n Yours Sincerely,\n<staffName>";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 624);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 624);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(446, 80);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Write out the template below, use <tags> to define the place where you wish to ha" +
    "ve usable sentences from the feedback page. ";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 679);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTemplateBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TemplateForm";
            this.Text = "Template generator";
            this.Load += new System.EventHandler(this.frmTemplate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTemplateBox;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
    }
}
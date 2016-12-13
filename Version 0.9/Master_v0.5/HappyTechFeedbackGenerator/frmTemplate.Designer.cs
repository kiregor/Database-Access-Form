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
            this.btnDirectoryfinder = new System.Windows.Forms.Button();
            this.txtBoxSaveDirectory = new System.Windows.Forms.TextBox();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTemplateBox
            // 
            this.txtTemplateBox.AcceptsTab = true;
            this.txtTemplateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTemplateBox.Location = new System.Drawing.Point(14, 121);
            this.txtTemplateBox.Name = "txtTemplateBox";
            this.txtTemplateBox.Size = new System.Drawing.Size(636, 526);
            this.txtTemplateBox.TabIndex = 0;
            this.txtTemplateBox.Text = "";
            // 
            // btnDirectoryfinder
            // 
            this.btnDirectoryfinder.BackColor = System.Drawing.Color.Gray;
            this.btnDirectoryfinder.FlatAppearance.BorderSize = 0;
            this.btnDirectoryfinder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectoryfinder.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDirectoryfinder.ForeColor = System.Drawing.Color.White;
            this.btnDirectoryfinder.Location = new System.Drawing.Point(450, 655);
            this.btnDirectoryfinder.Name = "btnDirectoryfinder";
            this.btnDirectoryfinder.Size = new System.Drawing.Size(87, 27);
            this.btnDirectoryfinder.TabIndex = 2;
            this.btnDirectoryfinder.Text = "Browse";
            this.btnDirectoryfinder.UseVisualStyleBackColor = false;
            this.btnDirectoryfinder.Click += new System.EventHandler(this.btnDirectoryfinder_Click);
            // 
            // txtBoxSaveDirectory
            // 
            this.txtBoxSaveDirectory.Location = new System.Drawing.Point(14, 658);
            this.txtBoxSaveDirectory.Name = "txtBoxSaveDirectory";
            this.txtBoxSaveDirectory.Size = new System.Drawing.Size(429, 23);
            this.txtBoxSaveDirectory.TabIndex = 3;
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.BackColor = System.Drawing.Color.Gray;
            this.btnSaveTemplate.FlatAppearance.BorderSize = 0;
            this.btnSaveTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTemplate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveTemplate.ForeColor = System.Drawing.Color.White;
            this.btnSaveTemplate.Location = new System.Drawing.Point(545, 655);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(105, 27);
            this.btnSaveTemplate.TabIndex = 4;
            this.btnSaveTemplate.Text = "Save Template";
            this.btnSaveTemplate.UseVisualStyleBackColor = false;
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "In the box below, write out any <tags> you want to use.  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "You can use tags present in the database or create new ones. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(532, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "You don\'t need to worry about header and footer as these are already built ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(588, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "into the template. The line below shows, where the template will be saved, you ca" +
    "n ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(567, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "change the directory. once everything is done, click \'Create template\' button to";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = " save the template.";
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyTechFeedbackGenerator.Properties.Resources.appBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 692);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.txtBoxSaveDirectory);
            this.Controls.Add(this.btnDirectoryfinder);
            this.Controls.Add(this.txtTemplateBox);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TemplateForm";
            this.Text = "Template generator";
            this.Load += new System.EventHandler(this.TemplateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTemplateBox;
        private Button btnDirectoryfinder;
        private TextBox txtBoxSaveDirectory;
        private Button btnSaveTemplate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
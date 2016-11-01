namespace HappyTechFeedbackGenerator
{
    partial class MainMenu
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
            this.bigRedButtonTEMP = new System.Windows.Forms.Button();
            this.btnNewFeedback = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bigRedButtonTEMP
            // 
            this.bigRedButtonTEMP.BackColor = System.Drawing.Color.LightCoral;
            this.bigRedButtonTEMP.Location = new System.Drawing.Point(12, 12);
            this.bigRedButtonTEMP.Name = "bigRedButtonTEMP";
            this.bigRedButtonTEMP.Size = new System.Drawing.Size(156, 87);
            this.bigRedButtonTEMP.TabIndex = 0;
            this.bigRedButtonTEMP.Text = "Create template";
            this.bigRedButtonTEMP.UseVisualStyleBackColor = false;
            this.bigRedButtonTEMP.Click += new System.EventHandler(this.bigRedButtonTEMP_Click);
            // 
            // btnNewFeedback
            // 
            this.btnNewFeedback.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewFeedback.Location = new System.Drawing.Point(188, 12);
            this.btnNewFeedback.Name = "btnNewFeedback";
            this.btnNewFeedback.Size = new System.Drawing.Size(156, 87);
            this.btnNewFeedback.TabIndex = 1;
            this.btnNewFeedback.Text = "New feedback";
            this.btnNewFeedback.UseVisualStyleBackColor = false;
            this.btnNewFeedback.Click += new System.EventHandler(this.btnNewFeedback_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(104, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 87);
            this.button1.TabIndex = 2;
            this.button1.Text = "Data Grid";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewFeedback);
            this.Controls.Add(this.bigRedButtonTEMP);
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bigRedButtonTEMP;
        private System.Windows.Forms.Button btnNewFeedback;
        private System.Windows.Forms.Button button1;
    }
}


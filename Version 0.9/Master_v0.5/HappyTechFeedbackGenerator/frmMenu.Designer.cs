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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.bigRedButtonTEMP = new System.Windows.Forms.Button();
            this.btnNewFeedback = new System.Windows.Forms.Button();
            this.btnEditTemplate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bigRedButtonTEMP
            // 
            this.bigRedButtonTEMP.BackColor = System.Drawing.Color.Gray;
            this.bigRedButtonTEMP.FlatAppearance.BorderSize = 0;
            this.bigRedButtonTEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bigRedButtonTEMP.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigRedButtonTEMP.ForeColor = System.Drawing.Color.White;
            this.bigRedButtonTEMP.Location = new System.Drawing.Point(33, 462);
            this.bigRedButtonTEMP.Name = "bigRedButtonTEMP";
            this.bigRedButtonTEMP.Size = new System.Drawing.Size(156, 41);
            this.bigRedButtonTEMP.TabIndex = 0;
            this.bigRedButtonTEMP.Text = "Create template";
            this.bigRedButtonTEMP.UseVisualStyleBackColor = false;
            this.bigRedButtonTEMP.Click += new System.EventHandler(this.bigRedButtonTEMP_Click);
            // 
            // btnNewFeedback
            // 
            this.btnNewFeedback.BackColor = System.Drawing.Color.Gray;
            this.btnNewFeedback.FlatAppearance.BorderSize = 0;
            this.btnNewFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewFeedback.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewFeedback.ForeColor = System.Drawing.Color.White;
            this.btnNewFeedback.Location = new System.Drawing.Point(444, 462);
            this.btnNewFeedback.Name = "btnNewFeedback";
            this.btnNewFeedback.Size = new System.Drawing.Size(156, 41);
            this.btnNewFeedback.TabIndex = 1;
            this.btnNewFeedback.Text = "New feedback";
            this.btnNewFeedback.UseVisualStyleBackColor = false;
            this.btnNewFeedback.Click += new System.EventHandler(this.btnNewFeedback_Click);
            // 
            // btnEditTemplate
            // 
            this.btnEditTemplate.BackColor = System.Drawing.Color.Gray;
            this.btnEditTemplate.FlatAppearance.BorderSize = 0;
            this.btnEditTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTemplate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTemplate.ForeColor = System.Drawing.Color.White;
            this.btnEditTemplate.Location = new System.Drawing.Point(226, 463);
            this.btnEditTemplate.Name = "btnEditTemplate";
            this.btnEditTemplate.Size = new System.Drawing.Size(164, 39);
            this.btnEditTemplate.TabIndex = 2;
            this.btnEditTemplate.Text = "Edit Template";
            this.btnEditTemplate.UseVisualStyleBackColor = false;
            this.btnEditTemplate.Click += new System.EventHandler(this.btnEditTemplate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::HappyTechFeedbackGenerator.Properties.Resources.happyTechLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 137);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(254, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Main Menu";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyTechFeedbackGenerator.Properties.Resources.appBG;
            this.ClientSize = new System.Drawing.Size(646, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEditTemplate);
            this.Controls.Add(this.btnNewFeedback);
            this.Controls.Add(this.bigRedButtonTEMP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bigRedButtonTEMP;
        private System.Windows.Forms.Button btnNewFeedback;
        private System.Windows.Forms.Button btnEditTemplate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}


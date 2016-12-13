namespace HappyTechFeedbackGenerator
{
    partial class frmTagContent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTagContent));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnAddText = new System.Windows.Forms.Button();
            this.btnPreviousTag = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNextTag = new System.Windows.Forms.Button();
            this.tbxEdit = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnRemoveText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Selected tag: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Gray;
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(803, 543);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(161, 32);
            this.btnFinish.TabIndex = 13;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnAddText
            // 
            this.btnAddText.BackColor = System.Drawing.Color.Gray;
            this.btnAddText.FlatAppearance.BorderSize = 0;
            this.btnAddText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddText.ForeColor = System.Drawing.Color.White;
            this.btnAddText.Location = new System.Drawing.Point(302, 543);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(161, 32);
            this.btnAddText.TabIndex = 12;
            this.btnAddText.Text = "Add text";
            this.btnAddText.UseVisualStyleBackColor = false;
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);
            // 
            // btnPreviousTag
            // 
            this.btnPreviousTag.BackColor = System.Drawing.Color.Gray;
            this.btnPreviousTag.FlatAppearance.BorderSize = 0;
            this.btnPreviousTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousTag.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousTag.ForeColor = System.Drawing.Color.White;
            this.btnPreviousTag.Location = new System.Drawing.Point(469, 543);
            this.btnPreviousTag.Name = "btnPreviousTag";
            this.btnPreviousTag.Size = new System.Drawing.Size(161, 32);
            this.btnPreviousTag.TabIndex = 11;
            this.btnPreviousTag.Text = "Previous Tag";
            this.btnPreviousTag.UseVisualStyleBackColor = false;
            this.btnPreviousTag.Click += new System.EventHandler(this.btnPreviousTag_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(43, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(526, 472);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnNextTag
            // 
            this.btnNextTag.BackColor = System.Drawing.Color.Gray;
            this.btnNextTag.FlatAppearance.BorderSize = 0;
            this.btnNextTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextTag.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextTag.ForeColor = System.Drawing.Color.White;
            this.btnNextTag.Location = new System.Drawing.Point(636, 543);
            this.btnNextTag.Name = "btnNextTag";
            this.btnNextTag.Size = new System.Drawing.Size(161, 32);
            this.btnNextTag.TabIndex = 9;
            this.btnNextTag.Text = "Next Tag";
            this.btnNextTag.UseVisualStyleBackColor = false;
            this.btnNextTag.Click += new System.EventHandler(this.btnNextTag_Click);
            // 
            // tbxEdit
            // 
            this.tbxEdit.Location = new System.Drawing.Point(597, 44);
            this.tbxEdit.Name = "tbxEdit";
            this.tbxEdit.Size = new System.Drawing.Size(504, 20);
            this.tbxEdit.TabIndex = 15;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.Location = new System.Drawing.Point(597, 81);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(504, 435);
            this.dataGridView2.TabIndex = 16;
            // 
            // btnRemoveText
            // 
            this.btnRemoveText.BackColor = System.Drawing.Color.Gray;
            this.btnRemoveText.FlatAppearance.BorderSize = 0;
            this.btnRemoveText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveText.ForeColor = System.Drawing.Color.White;
            this.btnRemoveText.Location = new System.Drawing.Point(135, 543);
            this.btnRemoveText.Name = "btnRemoveText";
            this.btnRemoveText.Size = new System.Drawing.Size(161, 32);
            this.btnRemoveText.TabIndex = 17;
            this.btnRemoveText.Text = "Remove Text";
            this.btnRemoveText.UseVisualStyleBackColor = false;
            this.btnRemoveText.Click += new System.EventHandler(this.btnRemoveText_Click);
            // 
            // frmTagContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyTechFeedbackGenerator.Properties.Resources.appBG;
            this.ClientSize = new System.Drawing.Size(1146, 609);
            this.Controls.Add(this.btnRemoveText);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tbxEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnAddText);
            this.Controls.Add(this.btnPreviousTag);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNextTag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTagContent";
            this.Text = "Tag Content Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.Button btnPreviousTag;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNextTag;
        private System.Windows.Forms.TextBox tbxEdit;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnRemoveText;
    }
}
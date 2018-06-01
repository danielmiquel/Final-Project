namespace ProyectoFinal
{
    partial class ChildList
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
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.clbChildren = new System.Windows.Forms.CheckedListBox();
            this.btShow = new System.Windows.Forms.Button();
            this.btNormalDiet = new System.Windows.Forms.Button();
            this.btAllergiesDiet = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.tbTotalChildren = new System.Windows.Forms.TextBox();
            this.lbTotalChildren = new System.Windows.Forms.Label();
            this.lbTotalFemale = new System.Windows.Forms.Label();
            this.tbTotalFemale = new System.Windows.Forms.TextBox();
            this.lbTotalMens = new System.Windows.Forms.Label();
            this.tbTotalMens = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(533, 82);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(200, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add Child";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(533, 164);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(200, 23);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Edit Child";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(533, 239);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(200, 23);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete Child";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // clbChildren
            // 
            this.clbChildren.CheckOnClick = true;
            this.clbChildren.FormattingEnabled = true;
            this.clbChildren.Location = new System.Drawing.Point(175, 82);
            this.clbChildren.Name = "clbChildren";
            this.clbChildren.Size = new System.Drawing.Size(288, 544);
            this.clbChildren.TabIndex = 3;
            this.clbChildren.SelectedIndexChanged += new System.EventHandler(this.clbChildren_SelectedIndexChanged);
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(533, 322);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(200, 23);
            this.btShow.TabIndex = 4;
            this.btShow.Text = "Show Child";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // btNormalDiet
            // 
            this.btNormalDiet.Location = new System.Drawing.Point(533, 409);
            this.btNormalDiet.Name = "btNormalDiet";
            this.btNormalDiet.Size = new System.Drawing.Size(200, 23);
            this.btNormalDiet.TabIndex = 5;
            this.btNormalDiet.Text = "General Diet";
            this.btNormalDiet.UseVisualStyleBackColor = true;
            this.btNormalDiet.Click += new System.EventHandler(this.btNormalDiet_Click);
            // 
            // btAllergiesDiet
            // 
            this.btAllergiesDiet.Location = new System.Drawing.Point(533, 492);
            this.btAllergiesDiet.Name = "btAllergiesDiet";
            this.btAllergiesDiet.Size = new System.Drawing.Size(200, 23);
            this.btAllergiesDiet.TabIndex = 6;
            this.btAllergiesDiet.Text = "Diet with allergies";
            this.btAllergiesDiet.UseVisualStyleBackColor = true;
            this.btAllergiesDiet.Click += new System.EventHandler(this.btAllergiesDiet_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(41, 82);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 23);
            this.btRefresh.TabIndex = 7;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // tbTotalChildren
            // 
            this.tbTotalChildren.Location = new System.Drawing.Point(106, 167);
            this.tbTotalChildren.Name = "tbTotalChildren";
            this.tbTotalChildren.ReadOnly = true;
            this.tbTotalChildren.Size = new System.Drawing.Size(45, 20);
            this.tbTotalChildren.TabIndex = 8;
            this.tbTotalChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTotalChildren
            // 
            this.lbTotalChildren.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalChildren.AutoSize = true;
            this.lbTotalChildren.Location = new System.Drawing.Point(12, 170);
            this.lbTotalChildren.Name = "lbTotalChildren";
            this.lbTotalChildren.Size = new System.Drawing.Size(72, 13);
            this.lbTotalChildren.TabIndex = 30;
            this.lbTotalChildren.Text = "Total Children";
            // 
            // lbTotalFemale
            // 
            this.lbTotalFemale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalFemale.AutoSize = true;
            this.lbTotalFemale.Location = new System.Drawing.Point(12, 235);
            this.lbTotalFemale.Name = "lbTotalFemale";
            this.lbTotalFemale.Size = new System.Drawing.Size(71, 13);
            this.lbTotalFemale.TabIndex = 32;
            this.lbTotalFemale.Text = "Total Women";
            // 
            // tbTotalFemale
            // 
            this.tbTotalFemale.Location = new System.Drawing.Point(106, 232);
            this.tbTotalFemale.Name = "tbTotalFemale";
            this.tbTotalFemale.ReadOnly = true;
            this.tbTotalFemale.Size = new System.Drawing.Size(45, 20);
            this.tbTotalFemale.TabIndex = 31;
            this.tbTotalFemale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTotalMens
            // 
            this.lbTotalMens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalMens.AutoSize = true;
            this.lbTotalMens.Location = new System.Drawing.Point(12, 298);
            this.lbTotalMens.Name = "lbTotalMens";
            this.lbTotalMens.Size = new System.Drawing.Size(60, 13);
            this.lbTotalMens.TabIndex = 34;
            this.lbTotalMens.Text = "Total Mens";
            // 
            // tbTotalMens
            // 
            this.tbTotalMens.Location = new System.Drawing.Point(106, 295);
            this.tbTotalMens.Name = "tbTotalMens";
            this.tbTotalMens.ReadOnly = true;
            this.tbTotalMens.Size = new System.Drawing.Size(45, 20);
            this.tbTotalMens.TabIndex = 33;
            this.tbTotalMens.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Bradley Hand ITC", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lbTitle.ForeColor = System.Drawing.Color.Blue;
            this.lbTitle.Location = new System.Drawing.Point(342, 7);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(121, 43);
            this.lbTitle.TabIndex = 35;
            this.lbTitle.Text = "BLIST";
            // 
            // ChildList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 687);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbTotalMens);
            this.Controls.Add(this.tbTotalMens);
            this.Controls.Add(this.lbTotalFemale);
            this.Controls.Add(this.tbTotalFemale);
            this.Controls.Add(this.lbTotalChildren);
            this.Controls.Add(this.tbTotalChildren);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btAllergiesDiet);
            this.Controls.Add(this.btNormalDiet);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.clbChildren);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.MaximumSize = new System.Drawing.Size(800, 900);
            this.MinimumSize = new System.Drawing.Size(800, 726);
            this.Name = "ChildList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BLIST - Index";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Button btNormalDiet;
        private System.Windows.Forms.Button btAllergiesDiet;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.TextBox tbTotalChildren;
        private System.Windows.Forms.Label lbTotalChildren;
        private System.Windows.Forms.Label lbTotalFemale;
        private System.Windows.Forms.TextBox tbTotalFemale;
        private System.Windows.Forms.Label lbTotalMens;
        private System.Windows.Forms.TextBox tbTotalMens;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.CheckedListBox clbChildren;
    }
}
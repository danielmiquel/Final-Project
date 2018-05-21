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
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(503, 78);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(628, 78);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(503, 177);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // clbChildren
            // 
            this.clbChildren.FormattingEnabled = true;
            this.clbChildren.Location = new System.Drawing.Point(140, 78);
            this.clbChildren.Name = "clbChildren";
            this.clbChildren.Size = new System.Drawing.Size(288, 529);
            this.clbChildren.TabIndex = 3;
            this.clbChildren.SelectedIndexChanged += new System.EventHandler(this.clbChildren_SelectedIndexChanged);
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(628, 177);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(75, 23);
            this.btShow.TabIndex = 4;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            // 
            // btNormalDiet
            // 
            this.btNormalDiet.Location = new System.Drawing.Point(503, 258);
            this.btNormalDiet.Name = "btNormalDiet";
            this.btNormalDiet.Size = new System.Drawing.Size(200, 23);
            this.btNormalDiet.TabIndex = 5;
            this.btNormalDiet.Text = "Diet";
            this.btNormalDiet.UseVisualStyleBackColor = true;
            this.btNormalDiet.Click += new System.EventHandler(this.btNormalDiet_Click);
            // 
            // btAllergiesDiet
            // 
            this.btAllergiesDiet.Location = new System.Drawing.Point(503, 341);
            this.btAllergiesDiet.Name = "btAllergiesDiet";
            this.btAllergiesDiet.Size = new System.Drawing.Size(200, 23);
            this.btAllergiesDiet.TabIndex = 6;
            this.btAllergiesDiet.Text = "Diet with allergies";
            this.btAllergiesDiet.UseVisualStyleBackColor = true;
            this.btAllergiesDiet.Click += new System.EventHandler(this.btAllergiesDiet_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(27, 28);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 23);
            this.btRefresh.TabIndex = 7;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // ChildList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btAllergiesDiet);
            this.Controls.Add(this.btNormalDiet);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.clbChildren);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Name = "ChildList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.CheckedListBox clbChildren;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Button btNormalDiet;
        private System.Windows.Forms.Button btAllergiesDiet;
        private System.Windows.Forms.Button btRefresh;
    }
}
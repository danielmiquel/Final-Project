namespace ProyectoFinal
{
    partial class WarningInvalidDate
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
            this.btOk = new System.Windows.Forms.Button();
            this.lbWarningInvalidDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(121, 73);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 3;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // lbWarningInvalidDate
            // 
            this.lbWarningInvalidDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWarningInvalidDate.AutoSize = true;
            this.lbWarningInvalidDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarningInvalidDate.Location = new System.Drawing.Point(82, 35);
            this.lbWarningInvalidDate.Name = "lbWarningInvalidDate";
            this.lbWarningInvalidDate.Size = new System.Drawing.Size(155, 20);
            this.lbWarningInvalidDate.TabIndex = 2;
            this.lbWarningInvalidDate.Text = "Warning, invalid date";
            this.lbWarningInvalidDate.Click += new System.EventHandler(this.lbWarningInvalidDate_Click);
            // 
            // WarningInvalidDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 128);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lbWarningInvalidDate);
            this.Name = "WarningInvalidDate";
            this.Text = "WarningInvalidDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label lbWarningInvalidDate;
    }
}
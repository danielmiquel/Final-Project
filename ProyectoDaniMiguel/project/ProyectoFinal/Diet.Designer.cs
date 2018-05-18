namespace ProyectoFinal
{
    partial class Diet
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
            this.lbDiet = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbDiet
            // 
            this.lbDiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiet.FormattingEnabled = true;
            this.lbDiet.HorizontalScrollbar = true;
            this.lbDiet.ItemHeight = 20;
            this.lbDiet.Location = new System.Drawing.Point(29, 22);
            this.lbDiet.MultiColumn = true;
            this.lbDiet.Name = "lbDiet";
            this.lbDiet.Size = new System.Drawing.Size(436, 244);
            this.lbDiet.TabIndex = 0;
            // 
            // Diet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 299);
            this.Controls.Add(this.lbDiet);
            this.Name = "Diet";
            this.Text = "Diet";
            this.Load += new System.EventHandler(this.Diet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDiet;
    }
}
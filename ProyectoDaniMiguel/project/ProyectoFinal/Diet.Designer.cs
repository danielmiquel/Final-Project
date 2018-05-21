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
            this.tbBreak = new System.Windows.Forms.TextBox();
            this.tbSnack = new System.Windows.Forms.TextBox();
            this.tbLunch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBreak
            // 
            this.tbBreak.Location = new System.Drawing.Point(85, 28);
            this.tbBreak.Name = "tbBreak";
            this.tbBreak.ReadOnly = true;
            this.tbBreak.Size = new System.Drawing.Size(387, 20);
            this.tbBreak.TabIndex = 0;
            this.tbBreak.TextChanged += new System.EventHandler(this.tbBreak_TextChanged);
            // 
            // tbSnack
            // 
            this.tbSnack.Location = new System.Drawing.Point(85, 137);
            this.tbSnack.Name = "tbSnack";
            this.tbSnack.ReadOnly = true;
            this.tbSnack.Size = new System.Drawing.Size(387, 20);
            this.tbSnack.TabIndex = 1;
            this.tbSnack.TextChanged += new System.EventHandler(this.tbSnack_TextChanged);
            // 
            // tbLunch
            // 
            this.tbLunch.Location = new System.Drawing.Point(85, 84);
            this.tbLunch.Name = "tbLunch";
            this.tbLunch.ReadOnly = true;
            this.tbLunch.Size = new System.Drawing.Size(387, 20);
            this.tbLunch.TabIndex = 2;
            this.tbLunch.TextChanged += new System.EventHandler(this.tbLunch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Breakfast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lunch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Snack";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(277, 192);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(161, 192);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(75, 23);
            this.btChange.TabIndex = 7;
            this.btChange.Text = "Change";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // Diet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 241);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLunch);
            this.Controls.Add(this.tbSnack);
            this.Controls.Add(this.tbBreak);
            this.Name = "Diet";
            this.Text = "Diet";
            this.Load += new System.EventHandler(this.Diet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBreak;
        private System.Windows.Forms.TextBox tbSnack;
        private System.Windows.Forms.TextBox tbLunch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btChange;
    }
}
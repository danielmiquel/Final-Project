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
            this.lbB = new System.Windows.Forms.Label();
            this.lbL = new System.Windows.Forms.Label();
            this.lbS = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.cbSnack = new System.Windows.Forms.CheckBox();
            this.cbLunch = new System.Windows.Forms.CheckBox();
            this.cbBreakfast = new System.Windows.Forms.CheckBox();
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
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(27, 31);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(52, 13);
            this.lbB.TabIndex = 3;
            this.lbB.Text = "Breakfast";
            // 
            // lbL
            // 
            this.lbL.AutoSize = true;
            this.lbL.Location = new System.Drawing.Point(27, 87);
            this.lbL.Name = "lbL";
            this.lbL.Size = new System.Drawing.Size(37, 13);
            this.lbL.TabIndex = 4;
            this.lbL.Text = "Lunch";
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Location = new System.Drawing.Point(27, 140);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(38, 13);
            this.lbS.TabIndex = 5;
            this.lbS.Text = "Snack";
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
            // cbSnack
            // 
            this.cbSnack.AutoSize = true;
            this.cbSnack.Location = new System.Drawing.Point(490, 140);
            this.cbSnack.Name = "cbSnack";
            this.cbSnack.Size = new System.Drawing.Size(15, 14);
            this.cbSnack.TabIndex = 21;
            this.cbSnack.UseVisualStyleBackColor = true;
            // 
            // cbLunch
            // 
            this.cbLunch.AutoSize = true;
            this.cbLunch.Location = new System.Drawing.Point(490, 86);
            this.cbLunch.Name = "cbLunch";
            this.cbLunch.Size = new System.Drawing.Size(15, 14);
            this.cbLunch.TabIndex = 20;
            this.cbLunch.UseVisualStyleBackColor = true;
            // 
            // cbBreakfast
            // 
            this.cbBreakfast.AutoSize = true;
            this.cbBreakfast.Location = new System.Drawing.Point(490, 31);
            this.cbBreakfast.Name = "cbBreakfast";
            this.cbBreakfast.Size = new System.Drawing.Size(15, 14);
            this.cbBreakfast.TabIndex = 19;
            this.cbBreakfast.UseVisualStyleBackColor = true;
            // 
            // Diet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(530, 241);
            this.Controls.Add(this.cbSnack);
            this.Controls.Add(this.cbLunch);
            this.Controls.Add(this.cbBreakfast);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lbS);
            this.Controls.Add(this.lbL);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.tbLunch);
            this.Controls.Add(this.tbSnack);
            this.Controls.Add(this.tbBreak);
            this.Name = "Diet";
            this.Text = "BLIST - General Diet";
            this.Load += new System.EventHandler(this.Diet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBreak;
        private System.Windows.Forms.TextBox tbSnack;
        private System.Windows.Forms.TextBox tbLunch;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbL;
        private System.Windows.Forms.Label lbS;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.CheckBox cbSnack;
        private System.Windows.Forms.CheckBox cbLunch;
        private System.Windows.Forms.CheckBox cbBreakfast;
    }
}
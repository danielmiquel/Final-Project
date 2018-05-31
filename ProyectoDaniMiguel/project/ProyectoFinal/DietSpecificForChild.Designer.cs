namespace ProyectoFinal
{
    partial class DietSpecificForChild
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
            this.lbInfoChild = new System.Windows.Forms.Label();
            this.btChange = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.lbS = new System.Windows.Forms.Label();
            this.lbL = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.tbLunch = new System.Windows.Forms.TextBox();
            this.tbSnack = new System.Windows.Forms.TextBox();
            this.tbBreak = new System.Windows.Forms.TextBox();
            this.cbBreakfast = new System.Windows.Forms.CheckBox();
            this.cbLunch = new System.Windows.Forms.CheckBox();
            this.cbSnack = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbInfoChild
            // 
            this.lbInfoChild.AutoSize = true;
            this.lbInfoChild.Location = new System.Drawing.Point(33, 30);
            this.lbInfoChild.Name = "lbInfoChild";
            this.lbInfoChild.Size = new System.Drawing.Size(0, 13);
            this.lbInfoChild.TabIndex = 0;
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(167, 237);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(75, 23);
            this.btChange.TabIndex = 15;
            this.btChange.Text = "Change";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(283, 237);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 14;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Location = new System.Drawing.Point(33, 185);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(38, 13);
            this.lbS.TabIndex = 13;
            this.lbS.Text = "Snack";
            // 
            // lbL
            // 
            this.lbL.AutoSize = true;
            this.lbL.Location = new System.Drawing.Point(33, 132);
            this.lbL.Name = "lbL";
            this.lbL.Size = new System.Drawing.Size(37, 13);
            this.lbL.TabIndex = 12;
            this.lbL.Text = "Lunch";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(33, 76);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(52, 13);
            this.lbB.TabIndex = 11;
            this.lbB.Text = "Breakfast";
            // 
            // tbLunch
            // 
            this.tbLunch.Location = new System.Drawing.Point(91, 129);
            this.tbLunch.Name = "tbLunch";
            this.tbLunch.ReadOnly = true;
            this.tbLunch.Size = new System.Drawing.Size(387, 20);
            this.tbLunch.TabIndex = 10;
            // 
            // tbSnack
            // 
            this.tbSnack.Location = new System.Drawing.Point(91, 182);
            this.tbSnack.Name = "tbSnack";
            this.tbSnack.ReadOnly = true;
            this.tbSnack.Size = new System.Drawing.Size(387, 20);
            this.tbSnack.TabIndex = 9;
            // 
            // tbBreak
            // 
            this.tbBreak.Location = new System.Drawing.Point(91, 73);
            this.tbBreak.Name = "tbBreak";
            this.tbBreak.ReadOnly = true;
            this.tbBreak.Size = new System.Drawing.Size(387, 20);
            this.tbBreak.TabIndex = 8;
            // 
            // cbBreakfast
            // 
            this.cbBreakfast.AutoSize = true;
            this.cbBreakfast.Location = new System.Drawing.Point(484, 76);
            this.cbBreakfast.Name = "cbBreakfast";
            this.cbBreakfast.Size = new System.Drawing.Size(15, 14);
            this.cbBreakfast.TabIndex = 16;
            this.cbBreakfast.UseVisualStyleBackColor = true;
            // 
            // cbLunch
            // 
            this.cbLunch.AutoSize = true;
            this.cbLunch.Location = new System.Drawing.Point(484, 131);
            this.cbLunch.Name = "cbLunch";
            this.cbLunch.Size = new System.Drawing.Size(15, 14);
            this.cbLunch.TabIndex = 17;
            this.cbLunch.UseVisualStyleBackColor = true;
            // 
            // cbSnack
            // 
            this.cbSnack.AutoSize = true;
            this.cbSnack.Location = new System.Drawing.Point(484, 185);
            this.cbSnack.Name = "cbSnack";
            this.cbSnack.Size = new System.Drawing.Size(15, 14);
            this.cbSnack.TabIndex = 18;
            this.cbSnack.UseVisualStyleBackColor = true;
            // 
            // DietSpecificForChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(516, 298);
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
            this.Controls.Add(this.lbInfoChild);
            this.Name = "DietSpecificForChild";
            this.Text = "BLIST - Diet Specific For Child";
            this.Load += new System.EventHandler(this.DietSpecificForChild_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfoChild;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label lbS;
        private System.Windows.Forms.Label lbL;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox tbLunch;
        private System.Windows.Forms.TextBox tbSnack;
        private System.Windows.Forms.TextBox tbBreak;
        private System.Windows.Forms.CheckBox cbBreakfast;
        private System.Windows.Forms.CheckBox cbLunch;
        private System.Windows.Forms.CheckBox cbSnack;
    }
}
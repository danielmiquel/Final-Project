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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLunch = new System.Windows.Forms.TextBox();
            this.tbSnack = new System.Windows.Forms.TextBox();
            this.tbBreak = new System.Windows.Forms.TextBox();
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
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(283, 237);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 14;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Snack";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lunch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Breakfast";
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
            // DietSpecificForChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 298);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLunch);
            this.Controls.Add(this.tbSnack);
            this.Controls.Add(this.tbBreak);
            this.Controls.Add(this.lbInfoChild);
            this.Name = "DietSpecificForChild";
            this.Text = "DietSpecificForChild";
            this.Load += new System.EventHandler(this.DietSpecificForChild_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfoChild;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLunch;
        private System.Windows.Forms.TextBox tbSnack;
        private System.Windows.Forms.TextBox tbBreak;
    }
}
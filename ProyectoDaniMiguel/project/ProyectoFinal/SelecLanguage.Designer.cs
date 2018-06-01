namespace ProyectoFinal
{
    partial class SelectLenguage
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
            this.btEnglish = new System.Windows.Forms.Button();
            this.btCastellano = new System.Windows.Forms.Button();
            this.lbTitle1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btEnglish
            // 
            this.btEnglish.Location = new System.Drawing.Point(80, 100);
            this.btEnglish.Name = "btEnglish";
            this.btEnglish.Size = new System.Drawing.Size(130, 23);
            this.btEnglish.TabIndex = 0;
            this.btEnglish.Text = "English";
            this.btEnglish.UseVisualStyleBackColor = true;
            this.btEnglish.Click += new System.EventHandler(this.btEnglish_Click);
            // 
            // btCastellano
            // 
            this.btCastellano.Location = new System.Drawing.Point(80, 155);
            this.btCastellano.Name = "btCastellano";
            this.btCastellano.Size = new System.Drawing.Size(130, 23);
            this.btCastellano.TabIndex = 1;
            this.btCastellano.Text = "Castellano";
            this.btCastellano.UseVisualStyleBackColor = true;
            this.btCastellano.Click += new System.EventHandler(this.btCastellano_Click);
            // 
            // lbTitle1
            // 
            this.lbTitle1.AutoSize = true;
            this.lbTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle1.Location = new System.Drawing.Point(4, 59);
            this.lbTitle1.Name = "lbTitle1";
            this.lbTitle1.Size = new System.Drawing.Size(268, 20);
            this.lbTitle1.TabIndex = 2;
            this.lbTitle1.Text = "Select  Language / Seleciona Idioma";
            // 
            // SelectLenguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbTitle1);
            this.Controls.Add(this.btCastellano);
            this.Controls.Add(this.btEnglish);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "SelectLenguage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lenguage / Idioma";
            this.Load += new System.EventHandler(this.SelectLenguage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEnglish;
        private System.Windows.Forms.Button btCastellano;
        private System.Windows.Forms.Label lbTitle1;
    }
}
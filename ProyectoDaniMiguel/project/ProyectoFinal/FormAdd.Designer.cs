namespace ProyectoFinal
{
    partial class FormAdd
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbCod = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurnames = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.lbObservations = new System.Windows.Forms.Label();
            this.tbObservation = new System.Windows.Forms.TextBox();
            this.lbInform = new System.Windows.Forms.Label();
            this.lbAllergy = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.clbVegFrt = new System.Windows.Forms.CheckedListBox();
            this.tbSex = new System.Windows.Forms.TextBox();
            this.dtpAge = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(102, 54);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.Location = new System.Drawing.Point(235, 162);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(26, 13);
            this.lbCod.TabIndex = 1;
            this.lbCod.Text = "Cod";
            this.lbCod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(334, 54);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(54, 13);
            this.lbSurname.TabIndex = 2;
            this.lbSurname.Text = "Surnames";
            this.lbSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(349, 111);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(25, 13);
            this.lbSex.TabIndex = 3;
            this.lbSex.Text = "Sex";
            this.lbSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(92, 108);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(45, 13);
            this.lbBirthday.TabIndex = 4;
            this.lbBirthday.Text = "Birthday";
            this.lbBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 70);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(228, 20);
            this.tbName.TabIndex = 7;
            // 
            // tbSurnames
            // 
            this.tbSurnames.Location = new System.Drawing.Point(257, 70);
            this.tbSurnames.Name = "tbSurnames";
            this.tbSurnames.Size = new System.Drawing.Size(228, 20);
            this.tbSurnames.TabIndex = 8;
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(146, 178);
            this.tbCod.Name = "tbCod";
            this.tbCod.ReadOnly = true;
            this.tbCod.Size = new System.Drawing.Size(228, 20);
            this.tbCod.TabIndex = 11;
            // 
            // lbObservations
            // 
            this.lbObservations.AutoSize = true;
            this.lbObservations.Location = new System.Drawing.Point(220, 215);
            this.lbObservations.Name = "lbObservations";
            this.lbObservations.Size = new System.Drawing.Size(69, 13);
            this.lbObservations.TabIndex = 12;
            this.lbObservations.Text = "Observations";
            this.lbObservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbObservation
            // 
            this.tbObservation.Location = new System.Drawing.Point(146, 231);
            this.tbObservation.Multiline = true;
            this.tbObservation.Name = "tbObservation";
            this.tbObservation.Size = new System.Drawing.Size(228, 111);
            this.tbObservation.TabIndex = 13;
            // 
            // lbInform
            // 
            this.lbInform.AutoSize = true;
            this.lbInform.Location = new System.Drawing.Point(193, 13);
            this.lbInform.Name = "lbInform";
            this.lbInform.Size = new System.Drawing.Size(59, 13);
            this.lbInform.TabIndex = 36;
            this.lbInform.Text = "Information";
            // 
            // lbAllergy
            // 
            this.lbAllergy.AutoSize = true;
            this.lbAllergy.Location = new System.Drawing.Point(605, 13);
            this.lbAllergy.Name = "lbAllergy";
            this.lbAllergy.Size = new System.Drawing.Size(38, 13);
            this.lbAllergy.TabIndex = 37;
            this.lbAllergy.Text = "Allergy";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(583, 307);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 38;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // clbVegFrt
            // 
            this.clbVegFrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clbVegFrt.CheckOnClick = true;
            this.clbVegFrt.FormattingEnabled = true;
            this.clbVegFrt.HorizontalScrollbar = true;
            this.clbVegFrt.Items.AddRange(new object[] {
            "Almonds",
            "Apple",
            "Carrot",
            "Celery",
            "Eggs",
            "Fish",
            "Lactose",
            "Leek",
            "Lettuce",
            "Meat proteins",
            "Melon",
            "Orange",
            "Pear",
            "Penauts",
            "Potato",
            "Seafood",
            "Soy",
            "Spinach",
            "Strawberry",
            "Tomato",
            "Turnip",
            "Watermelon",
            "Wheat",
            "Zucchini"});
            this.clbVegFrt.Location = new System.Drawing.Point(517, 46);
            this.clbVegFrt.MultiColumn = true;
            this.clbVegFrt.Name = "clbVegFrt";
            this.clbVegFrt.Size = new System.Drawing.Size(211, 229);
            this.clbVegFrt.Sorted = true;
            this.clbVegFrt.TabIndex = 47;
            // 
            // tbSex
            // 
            this.tbSex.Location = new System.Drawing.Point(257, 127);
            this.tbSex.Name = "tbSex";
            this.tbSex.Size = new System.Drawing.Size(228, 20);
            this.tbSex.TabIndex = 10;
            // 
            // dtpAge
            // 
            this.dtpAge.Location = new System.Drawing.Point(12, 124);
            this.dtpAge.Name = "dtpAge";
            this.dtpAge.Size = new System.Drawing.Size(227, 20);
            this.dtpAge.TabIndex = 48;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.dtpAge);
            this.Controls.Add(this.clbVegFrt);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbAllergy);
            this.Controls.Add(this.lbInform);
            this.Controls.Add(this.tbObservation);
            this.Controls.Add(this.lbObservations);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.tbSex);
            this.Controls.Add(this.tbSurnames);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbBirthday);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbCod);
            this.Controls.Add(this.lbName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 420);
            this.MinimumSize = new System.Drawing.Size(800, 420);
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BLIST - Add Child";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCod;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurnames;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label lbObservations;
        private System.Windows.Forms.TextBox tbObservation;
        private System.Windows.Forms.Label lbInform;
        private System.Windows.Forms.Label lbAllergy;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.CheckedListBox clbVegFrt;
        private System.Windows.Forms.TextBox tbSex;
        private System.Windows.Forms.DateTimePicker dtpAge;
    }
}
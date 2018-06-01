namespace ProyectoFinal
{
    partial class FormEdit
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
            this.clbVegFrt = new System.Windows.Forms.CheckedListBox();
            this.btOK = new System.Windows.Forms.Button();
            this.lbAllergy = new System.Windows.Forms.Label();
            this.lbInform = new System.Windows.Forms.Label();
            this.tbObservation = new System.Windows.Forms.TextBox();
            this.lbObservations = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tbSex = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbSurnames = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbCod = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTypeAge = new System.Windows.Forms.Label();
            this.dtpAge = new System.Windows.Forms.DateTimePicker();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            "Chicken",
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
            this.clbVegFrt.Location = new System.Drawing.Point(527, 58);
            this.clbVegFrt.MultiColumn = true;
            this.clbVegFrt.Name = "clbVegFrt";
            this.clbVegFrt.Size = new System.Drawing.Size(211, 229);
            this.clbVegFrt.Sorted = true;
            this.clbVegFrt.TabIndex = 63;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(593, 319);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 62;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // lbAllergy
            // 
            this.lbAllergy.AutoSize = true;
            this.lbAllergy.Location = new System.Drawing.Point(615, 25);
            this.lbAllergy.Name = "lbAllergy";
            this.lbAllergy.Size = new System.Drawing.Size(38, 13);
            this.lbAllergy.TabIndex = 61;
            this.lbAllergy.Text = "Allergy";
            // 
            // lbInform
            // 
            this.lbInform.AutoSize = true;
            this.lbInform.Location = new System.Drawing.Point(216, 9);
            this.lbInform.Name = "lbInform";
            this.lbInform.Size = new System.Drawing.Size(59, 13);
            this.lbInform.TabIndex = 60;
            this.lbInform.Text = "Information";
            // 
            // tbObservation
            // 
            this.tbObservation.Location = new System.Drawing.Point(152, 244);
            this.tbObservation.Multiline = true;
            this.tbObservation.Name = "tbObservation";
            this.tbObservation.Size = new System.Drawing.Size(228, 111);
            this.tbObservation.TabIndex = 59;
            // 
            // lbObservations
            // 
            this.lbObservations.AutoSize = true;
            this.lbObservations.Location = new System.Drawing.Point(227, 217);
            this.lbObservations.Name = "lbObservations";
            this.lbObservations.Size = new System.Drawing.Size(69, 13);
            this.lbObservations.TabIndex = 58;
            this.lbObservations.Text = "Observations";
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(270, 176);
            this.tbCod.Name = "tbCod";
            this.tbCod.ReadOnly = true;
            this.tbCod.Size = new System.Drawing.Size(228, 20);
            this.tbCod.TabIndex = 57;
            // 
            // tbSex
            // 
            this.tbSex.Location = new System.Drawing.Point(7, 176);
            this.tbSex.Name = "tbSex";
            this.tbSex.Size = new System.Drawing.Size(228, 20);
            this.tbSex.TabIndex = 56;
            this.tbSex.TextChanged += new System.EventHandler(this.tbSex_TextChanged);
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(275, 123);
            this.tbAge.Name = "tbAge";
            this.tbAge.ReadOnly = true;
            this.tbAge.Size = new System.Drawing.Size(37, 20);
            this.tbAge.TabIndex = 55;
            this.tbAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSurnames
            // 
            this.tbSurnames.Location = new System.Drawing.Point(270, 58);
            this.tbSurnames.Name = "tbSurnames";
            this.tbSurnames.Size = new System.Drawing.Size(228, 20);
            this.tbSurnames.TabIndex = 54;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 58);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(228, 20);
            this.tbName.TabIndex = 53;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(286, 107);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(26, 13);
            this.lbAge.TabIndex = 52;
            this.lbAge.Text = "Age";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(96, 160);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(25, 13);
            this.lbSex.TabIndex = 51;
            this.lbSex.Text = "Sex";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(363, 42);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(54, 13);
            this.lbSurname.TabIndex = 50;
            this.lbSurname.Text = "Surnames";
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.Location = new System.Drawing.Point(358, 160);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(26, 13);
            this.lbCod.TabIndex = 49;
            this.lbCod.Text = "Cod";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(101, 42);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 48;
            this.lbName.Text = "Name";
            // 
            // lbTypeAge
            // 
            this.lbTypeAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTypeAge.AutoSize = true;
            this.lbTypeAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeAge.Location = new System.Drawing.Point(318, 126);
            this.lbTypeAge.Name = "lbTypeAge";
            this.lbTypeAge.Size = new System.Drawing.Size(0, 17);
            this.lbTypeAge.TabIndex = 72;
            // 
            // dtpAge
            // 
            this.dtpAge.Checked = false;
            this.dtpAge.Location = new System.Drawing.Point(9, 126);
            this.dtpAge.Name = "dtpAge";
            this.dtpAge.ShowCheckBox = true;
            this.dtpAge.Size = new System.Drawing.Size(227, 20);
            this.dtpAge.TabIndex = 74;
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(101, 110);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(45, 13);
            this.lbBirthday.TabIndex = 73;
            this.lbBirthday.Text = "Birthday";
            // 
            // tbBirthday
            // 
            this.tbBirthday.Location = new System.Drawing.Point(389, 123);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.ReadOnly = true;
            this.tbBirthday.Size = new System.Drawing.Size(109, 20);
            this.tbBirthday.TabIndex = 75;
            this.tbBirthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBirthday.TextChanged += new System.EventHandler(this.tbBirthday_TextChanged);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.tbBirthday);
            this.Controls.Add(this.dtpAge);
            this.Controls.Add(this.lbBirthday);
            this.Controls.Add(this.lbTypeAge);
            this.Controls.Add(this.clbVegFrt);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbAllergy);
            this.Controls.Add(this.lbInform);
            this.Controls.Add(this.tbObservation);
            this.Controls.Add(this.lbObservations);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.tbSex);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbSurnames);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbCod);
            this.Controls.Add(this.lbName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 420);
            this.MinimumSize = new System.Drawing.Size(800, 420);
            this.Name = "FormEdit";
            this.Text = "BLIST - Edit Child";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbVegFrt;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label lbAllergy;
        private System.Windows.Forms.Label lbInform;
        private System.Windows.Forms.TextBox tbObservation;
        private System.Windows.Forms.Label lbObservations;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.TextBox tbSex;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbSurnames;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbCod;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTypeAge;
        private System.Windows.Forms.DateTimePicker dtpAge;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.TextBox tbBirthday;
    }
}
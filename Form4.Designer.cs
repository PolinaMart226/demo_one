namespace demo_one
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSale = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxInn = new System.Windows.Forms.TextBox();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTypeCompany = new System.Windows.Forms.ComboBox();
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbmasterfloorDataSet = new demo_one.dbmasterfloorDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxPartnerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSave_one = new System.Windows.Forms.Button();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxContactNumber = new System.Windows.Forms.TextBox();
            this.textBoxFullnameDirector = new System.Windows.Forms.TextBox();
            this.textBoxNameCompany = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.partnersTableAdapter = new demo_one.dbmasterfloorDataSetTableAdapters.partnersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmasterfloorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label6.Location = new System.Drawing.Point(15, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 31);
            this.label6.TabIndex = 77;
            this.label6.Text = "Сумма (скидка)";
            // 
            // textBoxSale
            // 
            this.textBoxSale.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxSale.Location = new System.Drawing.Point(225, 424);
            this.textBoxSale.Name = "textBoxSale";
            this.textBoxSale.Size = new System.Drawing.Size(444, 38);
            this.textBoxSale.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label5.Location = new System.Drawing.Point(11, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 31);
            this.label5.TabIndex = 75;
            this.label5.Text = "ИНН";
            // 
            // textBoxInn
            // 
            this.textBoxInn.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxInn.Location = new System.Drawing.Point(225, 380);
            this.textBoxInn.Name = "textBoxInn";
            this.textBoxInn.Size = new System.Drawing.Size(444, 38);
            this.textBoxInn.TabIndex = 74;
            // 
            // textBoxRating
            // 
            this.textBoxRating.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxRating.Location = new System.Drawing.Point(225, 160);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(444, 38);
            this.textBoxRating.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label4.Location = new System.Drawing.Point(11, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 31);
            this.label4.TabIndex = 72;
            this.label4.Text = "Email компании";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxEmail.Location = new System.Drawing.Point(225, 336);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(444, 38);
            this.textBoxEmail.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label3.Location = new System.Drawing.Point(39, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 31);
            this.label3.TabIndex = 70;
            this.label3.Text = "Адрес";
            // 
            // comboBoxTypeCompany
            // 
            this.comboBoxTypeCompany.FormattingEnabled = true;
            this.comboBoxTypeCompany.Items.AddRange(new object[] {
            "ЗАО",
            "ООО",
            "ПАО",
            "ОАО"});
            this.comboBoxTypeCompany.Location = new System.Drawing.Point(624, 123);
            this.comboBoxTypeCompany.Name = "comboBoxTypeCompany";
            this.comboBoxTypeCompany.Size = new System.Drawing.Size(199, 24);
            this.comboBoxTypeCompany.TabIndex = 69;
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataMember = "partners";
            this.partnersBindingSource.DataSource = this.dbmasterfloorDataSet;
            // 
            // dbmasterfloorDataSet
            // 
            this.dbmasterfloorDataSet.DataSetName = "dbmasterfloorDataSet";
            this.dbmasterfloorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(638, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(270, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 38);
            this.label2.TabIndex = 67;
            this.label2.Text = "Добавление партнера";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.labelID.Location = new System.Drawing.Point(14, 78);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(36, 31);
            this.labelID.TabIndex = 66;
            this.labelID.Text = "ID";
            // 
            // textBoxPartnerId
            // 
            this.textBoxPartnerId.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxPartnerId.Location = new System.Drawing.Point(123, 75);
            this.textBoxPartnerId.Name = "textBoxPartnerId";
            this.textBoxPartnerId.Size = new System.Drawing.Size(199, 38);
            this.textBoxPartnerId.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label1.Location = new System.Drawing.Point(540, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 31);
            this.label1.TabIndex = 65;
            this.label1.Text = "|";
            // 
            // ButtonSave_one
            // 
            this.ButtonSave_one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.ButtonSave_one.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.ButtonSave_one.Location = new System.Drawing.Point(497, 470);
            this.ButtonSave_one.Name = "ButtonSave_one";
            this.ButtonSave_one.Size = new System.Drawing.Size(171, 50);
            this.ButtonSave_one.TabIndex = 64;
            this.ButtonSave_one.Text = "Сохранить";
            this.ButtonSave_one.UseVisualStyleBackColor = false;
            this.ButtonSave_one.Click += new System.EventHandler(this.ButtonSave_one_Click);
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.labelRating.Location = new System.Drawing.Point(15, 160);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(96, 31);
            this.labelRating.TabIndex = 63;
            this.labelRating.Text = "Рейтинг";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.labelContact.Location = new System.Drawing.Point(21, 295);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(104, 31);
            this.labelContact.TabIndex = 62;
            this.labelContact.Text = "Телефон";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.labelDirector.Location = new System.Drawing.Point(11, 251);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(182, 31);
            this.labelDirector.TabIndex = 61;
            this.labelDirector.Text = "ФИО директора";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.labelName.Location = new System.Drawing.Point(11, 116);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(276, 31);
            this.labelName.TabIndex = 60;
            this.labelName.Text = "Наименование партнера";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.labelType.Location = new System.Drawing.Point(566, 116);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(52, 31);
            this.labelType.TabIndex = 59;
            this.labelType.Text = "Тип";
            // 
            // textBoxContactNumber
            // 
            this.textBoxContactNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxContactNumber.Location = new System.Drawing.Point(225, 292);
            this.textBoxContactNumber.Name = "textBoxContactNumber";
            this.textBoxContactNumber.Size = new System.Drawing.Size(444, 38);
            this.textBoxContactNumber.TabIndex = 58;
            // 
            // textBoxFullnameDirector
            // 
            this.textBoxFullnameDirector.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxFullnameDirector.Location = new System.Drawing.Point(225, 248);
            this.textBoxFullnameDirector.Name = "textBoxFullnameDirector";
            this.textBoxFullnameDirector.Size = new System.Drawing.Size(444, 38);
            this.textBoxFullnameDirector.TabIndex = 57;
            // 
            // textBoxNameCompany
            // 
            this.textBoxNameCompany.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxNameCompany.Location = new System.Drawing.Point(335, 116);
            this.textBoxNameCompany.Name = "textBoxNameCompany";
            this.textBoxNameCompany.Size = new System.Drawing.Size(199, 38);
            this.textBoxNameCompany.TabIndex = 56;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxAddress.Location = new System.Drawing.Point(225, 204);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(444, 38);
            this.textBoxAddress.TabIndex = 55;
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.ButtonBack.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.ButtonBack.Location = new System.Drawing.Point(703, 470);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(171, 50);
            this.ButtonBack.TabIndex = 53;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // partnersTableAdapter
            // 
            this.partnersTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 532);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxInn);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTypeCompany);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxPartnerId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSave_one);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxContactNumber);
            this.Controls.Add(this.textBoxFullnameDirector);
            this.Controls.Add(this.textBoxNameCompany);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.ButtonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма добавления";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmasterfloorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox textBoxSale;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox textBoxInn;
        internal System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTypeCompany;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxPartnerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonSave_one;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxContactNumber;
        private System.Windows.Forms.TextBox textBoxFullnameDirector;
        private System.Windows.Forms.TextBox textBoxNameCompany;
        internal System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button ButtonBack;
        private dbmasterfloorDataSet dbmasterfloorDataSet;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private dbmasterfloorDataSetTableAdapters.partnersTableAdapter partnersTableAdapter;
    }
}
namespace demo_one
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Button1 = new System.Windows.Forms.Button();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.partner_products_historyTableAdapter1 = new demo_one.dbmasterfloorDataSetTableAdapters.partner_products_historyTableAdapter();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSale = new System.Windows.Forms.Label();
            this.textBoxSale = new System.Windows.Forms.TextBox();
            this.ButtonAdd_two = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonModule = new System.Windows.Forms.Button();
            this.Button_rkm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.Button1.Location = new System.Drawing.Point(919, 717);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(171, 50);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Назад";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(136, 516);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(366, 38);
            this.textBoxType.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(821, 520);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(199, 38);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(136, 560);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(366, 38);
            this.textBoxDirector.TabIndex = 5;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(137, 603);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(366, 38);
            this.textBoxContact.TabIndex = 6;
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(137, 647);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(366, 38);
            this.textBoxRating.TabIndex = 7;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(136, 472);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(366, 38);
            this.textBoxId.TabIndex = 0;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(27, 519);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(52, 31);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "Тип";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(19, 563);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(116, 31);
            this.labelDirector.TabIndex = 10;
            this.labelDirector.Text = "Директор";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(25, 606);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(85, 31);
            this.labelContact.TabIndex = 11;
            this.labelContact.Text = "Номер";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(19, 647);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(101, 31);
            this.labelRating.TabIndex = 12;
            this.labelRating.Text = "Рейтинг:";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.ButtonAdd.Location = new System.Drawing.Point(21, 713);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(171, 50);
            this.ButtonAdd.TabIndex = 13;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "|";
            // 
            // partner_products_historyTableAdapter1
            // 
            this.partner_products_historyTableAdapter1.ClearBeforeFill = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(539, 523);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(276, 31);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Наименование партнера";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(27, 475);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(36, 31);
            this.labelID.TabIndex = 16;
            this.labelID.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel);
            this.groupBox1.Location = new System.Drawing.Point(10, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 404);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // panel
            // 
            this.panel.AllowDrop = true;
            this.panel.AutoScroll = true;
            this.panel.AutoSize = true;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(3, 34);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(938, 367);
            this.panel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(268, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 38);
            this.label2.TabIndex = 19;
            this.label2.Text = "Главная. Учет партнеров";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(595, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // labelSale
            // 
            this.labelSale.AutoSize = true;
            this.labelSale.Location = new System.Drawing.Point(539, 592);
            this.labelSale.Name = "labelSale";
            this.labelSale.Size = new System.Drawing.Size(279, 31);
            this.labelSale.TabIndex = 24;
            this.labelSale.Text = "Введите сумму, Скидка %";
            // 
            // textBoxSale
            // 
            this.textBoxSale.Location = new System.Drawing.Point(823, 589);
            this.textBoxSale.Name = "textBoxSale";
            this.textBoxSale.Size = new System.Drawing.Size(199, 38);
            this.textBoxSale.TabIndex = 23;
            // 
            // ButtonAdd_two
            // 
            this.ButtonAdd_two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.ButtonAdd_two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonAdd_two.Location = new System.Drawing.Point(715, 10);
            this.ButtonAdd_two.Name = "ButtonAdd_two";
            this.ButtonAdd_two.Size = new System.Drawing.Size(236, 50);
            this.ButtonAdd_two.TabIndex = 25;
            this.ButtonAdd_two.Text = "Добавить партнера";
            this.ButtonAdd_two.UseVisualStyleBackColor = false;
            this.ButtonAdd_two.Click += new System.EventHandler(this.ButtonAdd_two_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEdit.BackgroundImage")));
            this.ButtonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonEdit.Location = new System.Drawing.Point(247, 713);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(55, 55);
            this.ButtonEdit.TabIndex = 27;
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonModule
            // 
            this.ButtonModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.ButtonModule.Location = new System.Drawing.Point(508, 664);
            this.ButtonModule.Name = "ButtonModule";
            this.ButtonModule.Size = new System.Drawing.Size(353, 50);
            this.ButtonModule.TabIndex = 28;
            this.ButtonModule.Text = "История продукции партнера";
            this.ButtonModule.UseVisualStyleBackColor = false;
            this.ButtonModule.Click += new System.EventHandler(this.ButtonModule_Click);
            // 
            // Button_rkm
            // 
            this.Button_rkm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.Button_rkm.Location = new System.Drawing.Point(508, 733);
            this.Button_rkm.Name = "Button_rkm";
            this.Button_rkm.Size = new System.Drawing.Size(353, 50);
            this.Button_rkm.TabIndex = 29;
            this.Button_rkm.Text = "Расчет количества материала";
            this.Button_rkm.UseVisualStyleBackColor = false;
            this.Button_rkm.Click += new System.EventHandler(this.Button_rkm_Click);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 788);
            this.Controls.Add(this.Button_rkm);
            this.Controls.Add(this.ButtonModule);
            this.Controls.Add(this.ButtonAdd_two);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.labelSale);
            this.Controls.Add(this.textBoxSale);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет партнеров";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label label1;
        private dbmasterfloorDataSetTableAdapters.partner_products_historyTableAdapter partner_products_historyTableAdapter1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSale;
        private System.Windows.Forms.TextBox textBoxSale;
        private System.Windows.Forms.Button ButtonAdd_two;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonModule;
        private System.Windows.Forms.Button Button_rkm;
    }
}
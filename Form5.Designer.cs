namespace demo_one
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPartner = new System.Windows.Forms.ComboBox();
            this.labelPartner = new System.Windows.Forms.Label();
            this.ButtonAdd_two = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partnerproductshistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbmasterfloorDataSet = new demo_one.dbmasterfloorDataSet();
            this.partner_products_historyTableAdapter = new demo_one.dbmasterfloorDataSetTableAdapters.partner_products_historyTableAdapter();
            this.Button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerproductshistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmasterfloorDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(761, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(183, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(546, 38);
            this.label2.TabIndex = 21;
            this.label2.Text = "История реализации продукции парнера";
            // 
            // comboBoxPartner
            // 
            this.comboBoxPartner.FormattingEnabled = true;
            this.comboBoxPartner.Items.AddRange(new object[] {
            "БазаСтроитель",
            "Паркет 29",
            "Стройсервис",
            "Ремонт и отделка",
            "МонтажПро"});
            this.comboBoxPartner.Location = new System.Drawing.Point(269, 89);
            this.comboBoxPartner.Name = "comboBoxPartner";
            this.comboBoxPartner.Size = new System.Drawing.Size(210, 24);
            this.comboBoxPartner.TabIndex = 108;
            // 
            // labelPartner
            // 
            this.labelPartner.AutoSize = true;
            this.labelPartner.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.labelPartner.Location = new System.Drawing.Point(21, 82);
            this.labelPartner.Name = "labelPartner";
            this.labelPartner.Size = new System.Drawing.Size(221, 31);
            this.labelPartner.TabIndex = 107;
            this.labelPartner.Text = "Выберите партнера";
            // 
            // ButtonAdd_two
            // 
            this.ButtonAdd_two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.ButtonAdd_two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonAdd_two.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.ButtonAdd_two.Location = new System.Drawing.Point(576, 75);
            this.ButtonAdd_two.Name = "ButtonAdd_two";
            this.ButtonAdd_two.Size = new System.Drawing.Size(318, 50);
            this.ButtonAdd_two.TabIndex = 109;
            this.ButtonAdd_two.Text = "Показать историю";
            this.ButtonAdd_two.UseVisualStyleBackColor = false;
            this.ButtonAdd_two.Click += new System.EventHandler(this.ButtonAdd_two_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(939, 375);
            this.dataGridView1.TabIndex = 110;
            // 
            // partnerproductshistoryBindingSource
            // 
            this.partnerproductshistoryBindingSource.DataMember = "partner_products_history";
            this.partnerproductshistoryBindingSource.DataSource = this.dbmasterfloorDataSet;
            // 
            // dbmasterfloorDataSet
            // 
            this.dbmasterfloorDataSet.DataSetName = "dbmasterfloorDataSet";
            this.dbmasterfloorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partner_products_historyTableAdapter
            // 
            this.partner_products_historyTableAdapter.ClearBeforeFill = true;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Button1.Location = new System.Drawing.Point(781, 516);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(171, 50);
            this.Button1.TabIndex = 111;
            this.Button1.Text = "Назад";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 578);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonAdd_two);
            this.Controls.Add(this.comboBoxPartner);
            this.Controls.Add(this.labelPartner);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "История реализации продукции партнера";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerproductshistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbmasterfloorDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPartner;
        private System.Windows.Forms.Label labelPartner;
        private System.Windows.Forms.Button ButtonAdd_two;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbmasterfloorDataSet dbmasterfloorDataSet;
        private System.Windows.Forms.BindingSource partnerproductshistoryBindingSource;
        private dbmasterfloorDataSetTableAdapters.partner_products_historyTableAdapter partner_products_historyTableAdapter;
        private System.Windows.Forms.Button Button1;
    }
}
namespace Курсова
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.width_textBox = new System.Windows.Forms.TextBox();
            this.length_textBox = new System.Windows.Forms.TextBox();
            this.dateExpiration_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expirationDate_label = new System.Windows.Forms.Label();
            this.dateCreation_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.changable2_label = new System.Windows.Forms.Label();
            this.weightOrHeight_textBox = new System.Windows.Forms.TextBox();
            this.changable1_label = new System.Windows.Forms.Label();
            this.quantity_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.producer_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.quantity_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.type_comboBox = new System.Windows.Forms.ComboBox();
            this.acceptButton_pictureBox = new System.Windows.Forms.PictureBox();
            this.destinationGroup_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // width_textBox
            // 
            this.width_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.width_textBox.Location = new System.Drawing.Point(435, 250);
            this.width_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.width_textBox.Name = "width_textBox";
            this.width_textBox.Size = new System.Drawing.Size(121, 30);
            this.width_textBox.TabIndex = 40;
            this.width_textBox.TabStop = false;
            this.width_textBox.Text = "Width";
            this.width_textBox.Visible = false;
            this.width_textBox.Click += new System.EventHandler(this.width_textBox_Click);
            this.width_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.width_textBox_KeyPress);
            this.width_textBox.Leave += new System.EventHandler(this.width_textBox_Leave);
            // 
            // length_textBox
            // 
            this.length_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.length_textBox.Location = new System.Drawing.Point(307, 250);
            this.length_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.length_textBox.Name = "length_textBox";
            this.length_textBox.Size = new System.Drawing.Size(121, 30);
            this.length_textBox.TabIndex = 39;
            this.length_textBox.TabStop = false;
            this.length_textBox.Text = "Length";
            this.length_textBox.Visible = false;
            this.length_textBox.Click += new System.EventHandler(this.length_textBox_Click);
            this.length_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.length_textBox_KeyPress);
            this.length_textBox.Leave += new System.EventHandler(this.length_textBox_Leave);
            // 
            // dateExpiration_dateTimePicker
            // 
            this.dateExpiration_dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateExpiration_dateTimePicker.CustomFormat = "dd.MM.yyyy";
            this.dateExpiration_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateExpiration_dateTimePicker.Location = new System.Drawing.Point(240, 334);
            this.dateExpiration_dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateExpiration_dateTimePicker.MaxDate = new System.DateTime(2020, 11, 17, 0, 0, 0, 0);
            this.dateExpiration_dateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateExpiration_dateTimePicker.Name = "dateExpiration_dateTimePicker";
            this.dateExpiration_dateTimePicker.Size = new System.Drawing.Size(111, 22);
            this.dateExpiration_dateTimePicker.TabIndex = 38;
            this.dateExpiration_dateTimePicker.Value = new System.DateTime(2020, 11, 17, 0, 0, 0, 0);
            this.dateExpiration_dateTimePicker.Visible = false;
            // 
            // expirationDate_label
            // 
            this.expirationDate_label.AutoSize = true;
            this.expirationDate_label.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationDate_label.Location = new System.Drawing.Point(16, 334);
            this.expirationDate_label.Name = "expirationDate_label";
            this.expirationDate_label.Size = new System.Drawing.Size(194, 20);
            this.expirationDate_label.TabIndex = 37;
            this.expirationDate_label.Text = "EXPIRATION DATE:";
            this.expirationDate_label.Visible = false;
            // 
            // dateCreation_dateTimePicker
            // 
            this.dateCreation_dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateCreation_dateTimePicker.CustomFormat = "dd.MM.yyyy";
            this.dateCreation_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCreation_dateTimePicker.Location = new System.Drawing.Point(240, 293);
            this.dateCreation_dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateCreation_dateTimePicker.MaxDate = new System.DateTime(2020, 11, 17, 0, 0, 0, 0);
            this.dateCreation_dateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateCreation_dateTimePicker.Name = "dateCreation_dateTimePicker";
            this.dateCreation_dateTimePicker.Size = new System.Drawing.Size(111, 22);
            this.dateCreation_dateTimePicker.TabIndex = 36;
            this.dateCreation_dateTimePicker.Value = new System.DateTime(2020, 11, 17, 0, 0, 0, 0);
            this.dateCreation_dateTimePicker.Visible = false;
            // 
            // changable2_label
            // 
            this.changable2_label.AutoSize = true;
            this.changable2_label.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changable2_label.Location = new System.Drawing.Point(16, 292);
            this.changable2_label.Name = "changable2_label";
            this.changable2_label.Size = new System.Drawing.Size(172, 20);
            this.changable2_label.TabIndex = 35;
            this.changable2_label.Text = "CREATION DATE:";
            this.changable2_label.Visible = false;
            // 
            // weightOrHeight_textBox
            // 
            this.weightOrHeight_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightOrHeight_textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.weightOrHeight_textBox.Location = new System.Drawing.Point(180, 250);
            this.weightOrHeight_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weightOrHeight_textBox.Name = "weightOrHeight_textBox";
            this.weightOrHeight_textBox.Size = new System.Drawing.Size(121, 30);
            this.weightOrHeight_textBox.TabIndex = 34;
            this.weightOrHeight_textBox.TabStop = false;
            this.weightOrHeight_textBox.Text = "Height";
            this.weightOrHeight_textBox.Visible = false;
            this.weightOrHeight_textBox.Click += new System.EventHandler(this.weightOrHeight_textBox_Click);
            this.weightOrHeight_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weightOrHeight_textBox_KeyPress);
            this.weightOrHeight_textBox.Leave += new System.EventHandler(this.weightOrHeight_textBox_Leave);
            // 
            // changable1_label
            // 
            this.changable1_label.AutoSize = true;
            this.changable1_label.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changable1_label.Location = new System.Drawing.Point(16, 250);
            this.changable1_label.Name = "changable1_label";
            this.changable1_label.Size = new System.Drawing.Size(141, 20);
            this.changable1_label.TabIndex = 33;
            this.changable1_label.Text = "WEIGHT(KG):";
            this.changable1_label.Visible = false;
            // 
            // quantity_numericUpDown
            // 
            this.quantity_numericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantity_numericUpDown.Location = new System.Drawing.Point(168, 208);
            this.quantity_numericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantity_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantity_numericUpDown.Name = "quantity_numericUpDown";
            this.quantity_numericUpDown.Size = new System.Drawing.Size(120, 30);
            this.quantity_numericUpDown.TabIndex = 32;
            this.quantity_numericUpDown.Visible = false;
            this.quantity_numericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_numericUpDown_KeyPress);
            // 
            // price_textBox
            // 
            this.price_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_textBox.Location = new System.Drawing.Point(168, 164);
            this.price_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.ReadOnly = true;
            this.price_textBox.Size = new System.Drawing.Size(121, 30);
            this.price_textBox.TabIndex = 31;
            this.price_textBox.TabStop = false;
            this.price_textBox.Click += new System.EventHandler(this.price_textBox_Click);
            this.price_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_textBox_KeyPress);
            this.price_textBox.Leave += new System.EventHandler(this.price_textBox_Leave);
            // 
            // producer_textBox
            // 
            this.producer_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.producer_textBox.Location = new System.Drawing.Point(168, 122);
            this.producer_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.producer_textBox.Name = "producer_textBox";
            this.producer_textBox.ReadOnly = true;
            this.producer_textBox.Size = new System.Drawing.Size(263, 30);
            this.producer_textBox.TabIndex = 30;
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textBox.Location = new System.Drawing.Point(168, 80);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.ReadOnly = true;
            this.name_textBox.Size = new System.Drawing.Size(263, 30);
            this.name_textBox.TabIndex = 29;
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_label.Location = new System.Drawing.Point(13, 208);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(117, 20);
            this.quantity_label.TabIndex = 28;
            this.quantity_label.Text = "QUANTITY:";
            this.quantity_label.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "PRICE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "PRODUCER:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "CHOOSE TYPE:";
            // 
            // type_comboBox
            // 
            this.type_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_comboBox.FormattingEnabled = true;
            this.type_comboBox.Items.AddRange(new object[] {
            "Grocerie",
            "Non-grocerie"});
            this.type_comboBox.Location = new System.Drawing.Point(180, 14);
            this.type_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.type_comboBox.Name = "type_comboBox";
            this.type_comboBox.Size = new System.Drawing.Size(169, 24);
            this.type_comboBox.TabIndex = 23;
            this.type_comboBox.SelectedIndexChanged += new System.EventHandler(this.type_comboBox_SelectedIndexChanged);
            // 
            // acceptButton_pictureBox
            // 
            this.acceptButton_pictureBox.Image = global::Курсова.Properties.Resources.ok;
            this.acceptButton_pictureBox.ImageLocation = "";
            this.acceptButton_pictureBox.Location = new System.Drawing.Point(259, 398);
            this.acceptButton_pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.acceptButton_pictureBox.Name = "acceptButton_pictureBox";
            this.acceptButton_pictureBox.Size = new System.Drawing.Size(53, 50);
            this.acceptButton_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.acceptButton_pictureBox.TabIndex = 41;
            this.acceptButton_pictureBox.TabStop = false;
            this.acceptButton_pictureBox.Visible = false;
            this.acceptButton_pictureBox.Click += new System.EventHandler(this.acceptButton_pictureBox_Click);
            this.acceptButton_pictureBox.MouseLeave += new System.EventHandler(this.acceptButton_pictureBox_MouseLeave);
            this.acceptButton_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.acceptButton_pictureBox_MouseMove);
            // 
            // destinationGroup_comboBox
            // 
            this.destinationGroup_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationGroup_comboBox.FormattingEnabled = true;
            this.destinationGroup_comboBox.Items.AddRange(new object[] {
            "Clothes",
            "Machinery",
            "Furniture\t",
            "Dishes",
            "Jewelry"});
            this.destinationGroup_comboBox.Location = new System.Drawing.Point(387, 330);
            this.destinationGroup_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.destinationGroup_comboBox.Name = "destinationGroup_comboBox";
            this.destinationGroup_comboBox.Size = new System.Drawing.Size(169, 24);
            this.destinationGroup_comboBox.TabIndex = 42;
            this.destinationGroup_comboBox.Visible = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(569, 460);
            this.Controls.Add(this.destinationGroup_comboBox);
            this.Controls.Add(this.acceptButton_pictureBox);
            this.Controls.Add(this.width_textBox);
            this.Controls.Add(this.length_textBox);
            this.Controls.Add(this.dateExpiration_dateTimePicker);
            this.Controls.Add(this.expirationDate_label);
            this.Controls.Add(this.dateCreation_dateTimePicker);
            this.Controls.Add(this.changable2_label);
            this.Controls.Add(this.weightOrHeight_textBox);
            this.Controls.Add(this.changable1_label);
            this.Controls.Add(this.quantity_numericUpDown);
            this.Controls.Add(this.price_textBox);
            this.Controls.Add(this.producer_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.type_comboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.quantity_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox acceptButton_pictureBox;
        private System.Windows.Forms.TextBox width_textBox;
        private System.Windows.Forms.TextBox length_textBox;
        private System.Windows.Forms.DateTimePicker dateExpiration_dateTimePicker;
        private System.Windows.Forms.Label expirationDate_label;
        private System.Windows.Forms.DateTimePicker dateCreation_dateTimePicker;
        private System.Windows.Forms.Label changable2_label;
        private System.Windows.Forms.TextBox weightOrHeight_textBox;
        private System.Windows.Forms.Label changable1_label;
        private System.Windows.Forms.NumericUpDown quantity_numericUpDown;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.TextBox producer_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox type_comboBox;
        private System.Windows.Forms.ComboBox destinationGroup_comboBox;
    }
}
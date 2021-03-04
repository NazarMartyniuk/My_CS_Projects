
namespace Курсова
{
    partial class FilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
            this.type_groupBox = new System.Windows.Forms.GroupBox();
            this.nonGrocerie_radioButton = new System.Windows.Forms.RadioButton();
            this.grocerie_radioButton = new System.Windows.Forms.RadioButton();
            this.outWeight_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toWeight_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.producer_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toQuantity_textBox = new System.Windows.Forms.TextBox();
            this.outQuantity_textBox = new System.Windows.Forms.TextBox();
            this.outPrice_textBox = new System.Windows.Forms.TextBox();
            this.toPrice_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.outWidth_textBox = new System.Windows.Forms.TextBox();
            this.toWidth_textBox = new System.Windows.Forms.TextBox();
            this.outLength_textBox = new System.Windows.Forms.TextBox();
            this.toLength_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.outHeight_textBox = new System.Windows.Forms.TextBox();
            this.toHeight_textBox = new System.Windows.Forms.TextBox();
            this.creationDate_label = new System.Windows.Forms.Label();
            this.outDateCreation_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateCreation_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expirationDate_label = new System.Windows.Forms.Label();
            this.outDateExpiration_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateExpiration_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eDEnabled_checkBox = new System.Windows.Forms.CheckBox();
            this.cDEnabled_checkBox = new System.Windows.Forms.CheckBox();
            this.items_listView = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProducer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.group_comboBox = new System.Windows.Forms.ComboBox();
            this.uniqGoodsButton_pictureBox = new System.Windows.Forms.PictureBox();
            this.acceptButton_pictureBox = new System.Windows.Forms.PictureBox();
            this.type_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniqGoodsButton_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // type_groupBox
            // 
            this.type_groupBox.Controls.Add(this.nonGrocerie_radioButton);
            this.type_groupBox.Controls.Add(this.grocerie_radioButton);
            this.type_groupBox.Location = new System.Drawing.Point(0, 0);
            this.type_groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.type_groupBox.Name = "type_groupBox";
            this.type_groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.type_groupBox.Size = new System.Drawing.Size(169, 87);
            this.type_groupBox.TabIndex = 0;
            this.type_groupBox.TabStop = false;
            this.type_groupBox.Text = "Type";
            // 
            // nonGrocerie_radioButton
            // 
            this.nonGrocerie_radioButton.AutoSize = true;
            this.nonGrocerie_radioButton.Location = new System.Drawing.Point(8, 52);
            this.nonGrocerie_radioButton.Margin = new System.Windows.Forms.Padding(4);
            this.nonGrocerie_radioButton.Name = "nonGrocerie_radioButton";
            this.nonGrocerie_radioButton.Size = new System.Drawing.Size(115, 21);
            this.nonGrocerie_radioButton.TabIndex = 1;
            this.nonGrocerie_radioButton.Text = "Non-Grocerie";
            this.nonGrocerie_radioButton.UseVisualStyleBackColor = true;
            this.nonGrocerie_radioButton.CheckedChanged += new System.EventHandler(this.nonGrocerie_radioButton_CheckedChanged);
            // 
            // grocerie_radioButton
            // 
            this.grocerie_radioButton.AutoSize = true;
            this.grocerie_radioButton.Location = new System.Drawing.Point(8, 23);
            this.grocerie_radioButton.Margin = new System.Windows.Forms.Padding(4);
            this.grocerie_radioButton.Name = "grocerie_radioButton";
            this.grocerie_radioButton.Size = new System.Drawing.Size(84, 21);
            this.grocerie_radioButton.TabIndex = 0;
            this.grocerie_radioButton.Text = "Grocerie";
            this.grocerie_radioButton.UseVisualStyleBackColor = true;
            this.grocerie_radioButton.CheckedChanged += new System.EventHandler(this.nonGrocerie_radioButton_CheckedChanged);
            // 
            // outWeight_textBox
            // 
            this.outWeight_textBox.Location = new System.Drawing.Point(112, 95);
            this.outWeight_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.outWeight_textBox.Name = "outWeight_textBox";
            this.outWeight_textBox.Size = new System.Drawing.Size(132, 22);
            this.outWeight_textBox.TabIndex = 1;
            this.outWeight_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.outPrice_textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weight";
            // 
            // toWeight_textBox
            // 
            this.toWeight_textBox.Location = new System.Drawing.Point(112, 127);
            this.toWeight_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.toWeight_textBox.Name = "toWeight_textBox";
            this.toWeight_textBox.Size = new System.Drawing.Size(132, 22);
            this.toWeight_textBox.TabIndex = 3;
            this.toWeight_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.outPrice_textBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(228, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textBox.Location = new System.Drawing.Point(177, 46);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(172, 26);
            this.name_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(416, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Producer";
            // 
            // producer_textBox
            // 
            this.producer_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.producer_textBox.Location = new System.Drawing.Point(379, 46);
            this.producer_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.producer_textBox.Name = "producer_textBox";
            this.producer_textBox.Size = new System.Drawing.Size(169, 26);
            this.producer_textBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(667, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(907, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantity";
            // 
            // toQuantity_textBox
            // 
            this.toQuantity_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toQuantity_textBox.Location = new System.Drawing.Point(960, 46);
            this.toQuantity_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.toQuantity_textBox.Name = "toQuantity_textBox";
            this.toQuantity_textBox.Size = new System.Drawing.Size(89, 26);
            this.toQuantity_textBox.TabIndex = 13;
            this.toQuantity_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.outPrice_textBox_KeyPress);
            // 
            // outQuantity_textBox
            // 
            this.outQuantity_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outQuantity_textBox.Location = new System.Drawing.Point(849, 46);
            this.outQuantity_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.outQuantity_textBox.Name = "outQuantity_textBox";
            this.outQuantity_textBox.Size = new System.Drawing.Size(89, 26);
            this.outQuantity_textBox.TabIndex = 14;
            this.outQuantity_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.outPrice_textBox_KeyPress);
            // 
            // outPrice_textBox
            // 
            this.outPrice_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outPrice_textBox.Location = new System.Drawing.Point(596, 46);
            this.outPrice_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.outPrice_textBox.Name = "outPrice_textBox";
            this.outPrice_textBox.Size = new System.Drawing.Size(89, 26);
            this.outPrice_textBox.TabIndex = 15;
            this.outPrice_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.outPrice_textBox_KeyPress);
            // 
            // toPrice_textBox
            // 
            this.toPrice_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toPrice_textBox.Location = new System.Drawing.Point(707, 46);
            this.toPrice_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.toPrice_textBox.Name = "toPrice_textBox";
            this.toPrice_textBox.Size = new System.Drawing.Size(89, 26);
            this.toPrice_textBox.TabIndex = 16;
            this.toPrice_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.outPrice_textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Width";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(16, 240);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Length";
            // 
            // outWidth_textBox
            // 
            this.outWidth_textBox.Location = new System.Drawing.Point(112, 159);
            this.outWidth_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.outWidth_textBox.Name = "outWidth_textBox";
            this.outWidth_textBox.Size = new System.Drawing.Size(132, 22);
            this.outWidth_textBox.TabIndex = 19;
            this.outWidth_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.outPrice_textBox_KeyPress);
            // 
            // toWidth_textBox
            // 
            this.toWidth_textBox.Location = new System.Drawing.Point(112, 191);
            this.toWidth_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.toWidth_textBox.Name = "toWidth_textBox";
            this.toWidth_textBox.Size = new System.Drawing.Size(132, 22);
            this.toWidth_textBox.TabIndex = 20;
            this.toWidth_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.outPrice_textBox_KeyPress);
            // 
            // outLength_textBox
            // 
            this.outLength_textBox.Location = new System.Drawing.Point(112, 223);
            this.outLength_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.outLength_textBox.Name = "outLength_textBox";
            this.outLength_textBox.Size = new System.Drawing.Size(132, 22);
            this.outLength_textBox.TabIndex = 21;
            this.outLength_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.outPrice_textBox_KeyPress);
            // 
            // toLength_textBox
            // 
            this.toLength_textBox.Location = new System.Drawing.Point(112, 255);
            this.toLength_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.toLength_textBox.Name = "toLength_textBox";
            this.toLength_textBox.Size = new System.Drawing.Size(132, 22);
            this.toLength_textBox.TabIndex = 22;
            this.toLength_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.outPrice_textBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(16, 303);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Height";
            // 
            // outHeight_textBox
            // 
            this.outHeight_textBox.Location = new System.Drawing.Point(112, 287);
            this.outHeight_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.outHeight_textBox.Name = "outHeight_textBox";
            this.outHeight_textBox.Size = new System.Drawing.Size(132, 22);
            this.outHeight_textBox.TabIndex = 24;
            this.outHeight_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.outPrice_textBox_KeyPress);
            // 
            // toHeight_textBox
            // 
            this.toHeight_textBox.Location = new System.Drawing.Point(112, 319);
            this.toHeight_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.toHeight_textBox.Name = "toHeight_textBox";
            this.toHeight_textBox.Size = new System.Drawing.Size(132, 22);
            this.toHeight_textBox.TabIndex = 25;
            this.toHeight_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.outPrice_textBox_KeyPress);
            // 
            // creationDate_label
            // 
            this.creationDate_label.AutoSize = true;
            this.creationDate_label.Enabled = false;
            this.creationDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creationDate_label.Location = new System.Drawing.Point(16, 395);
            this.creationDate_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.creationDate_label.Name = "creationDate_label";
            this.creationDate_label.Size = new System.Drawing.Size(80, 48);
            this.creationDate_label.TabIndex = 26;
            this.creationDate_label.Text = "Creation\r\nDate\r\n";
            // 
            // outDateCreation_dateTimePicker
            // 
            this.outDateCreation_dateTimePicker.Enabled = false;
            this.outDateCreation_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.outDateCreation_dateTimePicker.Location = new System.Drawing.Point(112, 393);
            this.outDateCreation_dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.outDateCreation_dateTimePicker.Name = "outDateCreation_dateTimePicker";
            this.outDateCreation_dateTimePicker.Size = new System.Drawing.Size(132, 22);
            this.outDateCreation_dateTimePicker.TabIndex = 27;
            // 
            // toDateCreation_dateTimePicker
            // 
            this.toDateCreation_dateTimePicker.Enabled = false;
            this.toDateCreation_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateCreation_dateTimePicker.Location = new System.Drawing.Point(112, 425);
            this.toDateCreation_dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.toDateCreation_dateTimePicker.Name = "toDateCreation_dateTimePicker";
            this.toDateCreation_dateTimePicker.Size = new System.Drawing.Size(132, 22);
            this.toDateCreation_dateTimePicker.TabIndex = 28;
            // 
            // expirationDate_label
            // 
            this.expirationDate_label.AutoSize = true;
            this.expirationDate_label.Enabled = false;
            this.expirationDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expirationDate_label.Location = new System.Drawing.Point(16, 498);
            this.expirationDate_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expirationDate_label.Name = "expirationDate_label";
            this.expirationDate_label.Size = new System.Drawing.Size(94, 48);
            this.expirationDate_label.TabIndex = 29;
            this.expirationDate_label.Text = "Expiration\r\nDate\r\n";
            // 
            // outDateExpiration_dateTimePicker
            // 
            this.outDateExpiration_dateTimePicker.Enabled = false;
            this.outDateExpiration_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.outDateExpiration_dateTimePicker.Location = new System.Drawing.Point(112, 486);
            this.outDateExpiration_dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.outDateExpiration_dateTimePicker.Name = "outDateExpiration_dateTimePicker";
            this.outDateExpiration_dateTimePicker.Size = new System.Drawing.Size(132, 22);
            this.outDateExpiration_dateTimePicker.TabIndex = 30;
            // 
            // toDateExpiration_dateTimePicker
            // 
            this.toDateExpiration_dateTimePicker.Enabled = false;
            this.toDateExpiration_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateExpiration_dateTimePicker.Location = new System.Drawing.Point(112, 518);
            this.toDateExpiration_dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.toDateExpiration_dateTimePicker.Name = "toDateExpiration_dateTimePicker";
            this.toDateExpiration_dateTimePicker.Size = new System.Drawing.Size(132, 22);
            this.toDateExpiration_dateTimePicker.TabIndex = 31;
            // 
            // eDEnabled_checkBox
            // 
            this.eDEnabled_checkBox.AutoSize = true;
            this.eDEnabled_checkBox.Location = new System.Drawing.Point(20, 458);
            this.eDEnabled_checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.eDEnabled_checkBox.Name = "eDEnabled_checkBox";
            this.eDEnabled_checkBox.Size = new System.Drawing.Size(18, 17);
            this.eDEnabled_checkBox.TabIndex = 32;
            this.eDEnabled_checkBox.UseVisualStyleBackColor = true;
            this.eDEnabled_checkBox.CheckedChanged += new System.EventHandler(this.cDEnabled_checkBox_CheckedChanged);
            // 
            // cDEnabled_checkBox
            // 
            this.cDEnabled_checkBox.AutoSize = true;
            this.cDEnabled_checkBox.Location = new System.Drawing.Point(20, 364);
            this.cDEnabled_checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.cDEnabled_checkBox.Name = "cDEnabled_checkBox";
            this.cDEnabled_checkBox.Size = new System.Drawing.Size(18, 17);
            this.cDEnabled_checkBox.TabIndex = 33;
            this.cDEnabled_checkBox.UseVisualStyleBackColor = true;
            this.cDEnabled_checkBox.CheckedChanged += new System.EventHandler(this.cDEnabled_checkBox_CheckedChanged);
            // 
            // items_listView
            // 
            this.items_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnType,
            this.columnProducer,
            this.columnPrice,
            this.columnQuantity});
            this.items_listView.HideSelection = false;
            this.items_listView.Location = new System.Drawing.Point(296, 95);
            this.items_listView.Margin = new System.Windows.Forms.Padding(4);
            this.items_listView.Name = "items_listView";
            this.items_listView.Size = new System.Drawing.Size(753, 447);
            this.items_listView.TabIndex = 34;
            this.items_listView.UseCompatibleStateImageBehavior = false;
            this.items_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 137;
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            this.columnType.Width = 100;
            // 
            // columnProducer
            // 
            this.columnProducer.Text = "Producer";
            this.columnProducer.Width = 150;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 80;
            // 
            // columnQuantity
            // 
            this.columnQuantity.Text = "Quantity";
            this.columnQuantity.Width = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(16, 565);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 48);
            this.label9.TabIndex = 44;
            this.label9.Text = "Destination\r\ngroup\r\n";
            // 
            // group_comboBox
            // 
            this.group_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.group_comboBox.FormattingEnabled = true;
            this.group_comboBox.Items.AddRange(new object[] {
            "Clothes",
            "Machinery",
            "Furniture\t",
            "Dishes",
            "Jewelry"});
            this.group_comboBox.Location = new System.Drawing.Point(133, 583);
            this.group_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.group_comboBox.Name = "group_comboBox";
            this.group_comboBox.Size = new System.Drawing.Size(111, 24);
            this.group_comboBox.TabIndex = 45;
            // 
            // uniqGoodsButton_pictureBox
            // 
            this.uniqGoodsButton_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uniqGoodsButton_pictureBox.Image = global::Курсова.Properties.Resources.iconfinder_45_Settings_290105;
            this.uniqGoodsButton_pictureBox.ImageLocation = "";
            this.uniqGoodsButton_pictureBox.Location = new System.Drawing.Point(492, 565);
            this.uniqGoodsButton_pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uniqGoodsButton_pictureBox.Name = "uniqGoodsButton_pictureBox";
            this.uniqGoodsButton_pictureBox.Size = new System.Drawing.Size(53, 50);
            this.uniqGoodsButton_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uniqGoodsButton_pictureBox.TabIndex = 43;
            this.uniqGoodsButton_pictureBox.TabStop = false;
            this.uniqGoodsButton_pictureBox.Click += new System.EventHandler(this.uniqGoodsButton_pictureBox_Click);
            this.uniqGoodsButton_pictureBox.MouseLeave += new System.EventHandler(this.uniqGoodsButton_pictureBox_MouseLeave);
            this.uniqGoodsButton_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.uniqGoodsButton_pictureBox_MouseMove);
            // 
            // acceptButton_pictureBox
            // 
            this.acceptButton_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptButton_pictureBox.Image = global::Курсова.Properties.Resources.iconfinder_Search_Icon_743893;
            this.acceptButton_pictureBox.ImageLocation = "";
            this.acceptButton_pictureBox.Location = new System.Drawing.Point(785, 565);
            this.acceptButton_pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.acceptButton_pictureBox.Name = "acceptButton_pictureBox";
            this.acceptButton_pictureBox.Size = new System.Drawing.Size(53, 50);
            this.acceptButton_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.acceptButton_pictureBox.TabIndex = 42;
            this.acceptButton_pictureBox.TabStop = false;
            this.acceptButton_pictureBox.Click += new System.EventHandler(this.acceptButton_pictureBox_Click);
            this.acceptButton_pictureBox.MouseLeave += new System.EventHandler(this.acceptButton_pictureBox_MouseLeave);
            this.acceptButton_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.acceptButton_pictureBox_MouseMove);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1067, 629);
            this.Controls.Add(this.group_comboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uniqGoodsButton_pictureBox);
            this.Controls.Add(this.acceptButton_pictureBox);
            this.Controls.Add(this.items_listView);
            this.Controls.Add(this.cDEnabled_checkBox);
            this.Controls.Add(this.eDEnabled_checkBox);
            this.Controls.Add(this.toDateExpiration_dateTimePicker);
            this.Controls.Add(this.outDateExpiration_dateTimePicker);
            this.Controls.Add(this.expirationDate_label);
            this.Controls.Add(this.toDateCreation_dateTimePicker);
            this.Controls.Add(this.outDateCreation_dateTimePicker);
            this.Controls.Add(this.creationDate_label);
            this.Controls.Add(this.toHeight_textBox);
            this.Controls.Add(this.outHeight_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.toLength_textBox);
            this.Controls.Add(this.outLength_textBox);
            this.Controls.Add(this.toWidth_textBox);
            this.Controls.Add(this.outWidth_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toPrice_textBox);
            this.Controls.Add(this.outPrice_textBox);
            this.Controls.Add(this.outQuantity_textBox);
            this.Controls.Add(this.toQuantity_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.producer_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toWeight_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outWeight_textBox);
            this.Controls.Add(this.type_groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            this.type_groupBox.ResumeLayout(false);
            this.type_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniqGoodsButton_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox type_groupBox;
        private System.Windows.Forms.RadioButton nonGrocerie_radioButton;
        private System.Windows.Forms.RadioButton grocerie_radioButton;
        private System.Windows.Forms.TextBox outWeight_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toWeight_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox producer_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox toQuantity_textBox;
        private System.Windows.Forms.TextBox outQuantity_textBox;
        private System.Windows.Forms.TextBox outPrice_textBox;
        private System.Windows.Forms.TextBox toPrice_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox outWidth_textBox;
        private System.Windows.Forms.TextBox toWidth_textBox;
        private System.Windows.Forms.TextBox outLength_textBox;
        private System.Windows.Forms.TextBox toLength_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox outHeight_textBox;
        private System.Windows.Forms.TextBox toHeight_textBox;
        private System.Windows.Forms.Label creationDate_label;
        private System.Windows.Forms.DateTimePicker outDateCreation_dateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateCreation_dateTimePicker;
        private System.Windows.Forms.Label expirationDate_label;
        private System.Windows.Forms.DateTimePicker outDateExpiration_dateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateExpiration_dateTimePicker;
        private System.Windows.Forms.CheckBox eDEnabled_checkBox;
        private System.Windows.Forms.CheckBox cDEnabled_checkBox;
        private System.Windows.Forms.ListView items_listView;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnProducer;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        private System.Windows.Forms.PictureBox acceptButton_pictureBox;
        private System.Windows.Forms.PictureBox uniqGoodsButton_pictureBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox group_comboBox;
    }
}
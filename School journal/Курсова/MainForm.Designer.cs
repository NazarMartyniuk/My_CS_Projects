namespace Курсова
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.items_listView = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProducer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.weightOrGroup_label = new System.Windows.Forms.Label();
            this.dimensionsOrDateCreation_label = new System.Windows.Forms.Label();
            this.dateExpiration_label = new System.Windows.Forms.Label();
            this.value1_label = new System.Windows.Forms.Label();
            this.value2_label = new System.Windows.Forms.Label();
            this.value3_label = new System.Windows.Forms.Label();
            this.piece_label = new System.Windows.Forms.Label();
            this.newPrice_textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.acceptButton_pictureBox = new System.Windows.Forms.PictureBox();
            this.editPriceButton_pictureBox = new System.Windows.Forms.PictureBox();
            this.filterButton_pictureBox = new System.Windows.Forms.PictureBox();
            this.reloadButton_pictureBox = new System.Windows.Forms.PictureBox();
            this.deleteButton_pictureBox = new System.Windows.Forms.PictureBox();
            this.saveFileButton_pictureBox = new System.Windows.Forms.PictureBox();
            this.addButton_pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileButton_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPriceButton_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterButton_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reloadButton_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveFileButton_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButton_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFileButton_pictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.items_listView.LargeImageList = this.imageList1;
            resources.ApplyResources(this.items_listView, "items_listView");
            this.items_listView.Name = "items_listView";
            this.items_listView.SmallImageList = this.imageList1;
            this.items_listView.UseCompatibleStateImageBehavior = false;
            this.items_listView.View = System.Windows.Forms.View.Details;
            this.items_listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.items_listView_ColumnClick);
            this.items_listView.SelectedIndexChanged += new System.EventHandler(this.items_listView_SelectedIndexChanged);
            // 
            // columnName
            // 
            resources.ApplyResources(this.columnName, "columnName");
            // 
            // columnType
            // 
            resources.ApplyResources(this.columnType, "columnType");
            // 
            // columnProducer
            // 
            resources.ApplyResources(this.columnProducer, "columnProducer");
            // 
            // columnPrice
            // 
            resources.ApplyResources(this.columnPrice, "columnPrice");
            // 
            // columnQuantity
            // 
            resources.ApplyResources(this.columnQuantity, "columnQuantity");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconfinder_Strawberry_2137821.png");
            this.imageList1.Images.SetKeyName(1, "iconfinder_red-tv-show-translation-live-broadcast_3993851.png");
            // 
            // weightOrGroup_label
            // 
            resources.ApplyResources(this.weightOrGroup_label, "weightOrGroup_label");
            this.weightOrGroup_label.Name = "weightOrGroup_label";
            // 
            // dimensionsOrDateCreation_label
            // 
            resources.ApplyResources(this.dimensionsOrDateCreation_label, "dimensionsOrDateCreation_label");
            this.dimensionsOrDateCreation_label.Name = "dimensionsOrDateCreation_label";
            // 
            // dateExpiration_label
            // 
            resources.ApplyResources(this.dateExpiration_label, "dateExpiration_label");
            this.dateExpiration_label.Name = "dateExpiration_label";
            // 
            // value1_label
            // 
            resources.ApplyResources(this.value1_label, "value1_label");
            this.value1_label.Name = "value1_label";
            // 
            // value2_label
            // 
            resources.ApplyResources(this.value2_label, "value2_label");
            this.value2_label.Name = "value2_label";
            // 
            // value3_label
            // 
            resources.ApplyResources(this.value3_label, "value3_label");
            this.value3_label.Name = "value3_label";
            // 
            // piece_label
            // 
            resources.ApplyResources(this.piece_label, "piece_label");
            this.piece_label.Name = "piece_label";
            // 
            // newPrice_textBox
            // 
            resources.ApplyResources(this.newPrice_textBox, "newPrice_textBox");
            this.newPrice_textBox.Name = "newPrice_textBox";
            this.newPrice_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newPrice_textBox_KeyPress);
            this.newPrice_textBox.Leave += new System.EventHandler(this.newPrice_textBox_Leave);
            // 
            // label
            // 
            resources.ApplyResources(this.label, "label");
            this.label.Name = "label";
            // 
            // acceptButton_pictureBox
            // 
            resources.ApplyResources(this.acceptButton_pictureBox, "acceptButton_pictureBox");
            this.acceptButton_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptButton_pictureBox.Name = "acceptButton_pictureBox";
            this.acceptButton_pictureBox.TabStop = false;
            this.acceptButton_pictureBox.Click += new System.EventHandler(this.acceptButton_pictureBox_Click);
            this.acceptButton_pictureBox.MouseLeave += new System.EventHandler(this.acceptButton_pictureBox_MouseLeave);
            this.acceptButton_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.acceptButton_pictureBox_MouseMove);
            // 
            // editPriceButton_pictureBox
            // 
            resources.ApplyResources(this.editPriceButton_pictureBox, "editPriceButton_pictureBox");
            this.editPriceButton_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editPriceButton_pictureBox.Image = global::Курсова.Properties.Resources.iconfinder_Compose_1891025;
            this.editPriceButton_pictureBox.Name = "editPriceButton_pictureBox";
            this.editPriceButton_pictureBox.TabStop = false;
            this.editPriceButton_pictureBox.Click += new System.EventHandler(this.editPriceButton_pictureBox_Click);
            this.editPriceButton_pictureBox.MouseLeave += new System.EventHandler(this.editPriceButton_pictureBox_MouseLeave);
            this.editPriceButton_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.editPriceButton_pictureBox_MouseMove);
            // 
            // filterButton_pictureBox
            // 
            resources.ApplyResources(this.filterButton_pictureBox, "filterButton_pictureBox");
            this.filterButton_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterButton_pictureBox.Image = global::Курсова.Properties.Resources.iconfinder_Descending_filter_filtering_tool_funnel_sort_1886794;
            this.filterButton_pictureBox.Name = "filterButton_pictureBox";
            this.filterButton_pictureBox.TabStop = false;
            this.filterButton_pictureBox.Click += new System.EventHandler(this.filterButton_pictureBox_Click);
            this.filterButton_pictureBox.MouseLeave += new System.EventHandler(this.filterButton_pictureBox_MouseLeave);
            this.filterButton_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.filterButton_pictureBox_MouseMove);
            // 
            // reloadButton_pictureBox
            // 
            resources.ApplyResources(this.reloadButton_pictureBox, "reloadButton_pictureBox");
            this.reloadButton_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadButton_pictureBox.Image = global::Курсова.Properties.Resources.iconfinder_update_678134;
            this.reloadButton_pictureBox.Name = "reloadButton_pictureBox";
            this.reloadButton_pictureBox.TabStop = false;
            this.reloadButton_pictureBox.Click += new System.EventHandler(this.reloadButton_pictureBox_Click);
            this.reloadButton_pictureBox.MouseLeave += new System.EventHandler(this.reloadButton_pictureBox_MouseLeave);
            this.reloadButton_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.reloadButton_pictureBox_MouseMove);
            // 
            // deleteButton_pictureBox
            // 
            resources.ApplyResources(this.deleteButton_pictureBox, "deleteButton_pictureBox");
            this.deleteButton_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton_pictureBox.Image = global::Курсова.Properties.Resources.iconfinder_Delete_dustbin_empty_recycle_recycling_remove_trash_1886812;
            this.deleteButton_pictureBox.Name = "deleteButton_pictureBox";
            this.deleteButton_pictureBox.TabStop = false;
            this.deleteButton_pictureBox.Click += new System.EventHandler(this.deleteButton_pictureBox_Click);
            this.deleteButton_pictureBox.MouseLeave += new System.EventHandler(this.deleteButton_pictureBox_MouseLeave);
            this.deleteButton_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.deleteButton_pictureBox_MouseMove);
            // 
            // saveFileButton_pictureBox
            // 
            resources.ApplyResources(this.saveFileButton_pictureBox, "saveFileButton_pictureBox");
            this.saveFileButton_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveFileButton_pictureBox.Image = global::Курсова.Properties.Resources.iconfinder_save_981083;
            this.saveFileButton_pictureBox.Name = "saveFileButton_pictureBox";
            this.saveFileButton_pictureBox.TabStop = false;
            this.saveFileButton_pictureBox.Click += new System.EventHandler(this.saveFileButton_pictureBox_Click);
            this.saveFileButton_pictureBox.MouseLeave += new System.EventHandler(this.saveFileButton_pictureBox_MouseLeave);
            this.saveFileButton_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.saveFileButton_pictureBox_MouseMove);
            // 
            // addButton_pictureBox
            // 
            resources.ApplyResources(this.addButton_pictureBox, "addButton_pictureBox");
            this.addButton_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton_pictureBox.Name = "addButton_pictureBox";
            this.addButton_pictureBox.TabStop = false;
            this.addButton_pictureBox.Click += new System.EventHandler(this.addButton_pictureBox_Click);
            this.addButton_pictureBox.MouseLeave += new System.EventHandler(this.addButton_pictureBox_MouseLeave);
            this.addButton_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.addButton_pictureBox_MouseMove);
            // 
            // openFileButton_pictureBox
            // 
            resources.ApplyResources(this.openFileButton_pictureBox, "openFileButton_pictureBox");
            this.openFileButton_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFileButton_pictureBox.Image = global::Курсова.Properties.Resources._1486504817_data_doc_folder_data_storage_file_storage_open_81345;
            this.openFileButton_pictureBox.Name = "openFileButton_pictureBox";
            this.openFileButton_pictureBox.TabStop = false;
            this.openFileButton_pictureBox.Click += new System.EventHandler(this.openFileButton_pictureBox_Click);
            this.openFileButton_pictureBox.MouseLeave += new System.EventHandler(this.openFileButton_pictureBox_MouseLeave);
            this.openFileButton_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openFileButton_pictureBox_MouseMove);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.acceptButton_pictureBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.newPrice_textBox);
            this.Controls.Add(this.editPriceButton_pictureBox);
            this.Controls.Add(this.filterButton_pictureBox);
            this.Controls.Add(this.piece_label);
            this.Controls.Add(this.reloadButton_pictureBox);
            this.Controls.Add(this.deleteButton_pictureBox);
            this.Controls.Add(this.value3_label);
            this.Controls.Add(this.value2_label);
            this.Controls.Add(this.value1_label);
            this.Controls.Add(this.dateExpiration_label);
            this.Controls.Add(this.dimensionsOrDateCreation_label);
            this.Controls.Add(this.weightOrGroup_label);
            this.Controls.Add(this.items_listView);
            this.Controls.Add(this.saveFileButton_pictureBox);
            this.Controls.Add(this.addButton_pictureBox);
            this.Controls.Add(this.openFileButton_pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPriceButton_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterButton_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reloadButton_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveFileButton_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButton_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFileButton_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox openFileButton_pictureBox;
        private System.Windows.Forms.PictureBox addButton_pictureBox;
        private System.Windows.Forms.PictureBox saveFileButton_pictureBox;
        private System.Windows.Forms.ListView items_listView;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnProducer;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label weightOrGroup_label;
        private System.Windows.Forms.Label dimensionsOrDateCreation_label;
        private System.Windows.Forms.Label dateExpiration_label;
        private System.Windows.Forms.Label value1_label;
        private System.Windows.Forms.Label value2_label;
        private System.Windows.Forms.Label value3_label;
        private System.Windows.Forms.PictureBox deleteButton_pictureBox;
        private System.Windows.Forms.PictureBox reloadButton_pictureBox;
        private System.Windows.Forms.Label piece_label;
        private System.Windows.Forms.PictureBox filterButton_pictureBox;
        private System.Windows.Forms.PictureBox editPriceButton_pictureBox;
        private System.Windows.Forms.TextBox newPrice_textBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox acceptButton_pictureBox;
    }
}


using System;
using System.Drawing;
using System.Windows.Forms;

namespace Курсова
{
    public partial class Main : Form
    {
        private Storage storage = new Storage();
        private int index = 0;
        public Main()
        {
            InitializeComponent();
        }

        private void openFileButton_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            openFileButton_pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void openFileButton_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            openFileButton_pictureBox.BorderStyle = BorderStyle.None;
        }

        private void addButton_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            addButton_pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void addButton_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            addButton_pictureBox.BorderStyle = BorderStyle.None;
        }

        private void addButton_pictureBox_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.ShowDialog();
            bool check = false;
            if (add.isGrocerie == 1)
            {
                foreach (Goods item in storage.GetStorage)
                {
                    if (item is Groceries)
                    {
                        Groceries tmp = item as Groceries;
                        if (tmp == add.groceries)
                        {
                            item.quantity += add.groceries.quantity;
                            check = true;
                            foreach (ListViewItem i in items_listView.Items)
                            {
                                if (i.Tag is Groceries)
                                {
                                    Groceries grocerie = i.Tag as Groceries;
                                    if (grocerie == add.groceries)
                                    {
                                        i.SubItems[4].Text = item.quantity.ToString();
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    }
                }
                if (check == false)
                {
                    storage.AddItem(add.groceries);
                    if (add.groceries.isChanged == true)
                        MessageBox.Show("Price was reduced", "Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListViewItem listViewItem = new ListViewItem(add.groceries.name, 0);
                    listViewItem.Tag = add.groceries;
                    listViewItem.SubItems.Add("Grocerie");
                    listViewItem.SubItems.Add(add.groceries.producer);
                    listViewItem.SubItems.Add(add.groceries.price.ToString());
                    listViewItem.SubItems.Add(add.groceries.quantity.ToString());
                    items_listView.Items.Add(listViewItem);
                }
            }
            else if (add.isGrocerie == 2)
            {
                foreach (Goods item in storage.GetStorage)
                {
                    if (item is NonGroceries)
                    {
                        NonGroceries tmp = item as NonGroceries;
                        if (tmp == add.nonGroceries)
                        {
                            item.quantity += add.nonGroceries.quantity;
                            check = true;
                            foreach (ListViewItem i in items_listView.Items)
                            {
                                if (i.Tag is NonGroceries)
                                {
                                    NonGroceries nonGrocerie = i.Tag as NonGroceries;
                                    if (nonGrocerie == add.nonGroceries)
                                    {
                                        i.SubItems[4].Text = item.quantity.ToString();
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    }
                }
                if (check == false)
                {
                    storage.AddItem(add.nonGroceries);
                    if (storage.GetStorage[storage.GetStorage.Count - 1].isChanged)
                        MessageBox.Show("Price was increased", "Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListViewItem listViewItem = new ListViewItem(add.nonGroceries.name, 1);
                    listViewItem.Tag = add.nonGroceries;
                    listViewItem.SubItems.Add("NonGrocerie");
                    listViewItem.SubItems.Add(add.nonGroceries.producer);
                    listViewItem.SubItems.Add(add.nonGroceries.price.ToString());
                    listViewItem.SubItems.Add(add.nonGroceries.quantity.ToString());
                    items_listView.Items.Add(listViewItem);
                }
            }
        }

        private void saveFileButton_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            saveFileButton_pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void saveFileButton_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            saveFileButton_pictureBox.BorderStyle = BorderStyle.None;
        }

        private void saveFileButton_pictureBox_Click(object sender, EventArgs e)
        {
            if (storage.GetStorage.Count == 0)
            {
                MessageBox.Show("The storage is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save file";
            saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName.Length > 0)
            {
                using (System.IO.StreamWriter sf = new System.IO.StreamWriter(saveFile.FileName))
                {
                    foreach (Goods item in storage.GetStorage)
                    {
                        if (item is Groceries)
                        {
                            Groceries tmp = item as Groceries;
                            sf.WriteLine("Grocerie");
                            sf.WriteLine(tmp.name);
                            sf.WriteLine(tmp.producer);
                            sf.WriteLine(tmp.price);
                            sf.WriteLine(tmp.quantity);
                            sf.WriteLine(tmp.weight);
                            sf.WriteLine(tmp.dateCreation);
                            sf.WriteLine(tmp.dateExpiration);
                        }
                        else
                        {
                            NonGroceries tmp = item as NonGroceries;
                            sf.WriteLine("Non-Grocerie");
                            sf.WriteLine(tmp.name);
                            sf.WriteLine(tmp.producer);
                            sf.WriteLine(tmp.price);
                            sf.WriteLine(tmp.quantity);
                            sf.WriteLine(tmp.dimensions.height);
                            sf.WriteLine(tmp.dimensions.length);
                            sf.WriteLine(tmp.dimensions.width);
                            switch (tmp.group)
                            {
                                case DestinationGroup.Nothing:
                                    sf.WriteLine(1);
                                    break;
                                case DestinationGroup.Clothes:
                                    sf.WriteLine(2);
                                    break;
                                case DestinationGroup.Machinery:
                                    sf.WriteLine(3);
                                    break;
                                case DestinationGroup.Furniture:
                                    sf.WriteLine(4);
                                    break;
                                case DestinationGroup.Dishes:
                                    sf.WriteLine(5);
                                    break;
                                case DestinationGroup.Jewelry:
                                    sf.WriteLine(6);
                                    break;
                            }
                        }
                    }
                    sf.Close();
                }
            }
            MessageBox.Show("File saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void openFileButton_pictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Open from file";
                openFile.Filter = "Text files (*.txt)|*.txt";
                if (openFile.ShowDialog() == DialogResult.OK && openFile.FileName.Length > 0)
                {
                    using (System.IO.StreamReader of = new System.IO.StreamReader(openFile.FileName))
                    {
                        while (!of.EndOfStream)
                        {
                            bool check = false;
                            string type = of.ReadLine();
                            if (type == "Grocerie")
                            {
                                string name = of.ReadLine();
                                if (name == "")
                                    name = "No_name";
                                string producer = of.ReadLine();
                                if (producer == "")
                                    producer = "No_producer";
                                string strPrice = of.ReadLine();
                                int price;
                                if (int.TryParse(strPrice, out price) == false)
                                    price = 0;
                                string strQuantity = of.ReadLine();
                                int quantity;
                                if (int.TryParse(strQuantity, out quantity) == false)
                                    quantity = 0;
                                string strWeight = of.ReadLine();
                                int weight;
                                if (int.TryParse(strWeight, out weight) == false)
                                    weight = 0;
                                string strDate = of.ReadLine();
                                DateTime dateCreation;
                                if (DateTime.TryParse(strDate, out dateCreation) == false)
                                    dateCreation = DateTime.Now;
                                strDate = of.ReadLine();
                                DateTime dateExpiration;
                                if (DateTime.TryParse(strDate, out dateExpiration) == false)
                                    dateExpiration = DateTime.Now;
                                Groceries grocerie = new Groceries(name, producer, price, quantity, weight, dateCreation, dateExpiration);
                                foreach (Goods item in storage.GetStorage)
                                {
                                    if (item is Groceries)
                                    {
                                        Groceries tmp = item as Groceries;
                                        if (tmp == grocerie)
                                        {
                                            check = true;
                                            item.quantity += grocerie.quantity;
                                            for (int i = 0; i < items_listView.Items.Count; i++)
                                                if (items_listView.Items[i].Tag == item)
                                                    items_listView.Items[i].SubItems[4].Text = item.quantity.ToString();
                                            break;
                                        }
                                    }
                                }
                                if (check)
                                    continue;
                                storage.AddItem(grocerie);
                                ListViewItem listViewItem = new ListViewItem(grocerie.name, 0);
                                listViewItem.Tag = grocerie;
                                listViewItem.SubItems.Add("Grocerie");
                                listViewItem.SubItems.Add(grocerie.producer);
                                listViewItem.SubItems.Add(grocerie.price.ToString());
                                listViewItem.SubItems.Add(grocerie.quantity.ToString());
                                items_listView.Items.Add(listViewItem);
                            }
                            else if (type == "Non-Grocerie")
                            {
                                string name = of.ReadLine();
                                if (name == "")
                                    name = "No_name";
                                string producer = of.ReadLine();
                                if (producer == "")
                                    producer = "No_producer";
                                string strPrice = of.ReadLine();
                                int price;
                                if (int.TryParse(strPrice, out price) == false)
                                    price = 0;
                                string strQuantity = of.ReadLine();
                                int quantity;
                                if (int.TryParse(strQuantity, out quantity) == false)
                                    quantity = 0;
                                Dimensions dimensions = new Dimensions();
                                string dimension = of.ReadLine();
                                if (int.TryParse(dimension, out dimensions.height) == false)
                                    dimensions.height = 0;
                                dimension = of.ReadLine();
                                if (int.TryParse(dimension, out dimensions.length))
                                    dimensions.length = 0;
                                dimension = of.ReadLine();
                                if (int.TryParse(dimension, out dimensions.width) == false)
                                    dimensions.width = 0;
                                string strGroup = of.ReadLine();
                                int group;
                                if (int.TryParse(strGroup, out group) == false)
                                    group = 0;
                                DestinationGroup destinationGroup = new DestinationGroup();
                                switch (group)
                                {
                                    case 2:
                                        destinationGroup = DestinationGroup.Clothes;
                                        break;
                                    case 3:
                                        destinationGroup = DestinationGroup.Machinery;
                                        break;
                                    case 4:
                                        destinationGroup = DestinationGroup.Furniture;
                                        break;
                                    case 5:
                                        destinationGroup = DestinationGroup.Dishes;
                                        break;
                                    case 6:
                                        destinationGroup = DestinationGroup.Jewelry;
                                        break;
                                    default:
                                        destinationGroup = DestinationGroup.Nothing;
                                        break;
                                }
                                NonGroceries nonGroceries = new NonGroceries(name, producer, price, quantity, dimensions, destinationGroup);
                                foreach (Goods item in storage.GetStorage)
                                {
                                    if (item is NonGroceries)
                                    {
                                        NonGroceries tmp = item as NonGroceries;
                                        if (tmp == nonGroceries)
                                        {
                                            check = true;
                                            item.quantity += nonGroceries.quantity;
                                            item.quantity += nonGroceries.quantity;
                                            for (int i = 0; i < items_listView.Items.Count; i++)
                                                if (items_listView.Items[i].Tag == item)
                                                    items_listView.Items[i].SubItems[4].Text = item.quantity.ToString();
                                            break;
                                        }
                                    }
                                }
                                if (check)
                                    continue;
                                storage.AddItem(nonGroceries);
                                ListViewItem listViewItem = new ListViewItem(nonGroceries.name, 1);
                                listViewItem.Tag = nonGroceries;
                                listViewItem.SubItems.Add("NonGrocerie");
                                listViewItem.SubItems.Add(nonGroceries.producer);
                                listViewItem.SubItems.Add(nonGroceries.price.ToString());
                                listViewItem.SubItems.Add(nonGroceries.quantity.ToString());
                                items_listView.Items.Add(listViewItem);
                            }
                            else if (type == "")
                            {
                                return;
                            }
                            else
                            {
                                Exception exception = new Exception("File have mistakes");
                                throw exception;
                            }
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int Counter(string name)
        {
            int res = 0;
            foreach (Goods item in storage.GetStorage)
            {
                if (item.name == name)
                    res += item.quantity;
            }
            return res;
        }
        private void items_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (items_listView.SelectedIndices.Count == 0)
            {
                weightOrGroup_label.Visible = false;
                value1_label.Visible = false;
                dimensionsOrDateCreation_label.Visible = false;
                value2_label.Visible = false;
                dateExpiration_label.Visible = false;
                value3_label.Visible = false;
                piece_label.Text = "0 pieces";
                index = -1;
            }
            else
            {
                index = items_listView.SelectedIndices.Count - 1;
                var item = items_listView.SelectedItems[items_listView.SelectedIndices.Count - 1].Tag;
                if (item is Groceries)
                {
                    Groceries tmp = item as Groceries;
                    weightOrGroup_label.Visible = true;
                    weightOrGroup_label.Text = "Weight:";
                    value1_label.Visible = true;
                    value1_label.Text = tmp.weight.ToString();
                    dimensionsOrDateCreation_label.Visible = true;
                    dimensionsOrDateCreation_label.Text = "Creation date:";
                    value2_label.Visible = true;
                    value2_label.Text = tmp.dateCreation.ToShortDateString().ToString();
                    dateExpiration_label.Visible = true;
                    value3_label.Visible = true;
                    value3_label.Text = tmp.dateExpiration.ToShortDateString().ToString();
                    piece_label.Text = Counter(tmp.name).ToString() + " pieces";
                }
                else
                {
                    value3_label.Visible = false;
                    dateExpiration_label.Visible = false;
                    NonGroceries tmp = item as NonGroceries;
                    weightOrGroup_label.Visible = true;
                    weightOrGroup_label.Text = "Group:";
                    value1_label.Visible = true;
                    switch (tmp.group)
                    {
                        case DestinationGroup.Nothing:
                            value1_label.Text = "Nothing";
                            break;
                        case DestinationGroup.Clothes:
                            value1_label.Text = "Clothes";
                            break;
                        case DestinationGroup.Machinery:
                            value1_label.Text = "Machinery";
                            break;
                        case DestinationGroup.Furniture:
                            value1_label.Text = "Furniture";
                            break;
                        case DestinationGroup.Dishes:
                            value1_label.Text = "Dishes";
                            break;
                        case DestinationGroup.Jewelry:
                            value1_label.Text = "Jewelry";
                            break;
                        default:
                            break;
                    }
                    dimensionsOrDateCreation_label.Visible = true;
                    dimensionsOrDateCreation_label.Text = "Dimensions:";
                    value2_label.Visible = true;
                    value2_label.Text = tmp.dimensions.height.ToString() + "x" + tmp.dimensions.length.ToString() + "x" + tmp.dimensions.width.ToString();
                    piece_label.Text = Counter(tmp.name).ToString() + " pieces";
                }
            }
        }

        private void deleteButton_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            deleteButton_pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void deleteButton_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            deleteButton_pictureBox.BorderStyle = BorderStyle.None;
        }

        private void deleteButton_pictureBox_Click(object sender, EventArgs e)
        {
            var items = items_listView.SelectedItems;
            if (items.Count != 0)
            {
                if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (var item in items)
                    {
                        ListViewItem listViewItem = item as ListViewItem;
                        storage.DeleteItem(listViewItem.Tag as Goods);
                    }
                    Update();
                    weightOrGroup_label.Visible = false;
                    value1_label.Visible = false;
                    dimensionsOrDateCreation_label.Visible = false;
                    value2_label.Visible = false;
                    dateExpiration_label.Visible = false;
                    value3_label.Visible = false;
                }
            }
        }

        private void reloadButton_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            reloadButton_pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void reloadButton_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            reloadButton_pictureBox.BorderStyle = BorderStyle.None;
        }

        private void reloadButton_pictureBox_Click(object sender, EventArgs e)
        {
            TimeSpan usingTime;
            TimeSpan remainingTime;
            double usingTimeI;
            double remainingTimeI;
            for (int i = 0; i < storage.GetStorage.Count; i++)
            {
                foreach (Goods item in storage.GetStorage)
                {
                    if (item is Groceries)
                    {
                        Groceries tmp = item as Groceries;
                        if (tmp.dateExpiration < DateTime.Now)
                        {
                            storage.DeleteItem(item);
                            break;
                        }
                        else if (item.isChanged == false)
                        {
                            usingTime = tmp.dateExpiration - tmp.dateCreation;
                            remainingTime = tmp.dateExpiration - DateTime.Now;
                            usingTimeI = usingTime.TotalSeconds;
                            remainingTimeI = remainingTime.TotalSeconds;
                            if ((usingTimeI * 0.2) <= remainingTimeI)
                            {
                                item.price /= 2;
                                item.isChanged = true;
                            }
                        }
                    }
                }
            }
            Update();
        }
        private void Update()
        {
            items_listView.Items.Clear();
            foreach (Goods item in storage.GetStorage)
            {
                ListViewItem listViewItem;
                if (item is Groceries)
                {
                    listViewItem = new ListViewItem(item.name, 0);
                    listViewItem.SubItems.Add("Grocerie");
                }
                else
                {
                    listViewItem = new ListViewItem(item.name, 1);
                    listViewItem.SubItems.Add("NonGrocerie");
                }
                listViewItem.Tag = item;
                listViewItem.SubItems.Add(item.producer);
                listViewItem.SubItems.Add(item.price.ToString());
                listViewItem.SubItems.Add(item.quantity.ToString());
                items_listView.Items.Add(listViewItem);
            }
        }

        private void items_listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (items_listView.Sorting)
            {
                case SortOrder.None:
                    items_listView.Sorting = SortOrder.Ascending;
                    break;
                case SortOrder.Ascending:
                    items_listView.Sorting = SortOrder.Descending;
                    break;
                case SortOrder.Descending:
                    items_listView.Sorting = SortOrder.Ascending;
                    break;
            }
            items_listView.ListViewItemSorter = new CompareItems(e.Column, items_listView.Sorting);
        }

        private void filterButton_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            filterButton_pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void filterButton_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            filterButton_pictureBox.BorderStyle = BorderStyle.None;
        }

        private void filterButton_pictureBox_Click(object sender, EventArgs e)
        {
            if (storage.GetStorage.Count == 0)
            {
                MessageBox.Show("Storage is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FilterForm filterForm = new FilterForm(storage);
            filterForm.ShowDialog();
        }

        private void editPriceButton_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            editPriceButton_pictureBox.BorderStyle = BorderStyle.None;
        }

        private void editPriceButton_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            editPriceButton_pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void editPriceButton_pictureBox_Click(object sender, EventArgs e)
        {
            if (items_listView.SelectedIndices.Count != 0)
            {
                label.Visible = true;
                newPrice_textBox.Visible = true;
                acceptButton_pictureBox.Visible = true;
                newPrice_textBox.Focus();
            }
        }

        private void acceptButton_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            acceptButton_pictureBox.BackColor = Color.AliceBlue;
        }

        private void acceptButton_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            acceptButton_pictureBox.BackColor = SystemColors.ActiveCaption;
        }

        private void acceptButton_pictureBox_Click(object sender, EventArgs e)
        {
            if (newPrice_textBox.Text != String.Empty)
            {
                storage.GetStorage[index].price = int.Parse(newPrice_textBox.Text);
                Update();
            }
            label.Visible = false;
            newPrice_textBox.Text = "";
            newPrice_textBox.Visible = false;
            acceptButton_pictureBox.Visible = false;
        }

        private void newPrice_textBox_Leave(object sender, EventArgs e)
        {
            label.Visible = false;
            newPrice_textBox.Text = "";
            newPrice_textBox.Visible = false;
            acceptButton_pictureBox.Visible = false;
        }

        private void newPrice_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !e.KeyChar.Equals(Convert.ToChar(Keys.Back)))
                e.Handled = true;
            else
                e.Handled = false;
        }
    }
}

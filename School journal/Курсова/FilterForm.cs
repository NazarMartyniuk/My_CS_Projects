using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Курсова
{
    public partial class FilterForm : Form
    {
        Storage filterStorage;
        public FilterForm(Storage storage)
        {
            InitializeComponent();
            filterStorage = storage;
        }

        private void acceptButton_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            acceptButton_pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void acceptButton_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            acceptButton_pictureBox.BorderStyle = BorderStyle.None;
        }

        private void acceptButton_pictureBox_Click(object sender, EventArgs e)
        {
            items_listView.Items.Clear();
            List<Goods> filterGoods = new List<Goods>();
            bool check = false;
            if (name_textBox.Text != String.Empty)
            {
                check = true;
                foreach (Goods item in filterStorage.GetStorage)
                {
                    if (item.name == name_textBox.Text)
                        filterGoods.Add(item);
                }
            }
            if (producer_textBox.Text != String.Empty)
            {
                if (check)
                {
                    for (int i = filterGoods.Count; i >= 0; i--)
                        foreach (Goods item in filterGoods)
                        {
                            if (item.producer != producer_textBox.Text)
                            {
                                filterGoods.Remove(item);
                                break;
                            }
                        }
                }
                else
                {
                    check = true;
                    foreach (Goods item in filterStorage.GetStorage)
                    {
                        if (item.producer == producer_textBox.Text)
                            filterGoods.Add(item);
                    }
                }
            }
            if (outPrice_textBox.Text != String.Empty && toPrice_textBox.Text != String.Empty)
            {
                if (check)
                {
                    for (int i = filterGoods.Count; i >= 0; i--)
                        foreach (Goods item in filterGoods)
                        {
                            if (item.price < int.Parse(outPrice_textBox.Text) || item.price > int.Parse(toPrice_textBox.Text))
                            {
                                filterGoods.Remove(item);
                                break;
                            }
                        }
                }
                else
                {
                    check = true;
                    foreach (Goods item in filterStorage.GetStorage)
                    {
                        if (item.price >= int.Parse(outPrice_textBox.Text) && item.price <= int.Parse(toPrice_textBox.Text))
                            filterGoods.Add(item);
                    }
                }
            }
            if (outQuantity_textBox.Text != String.Empty && toQuantity_textBox.Text != String.Empty)
            {
                if (check)
                {
                    for (int i = filterGoods.Count; i >= 0; i--)
                        foreach (Goods item in filterGoods)
                        {
                            if (item.quantity < int.Parse(outQuantity_textBox.Text) || item.quantity > int.Parse(toQuantity_textBox.Text))
                            {
                                filterGoods.Remove(item);
                                break;
                            }
                        }
                }
                else
                {
                    check = true;
                    foreach (Goods item in filterStorage.GetStorage)
                    {
                        if (item.quantity >= int.Parse(outQuantity_textBox.Text) && item.quantity <= int.Parse(toQuantity_textBox.Text))
                            filterGoods.Add(item);
                    }
                }
            }
            if (grocerie_radioButton.Checked)
            {
                if (outWeight_textBox.Text != String.Empty && toWeight_textBox.Text != String.Empty)
                {
                    if (check)
                    {
                        for (int i = filterGoods.Count; i >= 0; i--)
                            foreach (Goods item in filterGoods)
                            {
                                if (item is Groceries)
                                {
                                    Groceries tmp = item as Groceries;
                                    if (tmp.weight < int.Parse(outWeight_textBox.Text) || tmp.weight > int.Parse(toWeight_textBox.Text))
                                    {
                                        filterGoods.Remove(item);
                                        break;
                                    }
                                }
                                else
                                {
                                    filterGoods.Remove(item);
                                    break;
                                }
                            }
                    }
                    else
                    {
                        check = true;
                        foreach (Goods item in filterStorage.GetStorage)
                        {
                            if (item is Groceries)
                            {
                                Groceries tmp = item as Groceries;
                                if (tmp.weight >= int.Parse(outWeight_textBox.Text) && tmp.weight <= int.Parse(toWeight_textBox.Text))
                                    filterGoods.Add(item);
                            }
                        }
                    }
                }
                if (cDEnabled_checkBox.Checked)
                {
                    if (check)
                    {
                        for (int i = filterGoods.Count; i >= 0; i--)
                            foreach (Goods item in filterGoods)
                            {
                                if (item is Groceries)
                                {
                                    Groceries tmp = item as Groceries;
                                    if (tmp.dateCreation < outDateCreation_dateTimePicker.Value || tmp.dateCreation > toDateCreation_dateTimePicker.Value)
                                    {
                                        filterGoods.Remove(item);
                                        break;
                                    }
                                }
                                else
                                {
                                    filterGoods.Remove(item);
                                    break;
                                }
                            }
                    }
                    else
                    {
                        check = true;
                        foreach (Goods item in filterStorage.GetStorage)
                        {
                            if (item is Groceries)
                            {
                                Groceries tmp = item as Groceries;
                                if (tmp.dateCreation >= outDateCreation_dateTimePicker.Value && tmp.dateCreation <= toDateCreation_dateTimePicker.Value)
                                    filterGoods.Add(item);
                            }
                        }
                    }
                }
                if (eDEnabled_checkBox.Checked)
                {
                    if (check)
                    {
                        for (int i = filterGoods.Count; i >= 0; i--)
                            foreach (Goods item in filterGoods)
                            {
                                if (item is Groceries)
                                {
                                    Groceries tmp = item as Groceries;
                                    if (tmp.dateExpiration < outDateExpiration_dateTimePicker.Value || tmp.dateExpiration > toDateExpiration_dateTimePicker.Value)
                                    {
                                        filterGoods.Remove(item);
                                        break;
                                    }
                                }
                                else
                                {
                                    filterGoods.Remove(item);
                                    break;
                                }
                            }
                    }
                    else
                    {
                        check = true;
                        foreach (Goods item in filterStorage.GetStorage)
                        {
                            if (item is Groceries)
                            {
                                Groceries tmp = item as Groceries;
                                if (tmp.dateExpiration >= outDateExpiration_dateTimePicker.Value && tmp.dateExpiration <= toDateExpiration_dateTimePicker.Value)
                                    filterGoods.Add(item);
                            }
                        }
                    }
                }
            }
            else
            {
                if (outWidth_textBox.Text != String.Empty && toWidth_textBox.Text != String.Empty)
                {
                    if (check)
                    {
                        for (int i = filterGoods.Count; i >= 0; i--)
                            foreach (Goods item in filterGoods)
                            {
                                if (item is NonGroceries)
                                {
                                    NonGroceries tmp = item as NonGroceries;
                                    if (tmp.dimensions.width < int.Parse(outWidth_textBox.Text) || tmp.dimensions.width > int.Parse(toWidth_textBox.Text))
                                    {
                                        filterGoods.Remove(item);
                                        break;
                                    }
                                }
                                else
                                {
                                    filterGoods.Remove(item);
                                    break;
                                }
                            }
                    }
                    else
                    {
                        check = true;
                        foreach (Goods item in filterStorage.GetStorage)
                        {
                            if (item is NonGroceries)
                            {
                                NonGroceries tmp = item as NonGroceries;
                                if (tmp.dimensions.width >= int.Parse(outWidth_textBox.Text) && tmp.dimensions.width <= int.Parse(toWidth_textBox.Text))
                                    filterGoods.Add(item);
                            }
                        }
                    }
                }
                if (outHeight_textBox.Text != String.Empty && toHeight_textBox.Text != String.Empty)
                {
                    if (check)
                    {
                        for (int i = filterGoods.Count; i >= 0; i--)
                            foreach (Goods item in filterGoods)
                            {
                                if (item is NonGroceries)
                                {
                                    NonGroceries tmp = item as NonGroceries;
                                    if (tmp.dimensions.height < int.Parse(outHeight_textBox.Text) || tmp.dimensions.height > int.Parse(toHeight_textBox.Text))
                                    {
                                        filterGoods.Remove(item);
                                        break;
                                    }
                                }
                                else
                                {
                                    filterGoods.Remove(item);
                                    break;
                                }
                            }
                    }
                    else
                    {
                        check = true;
                        foreach (Goods item in filterStorage.GetStorage)
                        {
                            if (item is NonGroceries)
                            {
                                NonGroceries tmp = item as NonGroceries;
                                if (tmp.dimensions.height >= int.Parse(outHeight_textBox.Text) && tmp.dimensions.height <= int.Parse(toHeight_textBox.Text))
                                    filterGoods.Add(item);
                            }
                        }
                    }
                }
                if (outLength_textBox.Text != String.Empty && toLength_textBox.Text != String.Empty)
                {
                    if (check)
                    {
                        for (int i = filterGoods.Count; i >= 0; i--)
                            foreach (Goods item in filterGoods)
                            {
                                if (item is NonGroceries)
                                {
                                    NonGroceries tmp = item as NonGroceries;
                                    if (tmp.dimensions.length < int.Parse(outLength_textBox.Text) || tmp.dimensions.length > int.Parse(toLength_textBox.Text))
                                    {
                                        filterGoods.Remove(item);
                                        break;
                                    }
                                }
                                else
                                {
                                    filterGoods.Remove(item);
                                    break;
                                }
                            }
                    }
                    else
                    {
                        check = true;
                        foreach (Goods item in filterStorage.GetStorage)
                        {
                            if (item is NonGroceries)
                            {
                                NonGroceries tmp = item as NonGroceries;
                                if (tmp.dimensions.length >= int.Parse(outLength_textBox.Text) && tmp.dimensions.length <= int.Parse(toLength_textBox.Text))
                                    filterGoods.Add(item);
                            }
                        }
                    }
                }
                if (group_comboBox.SelectedIndex != -1)
                {
                    DestinationGroup group;
                    switch (group_comboBox.SelectedIndex)
                    {
                        case 0:
                            group = DestinationGroup.Clothes;
                            break;
                        case 1:
                            group = DestinationGroup.Machinery;
                            break;
                        case 2:
                            group = DestinationGroup.Furniture;
                            break;
                        case 3:
                            group = DestinationGroup.Dishes;
                            break;
                        case 4:
                            group = DestinationGroup.Jewelry;
                            break;
                        default:
                            group = DestinationGroup.Nothing;
                            break;
                    }
                    if (check)
                    {
                        for (int i = filterGoods.Count; i >= 0; i--)
                            foreach (Goods item in filterGoods)
                            {
                                if (item is NonGroceries)
                                {
                                    NonGroceries tmp = item as NonGroceries;
                                    if (tmp.group != group)
                                    {
                                        filterGoods.Remove(item);
                                        break;
                                    }
                                }
                                else
                                {
                                    filterGoods.Remove(item);
                                    break;
                                }
                            }
                    }
                    else
                    {
                        check = true;
                        foreach (Goods item in filterStorage.GetStorage)
                        {
                            if (item is NonGroceries)
                            {
                                NonGroceries tmp = item as NonGroceries;
                                if (tmp.group == group)
                                    filterGoods.Add(item);
                            }
                        }
                    }
                }
            }
            if (check)
            {
                foreach (Goods item in filterGoods)
                {
                    ListViewItem listViewItem = new ListViewItem(item.name);
                    if (item is Groceries)
                        listViewItem.SubItems.Add("Grocerie");
                    else
                        listViewItem.SubItems.Add("NonGrocerie");
                    listViewItem.SubItems.Add(item.producer);
                    listViewItem.SubItems.Add(item.price.ToString());
                    listViewItem.SubItems.Add(item.quantity.ToString());
                    items_listView.Items.Add(listViewItem);
                }
            }
            else
            {
                foreach (Goods item in filterStorage.GetStorage)
                {
                    if (grocerie_radioButton.Checked)
                    {
                        if (item is Groceries)
                        {
                            ListViewItem listViewItem = new ListViewItem(item.name);
                            listViewItem.SubItems.Add("Grocerie");
                            listViewItem.SubItems.Add(item.price.ToString());
                            listViewItem.SubItems.Add(item.quantity.ToString());
                            items_listView.Items.Add(listViewItem);
                        }
                    }
                    else
                    {
                        if (item is NonGroceries)
                        {
                            ListViewItem listViewItem = new ListViewItem(item.name);
                            listViewItem.SubItems.Add("NonGrocerie");
                            listViewItem.SubItems.Add(item.price.ToString());
                            listViewItem.SubItems.Add(item.quantity.ToString());
                            items_listView.Items.Add(listViewItem);
                        }
                    }
                }
            }
        }

        private void uniqGoodsButton_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            uniqGoodsButton_pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void uniqGoodsButton_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            uniqGoodsButton_pictureBox.BorderStyle = BorderStyle.None;
        }

        private void uniqGoodsButton_pictureBox_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (name_textBox.Text == String.Empty || producer_textBox.Text == String.Empty || outPrice_textBox.Text == String.Empty || outQuantity_textBox.Text == String.Empty)
                check = true;
            List<Goods> uniqGoods;
            if (grocerie_radioButton.Checked)
            {
                if (outWeight_textBox.Text == String.Empty)
                    check = true;
                if (!cDEnabled_checkBox.Checked || !eDEnabled_checkBox.Checked)
                    check = true;
                if (!check)
                {
                    items_listView.Items.Clear();
                    toPrice_textBox.Text = outPrice_textBox.Text;
                    toQuantity_textBox.Text = outQuantity_textBox.Text;
                    toWeight_textBox.Text = outWeight_textBox.Text;
                    Groceries uniq = new Groceries(name_textBox.Text, producer_textBox.Text, int.Parse(outPrice_textBox.Text), int.Parse(outQuantity_textBox.Text), int.Parse(outWeight_textBox.Text), outDateCreation_dateTimePicker.Value, outDateExpiration_dateTimePicker.Value);
                    uniqGoods = filterStorage.FindUniqGoods(uniq);
                    foreach (Goods item in uniqGoods)
                    {
                        ListViewItem listViewItem = new ListViewItem(item.name);
                        listViewItem.SubItems.Add("Grocerie");
                        listViewItem.SubItems.Add(item.producer);
                        listViewItem.SubItems.Add(item.price.ToString());
                        listViewItem.SubItems.Add(item.quantity.ToString());
                        items_listView.Items.Add(listViewItem);
                    }
                }
                else
                {
                    MessageBox.Show("You need to fill all of the fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                if (outWidth_textBox.Text == String.Empty || outHeight_textBox.Text == String.Empty || outLength_textBox.Text == String.Empty || group_comboBox.SelectedIndex == -1)
                    check = true;
                if (!check)
                {
                    toWidth_textBox.Text = outWidth_textBox.Text;
                    toHeight_textBox.Text = outHeight_textBox.Text;
                    toLength_textBox.Text = outLength_textBox.Text;
                    Dimensions dimensions = new Dimensions();
                    dimensions.height = int.Parse(outHeight_textBox.Text);
                    dimensions.length = int.Parse(outLength_textBox.Text);
                    dimensions.width = int.Parse(outWidth_textBox.Text);
                    DestinationGroup group;
                    switch (group_comboBox.SelectedIndex)
                    {
                        case 0:
                            group = DestinationGroup.Clothes;
                            break;
                        case 1:
                            group = DestinationGroup.Machinery;
                            break;
                        case 2:
                            group = DestinationGroup.Furniture;
                            break;
                        case 3:
                            group = DestinationGroup.Dishes;
                            break;
                        case 4:
                            group = DestinationGroup.Jewelry;
                            break;
                        default:
                            group = DestinationGroup.Nothing;
                            break;
                    }
                    NonGroceries uniq = new NonGroceries(name_textBox.Text, producer_textBox.Text, int.Parse(outPrice_textBox.Text), int.Parse(outQuantity_textBox.Text), dimensions, group);
                    uniqGoods = filterStorage.FindUniqGoods(uniq);
                    foreach (Goods item in uniqGoods)
                    {
                        ListViewItem listViewItem = new ListViewItem(item.name);
                        listViewItem.SubItems.Add("NonGrocerie");
                        listViewItem.SubItems.Add(item.producer);
                        listViewItem.SubItems.Add(item.price.ToString());
                        listViewItem.SubItems.Add(item.quantity.ToString());
                        items_listView.Items.Add(listViewItem);
                    }
                }
                else
                {
                    MessageBox.Show("You need to fill all of the fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void nonGrocerie_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (grocerie_radioButton.Checked)
            {
                outDateCreation_dateTimePicker.Value = DateTime.Now.AddDays(-1);
                toDateExpiration_dateTimePicker.Value = DateTime.Now.AddDays(2);
                outWidth_textBox.Enabled = false;
                toWidth_textBox.Enabled = false;
                outHeight_textBox.Enabled = false;
                toHeight_textBox.Enabled = false;
                outLength_textBox.Enabled = false;
                toLength_textBox.Enabled = false;
                outWeight_textBox.Enabled = true;
                toWeight_textBox.Enabled = true;
                cDEnabled_checkBox.Enabled = true;
                eDEnabled_checkBox.Enabled = true;
                cDEnabled_checkBox.Checked = false;
                eDEnabled_checkBox.Checked = false;
                group_comboBox.Enabled = false;
            }
            else
            {
                outWidth_textBox.Enabled = true;
                toWidth_textBox.Enabled = true;
                outHeight_textBox.Enabled = true;
                toHeight_textBox.Enabled = true;
                outLength_textBox.Enabled = true;
                toLength_textBox.Enabled = true;
                outWeight_textBox.Enabled = false;
                toWeight_textBox.Enabled = false;
                cDEnabled_checkBox.Enabled = false;
                eDEnabled_checkBox.Enabled = false;
                group_comboBox.Enabled = true;

            }
            group_comboBox.SelectedIndex = -1;
            name_textBox.Text = String.Empty;
            producer_textBox.Text = String.Empty;
            outPrice_textBox.Text = String.Empty;
            toPrice_textBox.Text = String.Empty;
            outQuantity_textBox.Text = String.Empty;
            toQuantity_textBox.Text = String.Empty;
            outWeight_textBox.Text = String.Empty;
            toWeight_textBox.Text = String.Empty;
            outWidth_textBox.Text = String.Empty;
            toWidth_textBox.Text = String.Empty;
            outHeight_textBox.Text = String.Empty;
            toHeight_textBox.Text = String.Empty;
            outLength_textBox.Text = String.Empty;
            toLength_textBox.Text = String.Empty;
        }

        private void cDEnabled_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cDEnabled_checkBox.Checked)
            {
                outDateCreation_dateTimePicker.Enabled = true;
                toDateCreation_dateTimePicker.Enabled = true;
            }
            else
            {
                outDateCreation_dateTimePicker.Enabled = false;
                toDateCreation_dateTimePicker.Enabled = false;
            }
            if (eDEnabled_checkBox.Checked)
            {
                outDateExpiration_dateTimePicker.Enabled = true;
                toDateExpiration_dateTimePicker.Enabled = true;
            }
            else
            {
                outDateExpiration_dateTimePicker.Enabled = false;
                toDateExpiration_dateTimePicker.Enabled = false;
            }
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            outDateCreation_dateTimePicker.MinDate = DateTime.Now.AddYears(-100);
            outDateCreation_dateTimePicker.MaxDate = DateTime.Now;
            toDateCreation_dateTimePicker.MinDate = DateTime.Now.AddYears(-100);
            toDateCreation_dateTimePicker.MaxDate = DateTime.Now;
            outDateExpiration_dateTimePicker.MinDate = DateTime.Now.AddDays(1);
            outDateExpiration_dateTimePicker.MaxDate = DateTime.Now.AddYears(100);
            toDateExpiration_dateTimePicker.MaxDate = DateTime.Now.AddYears(100);
            toDateExpiration_dateTimePicker.MinDate = DateTime.Now.AddDays(1);
            grocerie_radioButton.Checked = true;
        }

        private void outPrice_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !e.KeyChar.Equals(Convert.ToChar(Keys.Back)))
                e.Handled = true;
            else
                e.Handled = false;
        }
    }
}

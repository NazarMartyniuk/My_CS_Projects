using System;
using System.Drawing;
using System.Windows.Forms;

namespace Курсова
{
    public partial class AddForm : Form
    {
        public Groceries groceries;
        public NonGroceries nonGroceries;
        public int isGrocerie;
        bool check = false;
        public AddForm()
        {
            InitializeComponent();
            dateCreation_dateTimePicker.MaxDate = DateTime.Now;
            dateCreation_dateTimePicker.Value = DateTime.Now;
            dateCreation_dateTimePicker.MinDate = DateTime.Now.AddYears(-100);
            dateExpiration_dateTimePicker.MaxDate = DateTime.Now.AddYears(100);
            dateExpiration_dateTimePicker.MinDate = DateTime.Today.AddDays(1);
        }
        private void type_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            acceptButton_pictureBox.Visible = true;
            name_textBox.ReadOnly = false;
            producer_textBox.ReadOnly = false;
            price_textBox.ReadOnly = false;
            price_textBox.Text = "0";
            price_textBox.ForeColor = SystemColors.InactiveCaption;
            quantity_label.Visible = true;
            quantity_numericUpDown.Visible = true;
            changable1_label.Visible = true;
            weightOrHeight_textBox.Visible = true;
            changable2_label.Visible = true;
            weightOrHeight_textBox.ForeColor = SystemColors.InactiveCaption;
            if (type_comboBox.SelectedItem.ToString() == "Grocerie")
            {
                isGrocerie = 1;
                changable1_label.Text = "WEIGHT(KG):";
                weightOrHeight_textBox.Text = "0";
                changable2_label.Text = "CREATION DATE:";
                length_textBox.Visible = false;
                width_textBox.Visible = false;
                destinationGroup_comboBox.Location = new Point(592, 292);
                destinationGroup_comboBox.Visible = false;
                dateCreation_dateTimePicker.Visible = true;
                dateCreation_dateTimePicker.Location = new Point(179, 239);
                expirationDate_label.Visible = true;
                dateExpiration_dateTimePicker.Visible = true;
            }
            else
            {
                isGrocerie = 2;
                changable1_label.Text = "DIMENSIONS:";
                weightOrHeight_textBox.Text = "Height";
                length_textBox.Visible = true;
                length_textBox.ForeColor = SystemColors.InactiveCaption;
                width_textBox.Visible = true;
                width_textBox.ForeColor = SystemColors.InactiveCaption;
                changable2_label.Text = "DESTINATION GROUP:";
                destinationGroup_comboBox.Location = new Point(200, 236);
                destinationGroup_comboBox.Visible = true;
                dateCreation_dateTimePicker.Visible = false;
                dateCreation_dateTimePicker.Location = new Point(592, 292);
                expirationDate_label.Visible = false;
                dateExpiration_dateTimePicker.Visible = false;
            }
        }
        private void price_textBox_Click(object sender, EventArgs e)
        {
            if (price_textBox.Text == "0")
            {
                price_textBox.Text = "";
                price_textBox.ForeColor = SystemColors.WindowText;
            }
        }
        private void price_textBox_Leave(object sender, EventArgs e)
        {
            if (price_textBox.Text == "")
            {
                price_textBox.Text = "0";
                price_textBox.ForeColor = SystemColors.InactiveCaption;
            }
        }
        private void price_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !e.KeyChar.Equals(Convert.ToChar(Keys.Back)))
                e.Handled = true;
            else
                e.Handled = false;
        }
        private void quantity_numericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !e.KeyChar.Equals(Convert.ToChar(Keys.Back)))
                e.Handled = true;
            else
                e.Handled = false;
        }
        private void weightOrHeight_textBox_Click(object sender, EventArgs e)
        {
            if (weightOrHeight_textBox.Text == "0" || weightOrHeight_textBox.Text == "Height")
            {
                weightOrHeight_textBox.Text = "";
                weightOrHeight_textBox.ForeColor = SystemColors.WindowText;
            }
        }
        private void weightOrHeight_textBox_Leave(object sender, EventArgs e)
        {
            if (weightOrHeight_textBox.Text == "" && type_comboBox.SelectedItem.ToString() == "Groceries")
            {
                weightOrHeight_textBox.Text = "0";
                weightOrHeight_textBox.ForeColor = SystemColors.InactiveCaption;
            }
            if (weightOrHeight_textBox.Text == "" && type_comboBox.SelectedItem.ToString() == "Non-grocerie")
            {
                weightOrHeight_textBox.Text = "Height";
                weightOrHeight_textBox.ForeColor = SystemColors.InactiveCaption;
            }
        }
        private void weightOrHeight_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !e.KeyChar.Equals(Convert.ToChar(Keys.Back)))
                e.Handled = true;
            else
                e.Handled = false;
        }
        private void length_textBox_Click(object sender, EventArgs e)
        {
            if (length_textBox.Text == "Length")
            {
                length_textBox.Text = "";
                length_textBox.ForeColor = SystemColors.WindowText;
            }
        }
        private void length_textBox_Leave(object sender, EventArgs e)
        {
            if (length_textBox.Text == "")
            {
                length_textBox.Text = "Length";
                length_textBox.ForeColor = SystemColors.InactiveCaption;
            }
        }
        private void length_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !e.KeyChar.Equals(Convert.ToChar(Keys.Back)))
                e.Handled = true;
            else
                e.Handled = false;
        }
        private void width_textBox_Click(object sender, EventArgs e)
        {
            if (width_textBox.Text == "Width")
            {
                width_textBox.Text = "";
                width_textBox.ForeColor = SystemColors.WindowText;
            }
        }
        private void width_textBox_Leave(object sender, EventArgs e)
        {
            if (width_textBox.Text == "")
            {
                width_textBox.Text = "Length";
                width_textBox.ForeColor = SystemColors.InactiveCaption;
            }
        }
        private void width_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !e.KeyChar.Equals(Convert.ToChar(Keys.Back)))
                e.Handled = true;
            else
                e.Handled = false;
        }
        private void acceptButton_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (type_comboBox.SelectedItem.ToString() == "Grocerie" || type_comboBox.SelectedItem.ToString() == "Non-grocerie")
                acceptButton_pictureBox.BackColor = Color.AliceBlue;
        }
        private void acceptButton_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            acceptButton_pictureBox.BackColor = SystemColors.ActiveCaption;
        }
        private void acceptButton_pictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                if (name_textBox.Text == "")
                {
                    Exception exception = new Exception("name");
                    throw exception;
                }
                if (producer_textBox.Text == "")
                {
                    Exception exception = new Exception("producer");
                    throw exception;
                }
                if (Convert.ToUInt64(price_textBox.Text) == 0)
                {
                    Exception exception = new Exception("price");
                    throw exception;
                }
                if (Convert.ToUInt16(quantity_numericUpDown.Value) == 0)
                {
                    Exception exception = new Exception("quantity");
                    throw exception;
                }
                if (type_comboBox.SelectedItem.ToString() == "Grocerie")
                    if (int.Parse(weightOrHeight_textBox.Text) == 0)
                    {
                        Exception exception = new Exception("weight");
                        throw exception;
                    }
                if (type_comboBox.SelectedItem.ToString() == "Non-grocerie")
                {
                    if (weightOrHeight_textBox.Text == "Height" || Convert.ToUInt64(weightOrHeight_textBox.Text) == 0 || length_textBox.Text == "Length" || Convert.ToUInt64(length_textBox.Text) == 0 || width_textBox.Text == "Width" || Convert.ToUInt64(width_textBox.Text) == 0)
                    {
                        Exception exception = new Exception("dimensions");
                        throw exception;
                    }
                    if (destinationGroup_comboBox.SelectedIndex == -1)
                    {
                        Exception exception = new Exception("destination group");
                        throw exception;
                    }
                }
                string name = name_textBox.Text;
                int price = Convert.ToInt32(price_textBox.Text);
                int quantity = Convert.ToInt32(quantity_numericUpDown.Value);
                string producer = producer_textBox.Text;
                if (type_comboBox.SelectedItem.ToString() == "Grocerie")
                {
                    check = true;
                    isGrocerie = 1;
                    int weight = Convert.ToInt32(weightOrHeight_textBox.Text);
                    DateTime dateCreation = dateCreation_dateTimePicker.Value;
                    DateTime expirationDate = dateExpiration_dateTimePicker.Value;
                    TimeSpan usingTime;
                    TimeSpan remainingTime;
                    double usingTimeI;
                    double remainingTimeI;
                    usingTime = expirationDate - dateCreation;
                    remainingTime = expirationDate - DateTime.Now;
                    usingTimeI = usingTime.TotalSeconds;
                    remainingTimeI = remainingTime.TotalSeconds;
                    bool isChanged;
                    if ((usingTimeI * 0.2) > remainingTimeI)
                    {
                        price /= 2;
                        isChanged = true;
                    }
                    else
                        isChanged = false;
                    groceries = new Groceries(name, producer, price, quantity, weight, dateCreation, expirationDate);
                    groceries.isChanged = isChanged;
                    this.Close();
                }
                else
                {
                    check = true;
                    isGrocerie = 2;
                    Dimensions dimensions = new Dimensions();
                    dimensions.height = Convert.ToInt32(weightOrHeight_textBox.Text);
                    dimensions.length = Convert.ToInt32(length_textBox.Text);
                    dimensions.width = Convert.ToInt32(width_textBox.Text);
                    DestinationGroup destinationGroup = new DestinationGroup();
                    switch (destinationGroup_comboBox.SelectedIndex)
                    {
                        case 0:
                            destinationGroup = DestinationGroup.Clothes;
                            break;
                        case 1:
                            destinationGroup = DestinationGroup.Machinery;
                            break;
                        case 2:
                            destinationGroup = DestinationGroup.Furniture;
                            break;
                        case 3:
                            destinationGroup = DestinationGroup.Dishes;
                            break;
                        case 4:
                            destinationGroup = DestinationGroup.Jewelry;
                            break;
                        default:
                            destinationGroup = DestinationGroup.Nothing;
                            break;
                    }
                    bool isChanged;
                    if ((dimensions.height + dimensions.length + dimensions.width) > 600)
                    {
                        price *= 120;
                        price /= 100;
                        isChanged = true;
                    }
                    else
                        isChanged = false;
                    nonGroceries = new NonGroceries(name, producer, price, quantity, dimensions, destinationGroup);
                    nonGroceries.isChanged = isChanged;
                    this.Close();
                }
            }
            catch (Exception text)
            {
                string message = "You made wrong input in ";
                message += text.Message;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (check == false)
                isGrocerie = 0;
        }

    }
}

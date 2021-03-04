using System.Collections;
using System.Windows.Forms;

namespace Курсова
{
    internal class CompareItems : IComparer
    {
        private int column;
        private SortOrder sorting;

        public CompareItems(int column, SortOrder sorting)
        {
            this.column = column;
            this.sorting = sorting;
        }

        public int Compare(object x, object y)
        {
            ListViewItem one = x as ListViewItem;
            ListViewItem two = y as ListViewItem;
            int mult = sorting == SortOrder.Ascending ? 1 : -1;
            if (column == 0)
            {
                return mult * one.Text.CompareTo(two.Text);
            }
            else if (column == 1)
            {
                return mult * one.SubItems[1].Text.CompareTo(two.SubItems[1].Text);
            }
            else if (column == 2)
            {
                return mult * one.SubItems[2].Text.CompareTo(two.SubItems[2].Text);
            }
            else if (column == 3)
            {
                int price1, price2;
                price1 = int.Parse(one.SubItems[3].Text);
                price2 = int.Parse(two.SubItems[3].Text);
                return mult * price1.CompareTo(price2);
            }
            else
            {
                int quantity1, quantity2;
                quantity1 = int.Parse(one.SubItems[4].Text);
                quantity2 = int.Parse(two.SubItems[4].Text);
                return mult * quantity1.CompareTo(quantity2);
            }
        }
    }
}
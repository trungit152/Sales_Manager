using System;

namespace Models
{
    public class StatModel : IComparable<StatModel>
    {
        public SelectedItem Item { get; set; }
        public int TotalItem { get; set; }
        public long TotalRevenue { get; set; }

        public StatModel()
        {

        }

        public StatModel(SelectedItem item, int totalItem, long totalRevenue)
        {
            Item = item;
            TotalItem = totalItem;
            TotalRevenue = totalRevenue;
        }

        public int CompareTo(StatModel other)
        {
            return other.TotalRevenue.CompareTo(TotalRevenue);
        }
    }
}

using System;

namespace Models
{
    public class StatRevenue : IComparable<StatRevenue>
    {
        public long Revenue { get; set; }
        public DateTime Date { get; set; }
        public int TotalItem { get; set; }
        public long TotalDiscount { get; set; }

        public StatRevenue()
        {
        }

        public StatRevenue(DateTime date, int totalItem, long revenue, long discountAmount)
        {
            Date = date;    
            TotalItem = totalItem;
            Revenue = revenue;
            TotalDiscount = discountAmount;
        }

        public int CompareTo(StatRevenue other)
        {
            return other.Revenue.CompareTo(Revenue);
        }
    }
}

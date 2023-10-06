using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Discount : IEquatable<Discount>
    {
        private static int s_autoId = 1000000;
        public int DiscountId { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string DiscountType { get; set; }
        public int DiscountPriceAmount { get; set; }
        public int DiscountPercent { get; set; }
        public Discount() { }
        public Discount(int id)
        {
            DiscountId = id > 0 ? id : s_autoId++;
        }
        public Discount(int discountId, string name, DateTime startTime,
            DateTime endTime, string discounType, int discountPriceAmount,
            int discountPercent) : this(discountId)
        {
            Name = name;
            StartTime = startTime;
            EndTime = endTime;
            DiscountType = discounType;
            DiscountPriceAmount = discountPriceAmount;
            DiscountPercent = discountPercent;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Discount);
        }

        public bool Equals(Discount other)
        {
            return !(other is null) &&
                   DiscountId == other.DiscountId;
        }

        public override int GetHashCode()
        {
            return 1574009819 + DiscountId.GetHashCode();
        }

        public static bool operator ==(Discount left, Discount right)
        {
            return EqualityComparer<Discount>.Default.Equals(left, right);
        }

        public static bool operator !=(Discount left, Discount right)
        {
            return !(left == right);
        }
        public static void UpdateAutoId(int v)
        {
            s_autoId = v;
        }
    }
}

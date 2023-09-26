using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BillDetail : Bill, IEquatable<BillDetail>
    {
        public string PaymentMethod { get; set; }
        public string StaffName { get; set; }
        public BillDetail() { }
        public BillDetail(string PaymentMethod, string StaffName)
        {
            this.PaymentMethod = PaymentMethod;
            this.StaffName = StaffName;
        }
        public BillDetail(int billId, Cart cart, DateTime createdTime, int totalItem, long subTotal, 
            long totalDiscountAmount, long totalAmount, string status, string PaymentMethod, string StaffName) :
            base(billId, cart, createdTime, totalItem, subTotal, totalDiscountAmount, totalAmount, status)
        {
            this.PaymentMethod = PaymentMethod;
            this.StaffName = StaffName;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as BillDetail);
        }

        public bool Equals(BillDetail other)
        {
            return !(other is null) &&
                   base.Equals(other) &&
                   BillId == other.BillId;
        }

        public override int GetHashCode()
        {
            int hashCode = -1170810969;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + BillId.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(BillDetail left, BillDetail right)
        {
            return EqualityComparer<BillDetail>.Default.Equals(left, right);
        }

        public static bool operator !=(BillDetail left, BillDetail right)
        {
            return !(left == right);
        }
    }
}

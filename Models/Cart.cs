using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cart : IEquatable<Cart>, IComparable<Cart>
    {
        private static int s_autoId = 10000000;
        public int CartId { get; set; }
        public Customer Customer { get; set; }
        List<SelectedItem> SelectedItems { get; set; } = new List<SelectedItem>();
        public int TotalItems { get; set; }
        public Cart() { }
        public Cart(int cartId)
        {
            CartId = cartId > 0 ? cartId : s_autoId++;
        }
        public Cart(int cartId, Customer customer, List<SelectedItem> selectedItems, int totalItems) : this(cartId)
        {
            Customer = customer;
            SelectedItems = selectedItems;
            TotalItems = totalItems;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Cart);
        }

        public bool Equals(Cart other)
        {
            return !(other is null) &&
                   CartId == other.CartId;
        }

        public override int GetHashCode()
        {
            return -1568810734 + CartId.GetHashCode();
        }

        public int CompareTo(Cart other)
        {
            return CartId - other.CartId;
        }

        public static bool operator ==(Cart left, Cart right)
        {
            return EqualityComparer<Cart>.Default.Equals(left, right);
        }

        public static bool operator !=(Cart left, Cart right)
        {
            return !(left == right);
        }
        public static void UpdateAutoId(int v)
        {
            s_autoId = v;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SelectedItem : Item
    {
        public int NumberOfSelectedItem { get; set; }
        public int PriceAfterDiscount { get; set; }
        public SelectedItem() { }
        public SelectedItem(int numberOfSelectedItem)
        {
            NumberOfSelectedItem = numberOfSelectedItem;
            CalculatePriceAfterDiscount();
        }

        private void CalculatePriceAfterDiscount()
        {
            if (Discount == null)
            {
                PriceAfterDiscount = Price;
            }
            else
            {
                var currentTime = DateTime.Now;
                if (currentTime >= Discount.StartTime && Discount.EndTime <= currentTime)
                {
                    if (Discount.DiscountPercent > 0)
                    {
                        PriceAfterDiscount = (int) (Price - Price * Discount.DiscountPercent / 100);
                    }
                    if (Discount.DiscountPriceAmount > 0)
                    {
                        PriceAfterDiscount = Price - Discount.DiscountPriceAmount;
                    }
                }
            }
        }

        public SelectedItem(int itemId, string itemName, string itemType, int quantity, string brand,
            DateTime releaseDate, int price, Discount discount, int numberOfSelectedItem) :
            base(itemId, itemName, itemType, quantity, brand, releaseDate, price, discount)
        {
            ItemId = itemId;
            ItemName = itemName;
            ItemType = itemType;
            Quantity = quantity;
            Brand = brand;
            ReleaseDate = releaseDate;
            Price = price;
            Discount = discount;
            NumberOfSelectedItem = numberOfSelectedItem;
        }
    }
}

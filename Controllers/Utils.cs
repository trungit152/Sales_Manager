using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public class Utils
    {
        public static List<Item> CreateFakeItems()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item(0, "Iphone 14", "Điện tử", 20, "Apple", DateTime.Now, 28000000, null));
            items.Add(new Item(0, "Iphone 14 Pro", "Điện tử", 10, "Apple", DateTime.Now, 32000000, null));
            items.Add(new Item(0, "Iphone 14 Pro Max", "Điện tử", 30, "Apple", DateTime.Now, 35000000, null));
            items.Add(new Item(0, "Xà lách", "Thực phẩm", 30, "VGarden", DateTime.Now, 20000, null));
            items.Add(new Item(0, "Thịt gà", "Thực phẩm", 20, "VGarden", DateTime.Now, 80000, null));
            items.Add(new Item(0, "Mì hảo hảo", "Thực phẩm", 300, "AceCook", DateTime.Now, 3500, null));
            items.Add(new Item(0, "Xi măng", "Vật liệu xây dựng", 1000, "Thành Thái", DateTime.Now, 135000, null));
            items.Add(new Item(0, "Quần short", "Thời trang", 100, "Việt Tiến", DateTime.Now, 125000, null));
            return items;
        }
    }
}

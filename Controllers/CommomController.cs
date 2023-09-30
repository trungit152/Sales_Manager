using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class CommonController : ICommonController
    {
        public void AddNewItem<T>(List<T> items, T item)
        {
            items.Add(item);
        }

        public int DeleteItem<T>(List<T> items, T item)
        {
            int index = IndexOfItem(items, item);
            items.RemoveAt(index);
            return index;
        }

        public int IndexOfItem<T>(List<T> items, T item)
        {
            return items.IndexOf(item);
        }

        public int UpdateItem<T>(List<T> values, T item)
        {
            int index = IndexOfItem(values, item);
            values.RemoveAt(index);
            values.Insert(index, item);
            return index;
        }
    }
}

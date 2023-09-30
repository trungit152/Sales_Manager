using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    internal interface ICommonController
    {
        void AddNewItem<T> (List<T> items, T item);
        int UpdateItem<T>(List<T> values, T item);
        int DeleteItem<T>(List<T> items, T item);
        int IndexOfItem<T>(List<T> items, T Item);

    }
}

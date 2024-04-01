using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollectionAddRange
{
    public static class ExtensionMethod
    {
        public static void AddRange<T>(this ObservableCollection<T> ObservableCollection, IEnumerable<T> items)
        {
            foreach (var item in items) 
            {
                ObservableCollection.Add(item);
            }
        }    
    }
}

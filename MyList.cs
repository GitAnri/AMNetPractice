using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPractice
{
    public class MyList<T>
    {
        private List<T> _list = new List<T>();

        public void Add(T item)
        {
            _list.Add(item);
        }

        public T Get(int index)
        {
            if (index<_list.Count && index >= 0)
            {
                return _list[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }  
        }

    }
}

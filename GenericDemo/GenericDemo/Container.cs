using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class Container<T>
    {
        private List<T> _theList;
        public int Capacity { get; }
        public Container(int capacity)
        {
            _theList = new List<T>();
            Capacity = capacity;
        }

        public event Action<T, DateTime, int> ThingEntered;
        public event Action<T, DateTime, int> ThingLeft;
        public bool Enter(T aThing)
        {
            if (_theList.Count < Capacity)
            {
                _theList.Add(aThing);
                ThingEntered?.Invoke(aThing, DateTime.Now, Capacity - _theList.Count);
                return true;
            }
            else
            { return false; }
        }
        public bool Leave(T aThing)
        {
            if (_theList.Remove(aThing))
            {
                ThingLeft?.Invoke(aThing, DateTime.Now, Capacity - _theList.Count);
                return true;
            }
            else { return false; }
        }
        public T this[int index] => _theList[index];
        
    }
}

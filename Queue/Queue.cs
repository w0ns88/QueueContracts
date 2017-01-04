using System.Collections.Generic;
namespace Queue
{
    public class Queue<T> : IQueue<T>
    {
        private readonly List<T> _items;

        public Queue()
        {
            this._items = new List<T>();
        }

        public Queue(List<T> items)
        {
            this._items = items;
        }

        public int Count => _items.Count;

        public void Add(T type)
        {
            _items.Add(type);
        }

        public T Remove()
        {
            T item = _items[0];
            _items.Remove(item);
            return item;
        }

        public List<T> ToList()
        {
            return _items;
        }

        public void Clear()
        {
            _items.Clear();
        }
    }
}

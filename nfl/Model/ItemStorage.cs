using System.Collections;
using System.Collections.Generic;

namespace nfl
{
    public class ItemStorage<T> : IEnumerable<T>
    {
        private List<T> storage;
        public int currentPosition;

        public int Count
        {
            get
            {
                return storage.Count;
            }
        }

        public T this[int i]
        {
            get
            {
                return storage[i];
            }
        }

        public ItemStorage()
        {
            storage = new List<T>();
            currentPosition = -1;
        }

        public void Add(T j)
        {
            storage.Add(j);
        }

        public void LoadFromFile(string fileName, char delimiter, IItemParser<T> parser)
        {
            storage.Clear();
            storage.AddRange(parser.ParseFile(fileName, delimiter));
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ItemEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

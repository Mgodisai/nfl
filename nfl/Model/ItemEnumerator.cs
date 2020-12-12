using System;
using System.Collections;
using System.Collections.Generic;

namespace nfl
{
    class ItemEnumerator<T> : IEnumerator<T>
    {
        private ItemStorage<T> storage;
        private int currentItemIndex;

        public ItemEnumerator(ItemStorage<T> storage) 
        {
            this.storage = storage;
            currentItemIndex = -1;
        }

        public T Current => storage[currentItemIndex];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            return ++currentItemIndex < storage.Count;
        }

        public void Reset()
        {
            currentItemIndex = -1;
        }
    }
}

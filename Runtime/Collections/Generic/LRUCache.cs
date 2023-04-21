using System.Collections.Generic;

namespace Quartzified.Collections.Generic
{
    public class LRUCache<Key, Value>
    {
        private int capacity;
        Dictionary<Key, LinkedListNode<LRUCacheItem<Key, Value>>> cache = new Dictionary<Key, LinkedListNode<LRUCacheItem<Key, Value>>>();
        LinkedList<LRUCacheItem<Key, Value>> lruList = new LinkedList<LRUCacheItem<Key, Value>>();

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
        }

        public Value Get(Key key)
        {
            if (!cache.ContainsKey(key))
            {
                return default(Value);
            }

            LinkedListNode<LRUCacheItem<Key, Value>> node = cache[key];

            lruList.Remove(node);
            lruList.AddLast(node);

            return node.Value.value;
        }

        public void Add(Key key, Value value)
        {
            if (cache.ContainsKey(key))
            {
                var node = cache[key];
                lruList.Remove(node.Value);
                lruList.AddLast(node.Value);

                cache[key] = node;
            }
            else
            {
                if(cache.Count >= capacity)
                {
                    var removeKey = lruList.Last!.Value;
                    cache.Remove(removeKey.key);
                    RemoveFirst();
                }

                cache.Add(key, new LinkedListNode<LRUCacheItem<Key, Value>>(new LRUCacheItem<Key, Value>(key, value)));
            }
        }

        void RemoveFirst()
        {
            LinkedListNode<LRUCacheItem<Key, Value>> node = lruList.First;
            lruList.RemoveFirst();

            cache.Remove(node.Value.key);
        }
    }
}

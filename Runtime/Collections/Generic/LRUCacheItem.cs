
namespace Quartzified.Collections.Generic
{
    public class LRUCacheItem<Key, Value>
    {
        public Key key;
        public Value value;

        public LRUCacheItem(Key k, Value v)
        {
            key = k;
            value = v;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Quartzified.Collections
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

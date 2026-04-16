using System;
using System.Collections.Generic;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cache<int, string> dict = new Cache<int, string>(5);

            dict.Add(1, "Ayush");
            dict.Add(2, "Ayush");
            dict.Add(3, "Ayush");
            dict.Add(4, "Ayush");
            dict.Add(5, "Ayush");

            dict.Add(6, "Sanjyot"); // removes key = 1

            dict.Display();
        }
    }

    public class Cache<TKey, TValue> where TKey : notnull
    {
        private readonly int _capacity;
        private readonly Dictionary<TKey, TValue> _cache;
        private readonly List<TKey> _order;

        public Cache(int capacity)
        {
            _capacity = capacity;
            _cache = new Dictionary<TKey, TValue>();
            _order = new List<TKey>();
        }

        public void Add(TKey key, TValue value)
        {
            
            if (_cache.ContainsKey(key))
            {
                _cache[key] = value;
                return;
            }

            
            if (_cache.Count >= _capacity)
            {
                TKey oldestKey = _order[0];
                _cache.Remove(oldestKey);
                _order.RemoveAt(0);
            }

            _cache[key] = value;
            _order.Add(key);
        }

        public TValue GetValue(TKey key)
        {
            if (!_cache.ContainsKey(key))
                throw new InvalidOperationException("Key not found");

            return _cache[key];
        }

        public void Remove(TKey key)
        {
            if (!_cache.ContainsKey(key))
                throw new InvalidOperationException("Key not found");

            _cache.Remove(key);
            _order.Remove(key);
        }

        public bool Exists(TKey key)
        {
            return _cache.ContainsKey(key);
        }

        public void Display()
        {
            foreach (var item in _cache)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
    }
}
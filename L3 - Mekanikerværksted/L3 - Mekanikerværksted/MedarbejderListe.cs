namespace L3___Mekanikerværksted

{
    class MedarbejderListe<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> _collection = [];

        public void AddElement(TKey k, TValue p)
        {
            if (_collection.ContainsKey(k))
            {
                return; // should actually throw a exception
            }
            _collection.Add(k, p);
        }

        public TValue? GetElement(TKey k)
        {
            _collection.TryGetValue(k, out TValue? value);
            return value;
        }

        public int Size()
        {
            return _collection.Count;
        }
    }
}

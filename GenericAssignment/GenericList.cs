namespace GenericAssignment;
internal class GenericList<T>
{
    T[] _items;
    public int Count { get; set; }
    int defaultCapacity = 4;

    public GenericList()
    {
        _items = new T[defaultCapacity];
        Count = 0;
    }

    public void Add(T item)
    {
        if (Count == _items.Length)
        {
            T[] temp = new T[_items.Length * 2];
            Array.Copy(_items, temp, _items.Length);
            _items = temp;
        }
        _items[Count] = item;
        Count++;
    }

    public T Get(int index)
    {
        return _items[index];
    }

    public void Clear()
    {
        //Array.Clear(_items);
        _items = new T[defaultCapacity];
        Count = 0;
    }
}

namespace GenericAssignment;
internal class GenericList<T>
{
    T[] _items;
    int count;
    int defaultCapacity = 4;

    public GenericList()
    {
        _items = new T[defaultCapacity];
        count = 0;
    }

    public void Add(T item)
    {
        if (count == _items.Length)
        {
            T[] temp = new T[_items.Length * 2];
            Array.Copy(_items, temp, _items.Length);
            _items = temp;
        }
        _items[count] = item;

        count++;
    }
}

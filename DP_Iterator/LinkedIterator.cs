namespace DesignPatterns.Iterator;

public class LinkedIterator<T>
{
    private Node<T> _root;
    private Node<T>? _current;

    public LinkedIterator(Node<T> root)
    {
        _root = root;
        _current = root;
    }

    public T Next()
    {
        var value = _current!.Value;
        _current = _current.Next;
        return value;
    }

    public void Reset()
    {
        _current = _root;
    }

    public bool Complete => _current == null;
}

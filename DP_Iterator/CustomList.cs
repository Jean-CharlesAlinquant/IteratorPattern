namespace DesignPatterns.Iterator;

public class CustomList<T>
{
    private Node<T>? Root { get; set; }

    public void Add(T value)
    {
        if (Root == null)
        {
            Root = new Node<T>(value);
            return;
        }

        Root.Append(value);
    }

    public T Get(int i) => Root!.Get(i);
    public LinkedIterator<T> Iterator => new LinkedIterator<T>(Root!);
}
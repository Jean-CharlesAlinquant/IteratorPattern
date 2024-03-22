namespace DesignPatterns.Iterator;

public class Node<T>
{
    public T Value { get; set; }
    public Node<T>? Next { get; set; }

    public Node(T value)
    {
        Value = value;
    }

    public void Append(T value)
    {
        if (Next is null)
        {
            Next = new Node<T>(value);
            return;
        }
        Next.Append(value);
    }

    public T Get(int i) => i == 0 ? Value : Next!.Get(--i);
}

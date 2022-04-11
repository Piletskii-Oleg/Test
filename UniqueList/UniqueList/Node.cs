namespace UniqueList;

internal class Node<T>
{
    public Node()
    {
    }

    public Node(T? value, Node<T>? next)
        : this()
    {
        Value = value;
        Next = next;
    }

    public T? Value { get; set; }

    public Node<T>? Next { get; set; }
}


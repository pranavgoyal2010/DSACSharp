using System;


namespace DSA;

class Node<T>
{
    private T data;
    private Node<T> next;

    public Node(T data, Node<T> next)
    {
        this.data = data;
        this.next = next;
    }

    public T Data
    {
        get { return data; }
        set { this.data = value; }
    }

    public Node<T> Next
    {
        get { return next; }
        set { this.next = value; }
    }
}

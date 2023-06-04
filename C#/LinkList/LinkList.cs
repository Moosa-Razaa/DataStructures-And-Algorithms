namespace LinkList;

public class Node<T>
{
    public T Value;
    public Node<T>? Next { get; set; }

    public Node(T item)
    {
        Value = item;
        Next = null;
    }

    public Node(T item, Node<T> Next)
    {
        Value = item;
        this.Next = Next;
    }
    ~Node()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Destructor Called.\nValue : {Value}");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

public abstract class LinkedListBase<T>
{
    protected Node<T>? Head; 
    protected Node<T>? Next; 
    protected Node<T>? Tail;
    protected T? Value;
    protected int Index;

    public LinkedListBase()
    {
        Head = null;
        Tail = null;
        Index = 0;
    }

    public int Count
    {
        get
        {
            return Index;
        }
        protected set
        {
            Index = value;
        }
    }

    protected bool IsHeadNull()
    {
        return Head is null;
    }

    protected bool IsTailNull()
    {
        return Tail is null;
    }

    public void Print()
    {
        if (IsHeadNull()) return;

        Node<T>? listIterator = Head;
        while(listIterator is not null)
        {
            Console.WriteLine(listIterator!.Value);
            listIterator = listIterator.Next;
        }
    }

    public abstract void AddNode(T item);

    public abstract void ClearList();
    
    public abstract bool Contains(T item);
    
    public abstract int IndexOf(T item);
    
    public abstract void DeleteLastNode();
    
    public abstract void DeleteNode(int index, bool isIndexFromLast);
    
    public abstract void DeleteMiddle();
    
    public abstract T GetMiddle();
}

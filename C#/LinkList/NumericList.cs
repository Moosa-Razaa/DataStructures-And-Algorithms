namespace LinkList;

class NumericList : LinkedListBase<int>
{
    private void InitializeFirst(int item)
    {
        Node<int> newNode = new(item);
        Head = newNode;
        Tail = newNode;
    }

    private bool CanRunnerBePushed(ref Node<int> runner, int steps)
    {
        for(int stepper = 0; stepper < steps; stepper++)
        {
            if (runner.Next is not null)
                runner = runner.Next;
            else
                return false;
        }

        return true;
    }

    private void DeleteNodeFromStart(int index)
    {
        if (IsHeadNull()) return;

        Node<int> listIterator = Head!;
        Node<int> previousIterator = Head!;

        for(int i = 0; i < index; i ++)
        {
            if (listIterator.Next is null) return;
            previousIterator = listIterator;
            listIterator = listIterator.Next;
        }
 
        previousIterator.Next = listIterator.Next;

        if (listIterator == Tail) Tail = listIterator;
    }

    private void DeleteNodeFromLast(int index)
    {
        if (IsHeadNull() || IsTailNull()) return;

        Node<int> listIterator = Head!;
        Node<int> previousIterator = Head!;
        Node<int> runnerIterator = Head!;

        while (runnerIterator!.Next is not null) 
        {
            if (!CanRunnerBePushed(ref runnerIterator, index)) return;

            listIterator = listIterator.Next!;
            previousIterator = listIterator!;
        }
        
        previousIterator.Next = listIterator.Next;
    }

    public override void AddNode(int item)
    {
        Count++;
        if(IsHeadNull()) InitializeFirst(item);
        else
        {
            Node<int> node = new(item);
            Tail!.Next = node;
            Tail = node;
        }
    }

    public override void ClearList()
    {
        Head = null;
        Tail = null;
    }

    public override bool Contains(int item)
    {
        if (IsHeadNull()) return false;

        Node<int>? listIterator = Head;

        while (listIterator is not null) 
        {
            if (listIterator.Value == item) return true;
            listIterator = listIterator.Next;
        }

        return false;
    }

    public override void DeleteMiddle()
    {
        if (IsHeadNull()) return;

        Node<int>? beforeListIterator = Head;
        Node<int>? listIterator = Head;
        Node<int>? runnerIterator = Head;
        
        while (runnerIterator!.Next is not null) 
        {
            if(CanRunnerBePushed(ref runnerIterator, 2))
            {
                beforeListIterator = listIterator;
                listIterator = listIterator!.Next;
            }
        }

        beforeListIterator!.Next = listIterator!.Next;
    }
     
    public override void DeleteLastNode()
    {
        if (IsHeadNull()) return;

        Node<int>? listIterator = Head;

        while(listIterator!.Next != Tail)
        {
            listIterator = listIterator.Next;
        }

        listIterator!.Next = null;
        Tail = listIterator;
    }

    public override void DeleteNode(int index, bool isIndexFromLast = false)
    {
        if(isIndexFromLast) DeleteNodeFromLast(index);
        else DeleteNodeFromStart(index);
    }

    public override int GetMiddle()
    {
        if (IsHeadNull()) return int.MinValue;

        Node<int>? listIterator = Head;
        Node<int>? runnerIterator = Head;

        while (runnerIterator!.Next is not null)
        {
            if (CanRunnerBePushed(ref runnerIterator, 2))
            {
                listIterator = listIterator!.Next;
            }
        }

        return listIterator!.Value; 
    }

    public override int IndexOf(int item)
    {
        int index = 0;
        if (IsHeadNull()) return int.MinValue;

        Node<int>? listIterator = Head;

        do
        {
            if (listIterator!.Value == item) return index;
            index++;
        }
        while (listIterator!.Next is not null);

        return int.MinValue;
    }
}

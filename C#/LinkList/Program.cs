namespace LinkList;

class Program
{
    static void Main()
    {
        LinkedListBase<int> linkedList = new NumericList();
        
        for(int i = 10; i <= 100; i += 10)
        {
            linkedList.AddNode(i);
        }

        int middle = linkedList.GetMiddle();

        Console.WriteLine(middle);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
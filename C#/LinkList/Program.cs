namespace LinkList;

class Program
{
    static void Main()
    {
        //Now here we can create the instance of the class and use it as required.
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
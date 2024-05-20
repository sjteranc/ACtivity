namespace ACtivity;

class Program
{
    static void Main(string[] args)
    {
       ListOperations listOps = new ListOperations();
        listOps.AddNumbers();

        listOps.PrintNumbers();

        listOps.RemoveFirstAndLast();

        Console.WriteLine("\nAfter removing first and last element");
        listOps.PrintNumbers();

    }
}

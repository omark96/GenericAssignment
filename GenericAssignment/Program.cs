namespace GenericAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            GenericList<int> myList = new();
            for (int i = 0; i < 20; i++)
            {
                myList.Add(i);
                Console.WriteLine(myList.Get(i));
            }
            GenericList<string> myList2 = new();
            for (int i = 0; i < 5; i++)
            {
                myList2.Add(Console.ReadLine());
            }
        }
    }
}
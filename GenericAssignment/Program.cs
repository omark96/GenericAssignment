namespace GenericAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<int> lista = new();
            GenericList<int> myList = new();
            for (int i = 0; i < 20; i++)
            {
                myList.Add(i);
                Console.WriteLine(i);
            }
        }
    }
}
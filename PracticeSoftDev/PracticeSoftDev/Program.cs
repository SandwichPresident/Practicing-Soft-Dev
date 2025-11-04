namespace PracticeSoftDev
{
    internal class Program
    {
        Stack<string> searchHistory = new Stack<string>();

        static void Main(string[] args)
        {

            
        }

        public void search()
        {
            string query;
            Console.WriteLine("What do you want to search: ");
            query = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You searched: " + query + "...");
            Console.WriteLine();
            Console.WriteLine("No results found with search: " + query);
            Console.WriteLine();
            Console.WriteLine(query + " is added to search history.");

            searchHistory.Push(query);
            return;
        }

        public void view()
        {

        }

        public void delete()
        {

        }
    }
}

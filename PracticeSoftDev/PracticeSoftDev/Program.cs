namespace PracticeSoftDev
{
    internal class Program
    {
        Stack<string> searchHistory = new Stack<string>();

        static void Main(string[] args)
        {
            
        }

        public void logic()
        {
            string stringVal;
            Console.WriteLine("What would you like to do: Search, View, or Delete?");
            Console.Write("Input either s, v, or d");
            stringVal = Console.ReadLine();
            if (stringVal == "s")
            {
                search();
                return;
            }
            else if (stringVal == "v")
            {
                view();
                return;
            }
            else if (stringVal == "d")
            {
                delete();
                return;
            }
            else
            {
                Console.WriteLine("Not an appropriate value");
                return;
            }
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
        }

        public void view()
        {

        }

        public void delete()
        {

        }
    }
}

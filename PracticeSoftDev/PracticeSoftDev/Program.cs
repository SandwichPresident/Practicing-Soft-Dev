namespace PracticeSoftDev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> searchHistory = new Stack<string>();
            bool iterate = false;

            Console.WriteLine("Welcome to the Browser (with advanced search history)!");
            while (iterate == false)
            {
                string nyVal;
                logic(searchHistory);
                Console.WriteLine("Do you want to do more?");
                Console.Write("Input either y or n");
                nyVal = Console.ReadLine();
                if (nyVal == "y")
                {
                    logic(searchHistory);
                }
                else if (nyVal == "n")
                {
                    return;
                }
            }
        }

        static public void logic(Stack<string> searchHist)
        {
            string stringVal;
            Console.WriteLine("What would you like to do: Search, View, or Delete?");
            Console.Write("Input either s, v, or d");
            stringVal = Console.ReadLine();
            if (stringVal == "s")
            {
                search(searchHist);
                return;
            }
            else if (stringVal == "v")
            {
                //view(searchHist);
                return;
            }
            else if (stringVal == "d")
            {
                //delete(searchHist);
                return;
            }
            else
            {
                Console.WriteLine("Not an appropriate value");
                return;
            }
        }

        static public void search(Stack<string> hist)
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

            hist.Push(query);
            return;
        }

        public void view(Stack<string> hist)
        {

        }

        public void delete(Stack<string> hist)
        {

        }
    }
}

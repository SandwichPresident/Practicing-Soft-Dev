namespace PracticeSoftDev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> searchHistory = new Stack<string>();
            bool iterate = false;
            int ret = 0;

            Console.WriteLine("Welcome to the Browser (with advanced search history)!");
            Console.WriteLine();
            while (iterate == false)
            {
                string nyVal;
                if (ret == 0)
                {
                    logic(searchHistory);
                }
                Console.WriteLine("Do you want to do more?");
                Console.Write("Input either y or n: ");
                nyVal = Console.ReadLine();
                Console.WriteLine();
                if (nyVal == "y")
                {
                    logic(searchHistory);
                    ret++;
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
            Console.Write("Input either s, v, or d: ");
            stringVal = Console.ReadLine();
            if (stringVal == "s")
            {
                search(searchHist);
                return;
            }
            else if (stringVal == "v")
            {
                view(searchHist);
                return;
            }
            else if (stringVal == "d")
            {
                delete(searchHist);
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
            Console.Write("What do you want to search: ");
            query = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You searched: " + query + "...");
            Console.WriteLine();
            Console.WriteLine("No results found with search: " + query);
            Console.WriteLine();
            Console.WriteLine(query + " is added to your search history.");
            Console.WriteLine();

            hist.Push(query);
            return;
        }

        static public void view(Stack<string> hist)
        {
            int range;
            Console.Write($"How many entries of your search history do you wish to see? LIMIT: {hist.Count} - ");
            //casts read line into an int
            range = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (range < 0 || range > hist.Count())
            {
                Console.WriteLine("Out of bounds, please try again: ");
                view(hist);
                return;
            }
            //tries to peek first to limit complexity/demand
            else if (range == 1)
            {
                Console.WriteLine(hist.Peek());
                Console.WriteLine();
                return;
            }
            else
            {
                //creates a copy of hist to be used in a desctructive reading
                Stack<String> histCopy = new Stack<String>(hist.Reverse());
                for (int i = 0; i < range; i++) { 
                    Console.WriteLine(histCopy.Pop());
                    Console.WriteLine();
                }
                return;
            }

        }

        static public void delete(Stack<string> hist)
        {
            if (hist.Count > 0)
            {
                hist.Pop();
                Console.WriteLine();
                Console.WriteLine("Most recent search deleted.");
                Console.WriteLine();
                return;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No searches to delete.");
                Console.WriteLine();
                return;
            }
        }
    }
}
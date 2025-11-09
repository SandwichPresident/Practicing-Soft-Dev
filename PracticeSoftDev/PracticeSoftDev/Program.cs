/*
 * Practicing Software Development Homework
 * Due: 11/9/2025
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeSoftDev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize an empty stack to store search history entries
            Stack<string> searchHistory = new Stack<string>();
            
            //Boolean to control the loop and int to track iterations
            bool iterate = false;
            int ret = 0;

            Console.WriteLine("Welcome to the Browser (with advanced search history)!");
            Console.WriteLine();

            //Main loop for user interaction
            while (!iterate)
            {
                string nyVal;

                //First interaction, call logic once
                if (ret == 0)
                {
                    logic(searchHistory);
                }

                //Ask if the user wants to perform another action
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
                    return; //Ends program
                }
            }
        }

        //Handles main menu selection: search, view, or delete
        static public void logic(Stack<string> searchHist)
        {
            Console.WriteLine("What would you like to do: Search, View, or Delete?");
            Console.Write("Input either s, v, or d: ");
            string userInput = Console.ReadLine();

            if (userInput == "s")
            {
                search(searchHist);
            }
            else if (userInput == "v")
            {
                view(searchHist);
            }
            else if (userInput == "d")
            {
                delete(searchHist);
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }

        //Simulates a user search and pushes the query onto the stack
        static public void search(Stack<string> hist)
        {
            Console.Write("What do you want to search: ");
            string query = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("You searched: " + query + "...");
            Console.WriteLine("No results found with search: " + query);
            Console.WriteLine(query + " has been added to your search history.");
            Console.WriteLine();

            hist.Push(query); //Adds search to history (top of the stack)
        }

        //Views recent search history using Peek (non-destructive) or Pop (destructive)
        static public void view(Stack<string> hist)
        {
            Console.Write($"How many entries of your search history do you wish to see? LIMIT: {hist.Count} - ");
            int range;

            //Parse user input into integer safely
            bool valid = int.TryParse(Console.ReadLine(), out range);
            Console.WriteLine();

            if (!valid || range < 0 || range > hist.Count)
            {
                Console.WriteLine("Invalid number. Please try again.");
                view(hist);
                return;
            }

            //Single item view uses Peek to avoid unnecessary copying
            if (range == 1)
            {
                Console.WriteLine(hist.Peek());
                Console.WriteLine();
            }
            else
            {
                //Create reversed copy of stack to view entries from oldest to newest
                Stack<string> histCopy = new Stack<string>(hist.Reverse());

                for (int i = 0; i < range; i++)
                {
                    Console.WriteLine(histCopy.Pop());
                    Console.WriteLine();
                }
            }
        }

        //Deletes most recent search from history using Pop
        static public void delete(Stack<string> hist)
        {
            if (hist.Count > 0)
            {
                hist.Pop();
                Console.WriteLine();
                Console.WriteLine("Most recent search deleted.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No searches to delete.");
                Console.WriteLine();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace c_advanced03
{
    
    public  class Helper
    {
        public override string ToString()
        {
            return base.ToString();
        }

        // ===================== Exercise 2: Leaderboard =====================
        public static void PrintGrades(List<int> grades)
        {
            Console.WriteLine($"{string.Join(", ", grades)}");
        }

        public static void PrintSortedGrades(List<int> grades)
        {
            Console.WriteLine($"{string.Join(", ", grades)}");
        }

        public static void PrintFailedGrades(List<int> grades)
        {
            Console.WriteLine($"{string.Join(", ", grades)}");
        }
       

        // ===================== Exercise 2: Leaderboard =====================

        // Prints a SortedDictionary<int, string> leaderboard as "Name: Score"
        public static void PrintLeaderboard(SortedDictionary<int, string> leaderboard)
        {
            foreach (KeyValuePair<int, string> entry in leaderboard)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }

       

        // ===================== Exercise 3: Phone Book =====================

        // Prints a Dictionary<string, string> phone book as "Name: Number"
        public static void PrintPhoneBook(Dictionary<string, string> phoneBook)
        {
            foreach (KeyValuePair<string, string> contact in phoneBook)
            {
                Console.WriteLine($"{contact.Key}: {contact.Value}");
            }
        }

        // Prints all keys on one line, separated by commas
        public static void PrintKeysOnOneLine(Dictionary<string, string> phoneBook)
        {
            List<string> keys = new List<string>(phoneBook.Keys);
            Console.WriteLine("Names: "+ string.Join(", ", keys));
        }

        // Prints all values on one line, separated by commas
        public static void PrintValuesOnOneLine(Dictionary<string, string> phoneBook)
        {
            List<string> values = new List<string>(phoneBook.Values);
            Console.WriteLine("Numbers: "+string.Join(", ", values));
        }

        // Tries to add a contact using .Add(), catches and reports the exception if it already exists
        public static void TryAddWithAdd(Dictionary<string, string> phoneBook, string name, string number)
        {
            try
            {
                phoneBook.Add(name, number);
                Console.WriteLine($".Add() succeeded for '{name}'.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($".Add() failed for '{name}': {ex.Message}");
            }
        }

        // Tries to add a contact using .TryAdd(), reports whether it succeeded
        public static void TryAddWithTryAdd(Dictionary<string, string> phoneBook, string name, string number)
        {
            bool wasAdded = phoneBook.TryAdd(name, number);
            Console.WriteLine($".TryAdd() for '{name}' succeeded? {wasAdded}");
        }
        
    }

    
}

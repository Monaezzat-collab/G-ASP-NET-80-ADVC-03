using Microsoft.VisualBasic;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Xml;
using System.Xml.Linq;
using static c_advanced03.Helper;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace c_advanced03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            ////Print the collection, Count, first and last grade
            //Helper.PrintGrades(grades);
            //Console.WriteLine($"Count: {grades.Count}");
            //Console.WriteLine($"First Grade: {grades.First()} , Last Grade: {grades.Last()}");


            ////Sort the grades ascending, then print
            //grades.Sort();
            //Helper.PrintSortedGrades(grades);

            ////Get the first grade above 90
            //int gradeAbove90 = grades.Find(g => g > 90);
            //Console.WriteLine(gradeAbove90);

            ////Get all grades below 75(failing grades)
            //List<int> allFailingGrades = grades.FindAll(g => g < 75);
            //PrintFailedGrades(allFailingGrades);

            ////Remove all failing grades(below 75)
            //grades.RemoveAll(g => g<75);
            //Helper.PrintSortedGrades(grades);

            ////Check if any grade equals 100
            //bool isEquals100 = grades.Any(g => g == 100);
            //Console.WriteLine(isEquals100);

            ////Create a List<string> where each grade becomes "Grade: X"
            //List<string> gradeLabels = new List<string>();
            //foreach (int g in grades) {
            //gradeLabels.Add("Grades:"+ g.ToString());
            //}
            //Console.WriteLine("Grade Labels: ");
            //foreach (string label in gradeLabels) {
            //    Console.WriteLine(label);
            //}


            #endregion

            #region Exercise 2: Leaderboard
            // //Create a leaderboard that automatically sorts players by score.
            // SortedDictionary<int, string> leaderboard =
            //new SortedDictionary<int, string>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

            // //Add: 500 = "Ahmed", 200 = "Sara", 800 = "Ali", 350 = "Mona"
            // leaderboard.Add(500, "Ahmed");
            // leaderboard.Add(200, "Sara");
            // leaderboard.Add(800, "Ali");
            // leaderboard.Add(350, "Mona");

            // //Print all entries(they should be sorted by score automatically)
            // PrintLeaderboard(leaderboard);

            // //Access the first key and first value
            // KeyValuePair<int, string> first = leaderboard.First();
            // Console.WriteLine($"First Key: {first.Key} First Value: {first.Value}");

            // //Check if score 500 exists
            // bool isContians500=leaderboard.ContainsKey(500);
            // Console.WriteLine(isContians500); //True

            // //Safely get the player with score 999 >> tryGet
            // if (leaderboard.TryGetValue(999, out string? player999))
            // {
            //     Console.WriteLine($"Player with score 999: {player999}");
            // }
            // else
            // {
            //     Console.WriteLine("No player found with score 999.");
            // }

            // //Remove the player with score 200 and print the updated list
            // leaderboard.Remove(200);
            // Console.WriteLine("Leader Board After Remove Key 200");
            // Helper.PrintLeaderboard(leaderboard);

            #endregion

            #region Exercise 3: Phone Book
            ////Build a phone book application.
            ////Create a Collection with 4 contacts(name → phone number)
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>
            //{
            //{ "Ahmed", "111-222-3333" },
            //{ "Sara", "444-555-6666" },
            //{ "Mona", "777-888-9999" },
            //{ "Omar", "123-456-7890" } };
            //Helper.PrintPhoneBook(phoneBook);

            ////Add a new contact using [] syntax (add or update)
            //phoneBook["Aya"]="555-666-7777"; //Added

            ////Try adding a duplicate using .Add() — catch the exception and print the error
            ////Helper.TryAddWithAdd(PhoneBook, "Ahmed", "111-222-3333"); 
            //try
            //{
            //    phoneBook.Add("Ahmed","111-222-3333");

            //}
            //catch (Exception ex) {
            //    Console.WriteLine("This Contact Already Found");
            //}

            ////Try adding a duplicate using .TryAdd() — print whether it succeeded
            ////Helper.TryAddWithTryAdd(PhoneBook, "Mohamed", "222,333,4444");
            //bool wasAdded = phoneBook.TryAdd("Mohamed", "222-333-4444");
            //Console.WriteLine($"Try to add new contect succeeded? {wasAdded}");

            ////Search for a contact that doesn’t exist

            //Console.WriteLine("Is This Contact Exists?" + phoneBook.ContainsKey("Ali")); //False

            ////Get a contact with a fallback of "Not Found"
            //string sarasNumber = phoneBook.GetValueOrDefault("Sara", "Not Found");
            //Console.WriteLine($"Sara's number (with fallback): {sarasNumber}");

            //// Print all Keys on one line, then all Values on another line
            //Helper.PrintKeysOnOneLine( phoneBook);
            //Helper.PrintValuesOnOneLine(phoneBook);

            #endregion

            #region Exercise 4: Unique Email Validator
            ////Use Collection to manage unique email addresses.
            ////Create a HashSet<string> with a case -insensitive comparer: new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //HashSet<string> set = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            ////Add these emails: "ahmed@test.com", "AHMED@test.com", "sara@test.com", "Sara@Test.Com"
            //set.Add("ahmed@test.com");
            //set.Add("AHMED@test.com");
            //set.Add("sara@test.com");
            //set.Add("Sara@test.com");

            ////Print Count — how many are actually stored? Explain why.
            //Console.WriteLine(set.Count()); //2 duplicates Not Allowed at HashSet

            ////Create two sets: Set A = { 1, 2, 3, 4, 5 } and Set B = { 4,5,6,7,8}
            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            ////Print the result of: UnionWith, IntersectWith, ExceptWith
            //setA.UnionWith(setB); //
            //Console.WriteLine("Union With: "+string.Join(",", setA)); //all without duplicate

            //setA.IntersectWith(setB);
            //Console.WriteLine("Intersect With: " + string.Join(",", setA)); //repeated elements

            //setA.ExceptWith(setB);
            //Console.WriteLine("Except With: " + string.Join(",", setA));

            //HashSet<int> unionSet = new HashSet<int>(setA.Union(setB));
            //Console.WriteLine(string.Join(",", unionSet)); //1,2,3,4,5,6,7,8 بيجمع بدون تكرار

            //HashSet<int> intersect = new HashSet<int>(setA.Intersect(setB));
            //Console.WriteLine(string.Join(",", intersect)); //4,5 المشترك

            //HashSet<int> exceptSet = new HashSet<int>(setA.Except(setB)); //1,2,3 الفرق بين الاتنين
            //Console.WriteLine(string.Join(",", exceptSet));

            ////Use IsSubsetOf to check if { 1,2} is a subset of Set A
            //HashSet<int>newSet=new HashSet<int> { 1,2};
            //bool isSubsetOf = newSet.IsSubsetOf(setA);
            //Console.WriteLine(isSubsetOf); //True

            #endregion

            #region  Exercise 5: Print Queue Simulator
            ////Queue >>> FIFO first in first out
            ////Create a Queue<string> and enqueue 5 documents: "Report.pdf", "Invoice.pdf", "Letter.docx", "Resume.pdf", "Photo.jpg"
            //Queue<string> documents = new Queue<string>();
            //documents.Enqueue("Report.pdf");
            //documents.Enqueue("Invoice.pdf");
            //documents.Enqueue("Letter.pdf");
            //documents.Enqueue("Resume.pdf");
            //documents.Enqueue("Photo.pdf");

            ////Print the queue contents and Count
            //foreach (string document in documents)
            //{
            //    Console.WriteLine(document);
            //}
            //Console.WriteLine(documents.Count);

            ////Use Peek to see which document will print next(without removing)
            //Console.WriteLine("Document Will Print Next "+documents.Peek()); //first in
            ////Process the queue: Dequeue each document and print "Printing: [name]"
            //while (documents.Count > 0)
            //{
            //    Console.WriteLine("Printing: " + documents.Dequeue());
            //}
        
            ////Try TryDequeue on the now - empty queue — what happens?
            ////documents.Dequeue(); //Exception cause it's already empty
            #endregion

        }
    }
}

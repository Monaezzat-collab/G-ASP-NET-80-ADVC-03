using System.Drawing;
using System.Globalization;
using System.Numerics;
using static c_advanced03.Helper;
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
        }
    }
}

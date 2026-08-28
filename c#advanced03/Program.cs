using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static c_advanced03.Helper;
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
        }
    }
}

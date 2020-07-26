using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Sprint07
{
    internal class Program
    {
        public static double EvaluateSumOfElementsOddPositions(double[] inputData) =>
            inputData.Where((item, index) => index % 2 != 0).Sum();

        public static double EvaluateAggregate(double[] inputData, Func<double, double, double> aggregate, Func<double, int, bool> predicate) =>
            inputData.Where(predicate).Aggregate(aggregate);

        public static int ProductWithCondition(List<int> inputData, Func<int, bool> predicate) =>
            inputData.Where(predicate).Aggregate(1, (total, next) => total * next);

        public static string GetWord(string input, string seed)
        {
            var result = from item in input.Split()
                         orderby item.Length descending
                         select item;
            string strResult = result.ElementAt(0).Length > seed.Length ? result.ElementAt(0) : seed;
            return strResult.Contains('a') ? strResult.Substring(strResult.IndexOf('a')) : "";
        }

        public static string CreateGroups(List<Student> students, List<Group> groups)
        {
            var groupingResult = from student in students
                                 group student by student.GroupName into team
                                 select new
                                 {
                                     @group = team.Key,
                                     rating = team.Sum((student) => student.Rating) / team.Count(),
                                     students = from student in team
                                                select new
                                                {
                                                    FullName = student.Name,
                                                    AvgMark = student.Rating
                                                }
                                 };

            return JsonSerializer.Serialize(groupingResult, new JsonSerializerOptions() { WriteIndented = true });
        }

        private static void Main(string[] args)
        {
        }
    }
}
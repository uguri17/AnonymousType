using System;

namespace AnonymousType
{
    class MainApp
    {
        static void Main(string[] args)
        {   // 무명형식일때 선언방법
            var a = new { Name = "kdw", Age = 25 };

            Console.WriteLine($"Name: {a.Name}");
            Console.WriteLine($"Age: {a.Age}");

            Console.WriteLine();

            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };
            Console.WriteLine($"Subject: {b.Subject}");
            foreach (var score in b.Scores)
            {
                Console.WriteLine($"Score: {score}");
            }                                   
        }
    }
}

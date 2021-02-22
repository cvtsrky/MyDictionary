using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();

            students.Add(163, "Cevat");
            students.Add(120, "Yusuf");
            students.Add(150, "Merve");
            students.Add(556, "Huriye");


            students.ToList();
        }
    }
}

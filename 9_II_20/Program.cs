using System;
using System.IO;
namespace _9_II_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите заданную букву.");
            char a = char.Parse(Console.ReadLine());
            StreamWriter sw = new StreamWriter("C://Users//vasbe/Desktop/testOut.txt", true);
            foreach (String s in File.ReadAllLines(@"C://Users//vasbe/Desktop/test.txt")) 
            {
                if (s != null && s.Length > 0)
                {
                    for (int i = 0;  i < s.Length - 1; i++) 
                    {
                        if (s[i] == a) {
                            sw.Write(s[i+1]);
                        }
                    }
                }
            
            }
            sw.Close();
        }
    }
}

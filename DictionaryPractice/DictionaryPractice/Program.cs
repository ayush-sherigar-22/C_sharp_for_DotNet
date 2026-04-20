using System;
using System.Diagnostics.SymbolStore;
using System.Net.Sockets;
using System.Runtime.InteropServices.Marshalling;
using System.Xml.Linq;

namespace DictionaryPractice
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            // 1. Count the number of character in given string and output the 1st single appearing string
            //CharCount();


            // 2. Isomorphic String
            var str1 = "paper";
            var str2 = "title";
            IsomorphicStrings(str1, str2);

            // 3. Group students with same grade   
            List<Student> students = new List<Student>
                    {
                        new Student { Name = "Ayush", Age = 20, Grade = "A" },
                        new Student { Name = "Riya", Age = 21, Grade = "B" },
                        new Student { Name = "Karan", Age = 19, Grade = "A" },
                        new Student { Name = "Sneha", Age = 22, Grade = "C" },
                        new Student { Name = "Rahul", Age = 20, Grade = "B" }
                    };

            Dictionary<string, List<string>> gradeGroup = new Dictionary<string, List<string>>();

            foreach (var s in students)
            {
                if (gradeGroup.ContainsKey(s.Grade))
                {
                    gradeGroup[s.Grade].Add(s.Name);
                }
                else
                {
                    gradeGroup.Add(s.Grade, new List<string> { s.Name });
                }

            }

            foreach (var kv in gradeGroup)
            {
                Console.WriteLine($"{kv.Key}:");

                foreach (var name in kv.Value)
                {
                    Console.WriteLine($"  {name}");
                }
            }



        }

        public static void CharCount()
        { 
            var input = "aabbcdeff";

            Dictionary<char, int> result = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (result.ContainsKey(input[i]))
                {
                    result[input[i]]++;
                }
                else
                {
                    result.Add(input[i], 1);
                }
               
            }
            foreach (char c in input)
            {
                if (result[c] == 1)
                {
                    Console.WriteLine($"First character with single appearance is : {c} " );
                    break;
                }
            }
        }

        public static void IsomorphicStrings(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Strings are now Isomorphic.");
                return;
            }

            Dictionary<char, char> map1 = new Dictionary<char, char>();
            Dictionary<char, char> map2 = new Dictionary<char, char>();

            for (int i = 0; i < str1.Length; i++)
            {
                char c1 = str1[i];
                char c2 = str2[i];

               
                if (map1.ContainsKey(c1))
                {
                    if (map1[c1] != c2)
                    {
                        Console.WriteLine("Strings are NOT Isomorphic.");
                        return;
                    }
                }
                else
                {
                    map1[c1] = c2;
                }

        
                if (map2.ContainsKey(c2))
                {
                    if (map2[c2] != c1)
                    {
                        Console.WriteLine("Strings are NOT Isomorphic.");
                        return;
                    }
                }
                else
                {
                    map2[c2] = c1;
                }
            }

            Console.WriteLine("Strings are Isomorphic.");
        }



    }
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

    }


    
}
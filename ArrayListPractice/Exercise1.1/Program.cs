using System;

namespace ArrayListPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {


            var likes = new List<string>();

            while (true)
            {

                Console.WriteLine("Enter name : ");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    if (likes.Count == 0)
                    {
                        Console.WriteLine("0 Likes in Post");
                        break;
                    }
                    else if (likes.Count == 1)
                    {
                        Console.WriteLine("{0} have liked the post", likes[0]);
                        break;
                    }
                    else if (likes.Count == 2)
                    {
                        Console.WriteLine("{0} and {1} have liked the post.", likes[0], likes[1]);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("{0}, {1} and {2} other have liked the post", likes[0], likes[1], likes.Count - 2);
                        break;
                    }
                }
                likes.Add(input);
                continue;

            }

        }
    }
}



  
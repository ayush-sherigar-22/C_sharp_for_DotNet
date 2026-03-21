using System;
using System.ComponentModel.DataAnnotations;

namespace StackPost
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Title: ");
            var title = Console.ReadLine();

            Console.Write("Enter Content: ");
            var content = Console.ReadLine();

            var post = new Post(title, content);

            while (true)
            {
                Console.WriteLine("UpVopte(u) or DownVote(d) by or Quit(q) ");
                var vote = Console.ReadLine();

                if (vote == "q")
                {
                    break;
                }

                post.Vote(vote);
                continue;
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace StackOverflowPost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("FrontEnd or Back End?", "The guide to help you decide between front or back end");
            WriteLine($"Title: {post.Title} \nDescription: {post.Description} \nDate: {post.Datetime}");

            while (true)
            {
                WriteLine("Type 1 to vote up, 2 to vote down and 3 to exit");
                var input = Convert.ToInt32(ReadLine());

                if (input != 0)
                {

                    switch (input)
                    {
                        case 1: post.VoteUp(); continue;
                        case 2: post.VoteDown(); continue;
                        case 3: break;
                    }
                }

                else
                {
                    break;
                }

                WriteLine($"Total of votes: {post.VoteCount} \nVotes down: {post.DownVoteCount} \nVotes up: {post.UpVoteCount}");
            }

        }
    }
}

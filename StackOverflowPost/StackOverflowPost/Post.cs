using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    internal class Post
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime Datetime { get; private set; }
        public int VoteCount { get; private set; }
        public int UpVoteCount { get; private set; }
        public int DownVoteCount { get; private set; }

        public Post(string title, string description)
        { 
            Title = title; 
            Description = description;
            Datetime = DateTime.Now;

        }

        public void VoteUp()
        {
            VoteCount++;
            UpVoteCount++;
        }

        public void VoteDown()
        {
            VoteCount++;
            DownVoteCount++;
        }


    }
}

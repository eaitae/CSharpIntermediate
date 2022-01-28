using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class VideoStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changing the video status to \"Processing\"");
        }
    }
}

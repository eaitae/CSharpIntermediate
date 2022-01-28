using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class VideoReady : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling the web service and sending message \"Video ready\"");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class EmailNotification : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email to the video owner");
        }
    }
}

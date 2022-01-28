using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Workflow workflow = new Workflow();
            workflow.Add(new UploadVideo());
            workflow.Add(new VideoReady());
            workflow.Add(new EmailNotification());  
            workflow.Add(new VideoStatus());

            var engine = new WorkFlowEngine();
            engine.Run(workflow);

        }
    }
}

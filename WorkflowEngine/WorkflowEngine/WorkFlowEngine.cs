using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class WorkFlowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (IActivity I in workflow.GetActivities())
            {
                I.Execute();
            }
        }
    }
}

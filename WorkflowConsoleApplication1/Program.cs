using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace WorkflowConsoleApplication1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Activity workflow1 = ;
            WorkflowInvoker.Invoke(new HelloWorkflow());
            Console.Read();
        }
    }

    public class HelloWorkflow : Activity
    {
        public HelloWorkflow()
        {
            this.Implementation = () => new Sequence
            {
                Activities =
                {
                    new WriteLine(){Text = "hello workflow"}
                }
            };
        }
    }
}

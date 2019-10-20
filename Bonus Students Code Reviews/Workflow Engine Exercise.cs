using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Bonus_Students
{
    public class Workflow_Engine_Exercise
    {
        static void Main(string[] args)
        {
            var Workflow workFlow = new Workflow();
            workFlow.Add(new VideoUploader());
            workFlow.Add(new CallWebService());
            workFlow.Add(new SendEmail());
            workFlow.Add(new ChangeStatus());

            var engine = new WorkFlowEngine();
            engine.Run(workFlow);

            Console.ReadLine();
        }
    }

    public interface IWorkFlow
    {
        void Execute();
    }

    public interface IWorkflow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GatTasks();
    }

    public class Workflow : IWorkflow
    {
        private readonly<ITask> _tasks;

        public Workflow()
        {
            _tasks = new List<ITask>();
        }      

        public void Add(ITask task)
        {
            _tasks.Add(task);
        }

        public void Remove(ITask task)
        {
            _tasks.Remove(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }

    class VideoUploader : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video");
        }
    }

    class CallWebService : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service...");
        }
    }

    class SendEmail : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email...");
        }
    }

    class ChangeStatus : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Status changed...");
        }
    }

    public class WorkFlowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (ITask I in workflow.GetTasks())
            {
                try
                {
                    I.Execute();
                }
                catch (Exception)
                {
                    // Logging
                    // Terminate and persist the state of workflow
                    throw;
                }

            }
            foreach (IWorkFlow I in workflow.GetTasks())
            {
                I.Execute();
            }
        }
    }
}

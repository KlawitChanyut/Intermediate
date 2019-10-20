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
            WorkFlowEngine workFlow = new WorkFlowEngine();
            workFlow.AddWorkFlowObject(new VideoUploader());
            workFlow.AddWorkFlowObject(new CallWebService());
            workFlow.AddWorkFlowObject(new SendEmail());
            workFlow.AddWorkFlowObject(new ChangeStatus());

            workFlow.Run();

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
    }

    public class Workflow : IWorkflow
    {
        private List<ITask> _tasks;

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

    class WorkFlowEngine
    {
        

        public void Run()
        {
            foreach (IWorkFlow I in T)
            {
                I.Execute();
            }
        }
    }
}

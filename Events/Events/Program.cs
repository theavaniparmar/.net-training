using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void Notify();

    //publisher class
    public class EventPublisher
    {
        public event Notify ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("process started");
            ProcessCompleted?.Invoke();
        }
    }
    // listener class
    public class EventListener
    {
        public void Onprocesscompleted()
        {
            Console.WriteLine("process completed successfully");
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EventPublisher ep = new EventPublisher();
            EventListener el = new EventListener();

            ep.ProcessCompleted += el.Onprocesscompleted;

            ep.StartProcess();
            Console.ReadKey();
            
        }
        
    }
}

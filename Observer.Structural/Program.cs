using System;
using System.Collections.Generic;

namespace Observer.Structural
{
    /// <summary>
    /// Observer Design Pattern
    /// </summary>

    public class Program
    {
        public class Subject
        {
            public event EventHandler<EventArgsSubject> SubjectEvent;

            public string SubjectState;

            public void NotifyObservers()
            {
                EventArgsSubject args = new EventArgsSubject();
                args.SubjectState = this.SubjectState;

                // (1) 
                if (SubjectEvent != null)
                {
                    SubjectEvent(this, args);
                }
            }
        }

        public class Observer
        {
            private string name;
            private string observerState;

            public Observer(string name)
            {
                this.name = name;
            }

            public void Update(object subject, EventArgsSubject args)
            {
                observerState = args.SubjectState;
                Console.WriteLine("Observer {0}'s new state is {1}",
                    name, observerState);
            }
        }

        public class EventArgsSubject : EventArgs
        {
            public string SubjectState = null;
        }

        class Client
        {
            public static void Main(string[] args)
            {
                Subject s = new Subject();

                Observer obs1 = new Observer("1");
                Observer obs2 = new Observer("2");
                Observer obs3 = new Observer("3");

                s.SubjectEvent += obs1.Update;
                s.SubjectEvent += obs2.Update;
                s.SubjectEvent += obs3.Update;


                // Change subject state and notify observers
                s.SubjectState = "ABC123";
                s.NotifyObservers();
                s.SubjectEvent -= obs1.Update;
                s.SubjectState = "DEF456";
                s.NotifyObservers();
                Console.ReadLine();
            }
        }
    }
}


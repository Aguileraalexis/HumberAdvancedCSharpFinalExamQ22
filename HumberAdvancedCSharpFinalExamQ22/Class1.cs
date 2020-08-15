using System;

namespace HumberAdvancedCSharpFinalExamQ22
{
    //This class defines an event
    public class ClassWithEvent
    {
         public event MyDelegate MyEvent;

        //When this is called the event is launched
        protected void OnDoSomething()
        {
            MyEventArgs args = new MyEventArgs();
            args.SomeInfo = "som info";

            MyEvent(this, args);
        }

    }

    //event args with some data
    public class MyEventArgs
    {
        public String SomeInfo { get; set; }
    }

    //the delegate
    public delegate void MyDelegate(Object sender, MyEventArgs args);

    //this class uses the previous and handles the event
    public class EventUserClass
    {

        private ClassWithEvent myObjectWithEvents = new ClassWithEvent();

        public EventUserClass()
        {
            myObjectWithEvents.MyEvent += MyEventHandler;
        }

        public void MyEventHandler(Object sender, MyEventArgs args)
        {
            Console.WriteLine(args.SomeInfo);
        }

    }

}

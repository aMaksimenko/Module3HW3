using System;

namespace HomeWork
{
    public class Starter
    {
        public void Run()
        {
            var myObject = new MyObject();
            var myObserver1 = new MyObserver(1, myObject);
            var myObserver2 = new MyObserver(2, myObject);
            var myObserver3 = new MyObserver(3, myObject);

            myObserver1.Attach();
            myObserver2.Attach();
            myObserver3.Attach();
            myObject.Notify(new MyEventArgs() { Message = "This is the 1st notification" });

            Console.WriteLine("-----------------------");

            myObserver1.Detach();
            myObserver2.Detach();
            myObject.Notify(new MyEventArgs() { Message = "The last one" });
        }
    }
}
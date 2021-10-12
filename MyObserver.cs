using System;

namespace HomeWork
{
    public class MyObserver
    {
        private int _id;
        private MyObject _subject;

        public MyObserver(int id, MyObject subject)
        {
            _id = id;
            _subject = subject;
        }

        public void Attach()
        {
            _subject.EventHandler += Action;
        }

        public void Detach()
        {
            _subject.EventHandler -= Action;
        }

        private void Action(object sender, MyEventArgs eventArgs)
        {
            Console.WriteLine($"Notify from observer with ID: {_id} and message: {eventArgs.Message}");
        }
    }
}
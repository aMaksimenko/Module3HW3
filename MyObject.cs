using System;

namespace HomeWork
{
    public class MyObject
    {
        public event EventHandler<MyEventArgs> EventHandler;

        public void Notify(MyEventArgs eventArgs)
        {
            EventHandler?.Invoke(this, eventArgs);
        }
    }
}
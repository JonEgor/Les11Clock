using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public sealed class Time
    {
        public EventHandler TimeEvent;

        public void AddViewer(Viewer viewer)
        {
            viewer.ViewerEvent += ViewerReceivedEvent;
        }

        private void ViewerReceivedEvent(object? sender, EventArgs e)
        {
   
           

            TimeEvent.Invoke(this, EventArgs.Empty);
        }

    }

    public sealed class Viewer
    {
        public EventHandler ViewerEvent;
        public int timeTimer;

        public void AddTime(Time time)
        {
            time.TimeEvent += TimeReceivedEvent;
        }


        private void TimeReceivedEvent(object? sender, EventArgs e)
        {
           
            --timeTimer;
            if (timeTimer == 0) 
            
            {
                Console.WriteLine("Time is over");
                return;
            }

                
            Console.WriteLine(" Countdown started from 10 ");
            Console.WriteLine($"Timer: {timeTimer}");
            Thread.Sleep(1000);
            Console.Clear();
            ViewerEvent.Invoke(this, EventArgs.Empty);

        }
    }
}

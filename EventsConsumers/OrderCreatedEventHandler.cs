using System;

namespace EventsConsumers
{
    public class OrderCreatedEventHandler
    {
        private readonly string JsonString;

        public OrderCreatedEventHandler(string message)
        {
            JsonString = message;
        }

        public void ProcessEvent(object stateInfo)
        {
            Console.WriteLine("Processing OrderShippedEvent: " + JsonString);
        }
    }

    

   

   

    
}
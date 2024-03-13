// Defines a namespace named HangfireWithDotnet.Services

namespace HangfireWithDotnet.Services
{
    // Defines a public class named JobTestService which implements IJobTestService interface
    public class JobTestService : IJobTestService
    {
        // Defines a public method named FireAndForgetJob which doesn't require any parameter and doesn't return a value
        public void FireAndForgetJob()
        {
            // Prints a message to the console
            Console.WriteLine("Hello from a Fire and Forget job!");
        }

        // Defines a public method named ReccuringJob which doesn't require any parameter and doesn't return a value
        public void ReccuringJob()
        {
            // Prints a message to the console
            Console.WriteLine("Hello from a Scheduled job!");
        }

        // Defines a public method named DelayedJob which doesn't require any parameter and doesn't return a value
        public void DelayedJob()
        {
            // Prints a message to the console
            Console.WriteLine("Hello from a Delayed job!");
        }

        // Defines a public method named ContinuationJob which doesn't require any parameter and doesn't return a value
        public void ContinuationJob()
        {
            // Prints a message to the console
            Console.WriteLine("Hello from a Continuation job!");
        }
    }
}
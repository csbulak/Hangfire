// The code is placed within the HangfireWithDotnet.Services namespace

namespace HangfireWithDotnet.Services
{
    // An interface named IJobTestService is declared
    public interface IJobTestService
    {
        // A method named FireAndForgetJob is defined without any return type (void) and no parameters
        void FireAndForgetJob();

        // A method named ReccuringJob is defined without any return type (void) and no parameters
        void ReccuringJob();

        // A method named DelayedJob is defined without any return type (void) and no parameters
        void DelayedJob();

        // A method named ContinuationJob is defined without any return type (void) and no parameters
        void ContinuationJob();
    }
}
namespace Blazor.BlazorWorkerTest.Services
{
    public class TestService
    {
        public int TestMethod()
        {
            int i = 0;
            Console.WriteLine("Starting long running task");
            DateTime endTime = DateTime.UtcNow.AddSeconds(10);
            while (DateTime.UtcNow < endTime)
            {
                i++;
                Console.WriteLine("Task.Delay(100) - " + i.ToString());
                Task.Delay(1000);
            }
            Console.WriteLine("Finished long running task");

            return i;
        }
    }
}

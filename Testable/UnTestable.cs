namespace UnTestableTests
{
    public class UnTestable
    {

        public string GetCurrentTimeGreeting()
        {
            var currentTime = DateTime.Now;

            if (currentTime.Hour < 12)
            {
                return "Good Morning";
            }
            else
            {
                return "Good Afternoon";
            }
        }
    }
}
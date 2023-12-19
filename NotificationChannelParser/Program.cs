using System.Collections;

namespace NotificationChannelParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Notificiation Title:");
            var notificationMessage= Console.ReadLine();
            var channelList = new ArrayList();
            if (notificationMessage.Contains("[BE]"))
            {
                channelList.Add("BE");
            }
            if (notificationMessage.Contains("[FE]"))
            {
                channelList.Add("FE");
            }
            if (notificationMessage.Contains("[QA]"))
            {
                channelList.Add("QA");
            }
            if (notificationMessage.Contains("[Urgent]"))
            {
                channelList.Add("Urgent");
            }

            string channels = string.Join(", ", channelList.ToArray());
            Console.WriteLine($"{Environment.NewLine}Received Channels: {channels}");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}

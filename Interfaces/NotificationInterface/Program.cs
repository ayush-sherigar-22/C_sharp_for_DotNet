using System;

namespace NotificationInterface
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            var notifications = new List<INotification>
            {
                new EmailNotification(),
                new SMSNotification(),
                new PushNotification()
            };

            var notificationSend = new NotificationManager(notifications);
            notificationSend.SendMessage("Hello this is a new message");
        }
    }
}
namespace Abstraction
{
    public abstract class NotificationSystem
    {
        public abstract void Send(string message);

        public void Log(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException("Message cannot be empty");
            }
            Console.WriteLine($"[LOG] Notification sent: {message} at {DateTime.Now}");
        }
    }

    public class EmailNotification : NotificationSystem
    {
        public override void Send(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException("Message cannot be empty");
            }
            Console.WriteLine($"Sending Email: {message}");
            Log(message);
        }
    }

    public class PushNotification : NotificationSystem
    {
        public override void Send(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException("Message cannot be empty");
            }
            Console.WriteLine($"Sending Push Notification: {message}");
            Log(message);
        }
    }

    public class SMSNotification : NotificationSystem
    {
        public override void Send(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException("Message cannot be empty");
            }
            Console.WriteLine($"Sending SMS: {message}");
            Log(message);
        }
    }
}


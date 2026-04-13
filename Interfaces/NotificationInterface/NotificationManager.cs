namespace NotificationInterface
{
    public class NotificationManager
    {   
        private List<INotification> _notifications;
     
        public NotificationManager(List<INotification> notification)
        {
            if (notification == null || notification.Count == 0)
            {
                throw new ArgumentNullException("List Cant be null");
            }
            _notifications = notification;
           
            
        }

        public void SendMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException("Message cannot be empty");
            }
            foreach (var notification in _notifications)
            {
                notification.Send(message);
               
            }
            Log(message);
        }
        public void Log(string message)
        {
   
            Console.WriteLine($"[LOG] Notification sent: {message} at {DateTime.Now}");
        }
    }
}
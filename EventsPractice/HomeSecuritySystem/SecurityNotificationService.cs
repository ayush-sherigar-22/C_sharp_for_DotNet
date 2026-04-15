namespace EventPractice
{
    public class SecurityNotificationService
    {
        public void OnDoorOpened(object source, DoorEventArgs e)
        {
            Console.WriteLine($"[Security Notification]: {e.Door} is Open");
        }

        public void OnMotionDetected(object source, MotionEventArgs e)
        {
            Console.WriteLine($"[Security Notification]: Motion has been detected at {e.Location}, at {e.Time}");
        }
    }
}
namespace EventPractice
{
    public class AlarmSystem
    {
        public void OnDoorOpened(object source, DoorEventArgs e)
        {
            Console.WriteLine($"[Alarm System]: {e.Door} is Open");
        }

        public void OnMotionDetected(object source, MotionEventArgs e)
        {
            Console.WriteLine($"[Alarm System]:Motion has been detected at {e.Location}, at {e.Time}");
        }

    }
}
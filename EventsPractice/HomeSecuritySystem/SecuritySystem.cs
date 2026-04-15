namespace EventPractice
{
    public class SecuritySystem
    {
        public  event EventHandler<DoorEventArgs> DoorOpened;
        public event EventHandler<MotionEventArgs> MotionDetected;


        public void DoorSecurityCheck(string door, bool status)
        {
            if (status)
            {
                OnDoorOpened(door, status);
            }
            else
            {
                Console.WriteLine($"{door} is Closed. Its Safe.");
            }  
        }

        public void MotionSecurityCheck(bool detected,string location, DateTime time)
        {
            if (detected)
            {
                OnMotionDetected(detected, location, time);
            }
            else
            {
                Console.WriteLine($"No motion detected. Its Safe.");
            }
        }

        protected virtual void OnMotionDetected(bool detected, string location, DateTime time)
        {
            MotionDetected?.Invoke(this, new MotionEventArgs
            {
                Location = location,
                Time = time
            });
        }

        protected void OnDoorOpened(string door, bool status)
        {
            DoorOpened?.Invoke(this, new DoorEventArgs { Door = door });
        }

    }
}
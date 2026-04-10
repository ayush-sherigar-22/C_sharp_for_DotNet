namespace Abstraction {
    public class SmartFan : SmartHome
    {
        private int speed;

        public override void TurnOn()
        {
            if (isOn)
                Console.WriteLine("Fan already ON");
            else
            {
                isOn = true;
                speed = 1;
                Console.WriteLine($"Fan ON at speed {speed}");
            }
        }

        public override void TurnOff()
        {
            if (!isOn)
                Console.WriteLine("Fan already OFF");
            else
            {
                isOn = false;
                speed = 0;
                Console.WriteLine("Fan turned OFF");
            }
        }
    }
}
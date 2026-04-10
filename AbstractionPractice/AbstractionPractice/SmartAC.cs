namespace Abstraction {
    public class SmartAC : SmartHome
    {
        private int temperature;

        public override void TurnOn()
        {
            if (isOn)
                Console.WriteLine("AC already ON");
            else
            {
                isOn = true;
                temperature = 24;
                Console.WriteLine($"AC ON at {temperature}°C");
            }
        }

        public override void TurnOff()
        {
            if (!isOn)
                Console.WriteLine("AC already OFF");
            else
            {
                isOn = false;
                Console.WriteLine("AC turned OFF");
            }
        }
    } 
}
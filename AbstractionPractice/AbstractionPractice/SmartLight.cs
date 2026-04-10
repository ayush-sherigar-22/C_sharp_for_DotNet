namespace Abstraction {
    public class SmartLight : SmartHome
    {
        public override void TurnOn()
        {
            if (isOn)
                Console.WriteLine("Light already ON");
            else
            {
                isOn = true;
                Console.WriteLine("Light turned ON");
            }
        }

        public override void TurnOff()
        {
            if (!isOn)
                Console.WriteLine("Light already OFF");
            else
            {
                isOn = false;
                Console.WriteLine("Light turned OFF");
            }
        }
    }
}
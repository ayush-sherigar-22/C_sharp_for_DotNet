namespace Abstraction {
    public abstract class SmartHome
    {
        protected bool isOn;

        public abstract void TurnOn();
        public abstract void TurnOff();

        public void GetStatus()
        {
            Console.WriteLine($"{this.GetType().Name} is {(isOn ? "On" : "Off")}");
        }
    }


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
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
}
namespace Inheritance
{
    public class Appliance
    {
        public void TurnOn()
        {
            Console.WriteLine("Turning on the appliance");
            Thread.Sleep(1000);

        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off the appliance");
            Thread.Sleep(1000);
        }
    }

    public class WashingMachine : Appliance
    {
        public void WashClothes()
        {

            TurnOn();
            Console.WriteLine("Started washing the clothes");
            Thread.Sleep(1000);
            Console.WriteLine("Finished washing the clothes");
            Thread.Sleep(1000);
            TurnOff();

        }
    }


    public class ClotherDryer : Appliance
    {
        public void DryClothes()
        {

            TurnOn();

            Console.WriteLine("Started drying the clothes");
            Thread.Sleep(1000);
            Console.WriteLine("Finished drying the clothes");
            Thread.Sleep(1000);
            TurnOff();
        }
    }
}

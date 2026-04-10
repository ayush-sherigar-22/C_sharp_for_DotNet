namespace Abstraction
{
    public abstract class Vehicle{

        public abstract string StartEngine();
        public abstract string StopEngine();
        public abstract string FuelType();
            
    }


    public class Bike : Vehicle
    {
        public override string FuelType()
        {
            return "Petrol Bike";
        }

        public override string StartEngine()
        {
            return "Bike Engine is starting";
        }

        public override string StopEngine()
        {
            return "Bike Engine is stopping";
        }
    }

    public class Car : Vehicle
    {
        public override string FuelType()
        {
            return "Diesel Car";
        }

        public override string StartEngine()
        {
            return "Car Engine is starting";
        }

        public override string StopEngine()
        {
            return "Car Engine is stopping";
        }
    }



    public class ElectricVechile : Vehicle
    {
        public override string FuelType()
        {
            return "Electric Vehicle";
        }

        public override string StartEngine()
        {
            return "Electric Vehicle is starting";
        }

        public override string StopEngine()
        {
            return "Electric Bike is stopping";
        }
    }
}


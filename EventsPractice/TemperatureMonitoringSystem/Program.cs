namespace EventsPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var temp = new Temperature();
            

            var tempSensor = new  TemperaturSensor();

            var cooling = new CoolingSysten();
            var alert = new Alert();

            tempSensor.TemperatureChanged += cooling.OnTemperatureChanged;
            tempSensor.TemperatureChanged += alert.OnTemperaturChanged;
           
            do
            {
                temp.Temp = new Random().Next(24, 32);
                tempSensor.TemperaturCheck(temp);
               

            } while (temp.Temp != 30);
        }
    }

}


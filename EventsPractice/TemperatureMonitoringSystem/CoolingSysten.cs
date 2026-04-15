namespace EventsPractice
{
    public class CoolingSysten
    {
        public void OnTemperatureChanged(object source, TemperatureEventArgs temp) 
        {
            Console.WriteLine($"Cooling ON at {temp.Temperature}°C");
        }
    }

}


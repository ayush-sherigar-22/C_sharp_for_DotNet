namespace EventsPractice
{
    public class Alert
    {
        public void OnTemperaturChanged(object source, TemperatureEventArgs temp)
        {
            Console.WriteLine("Alert : Temperature High should be below 30 !");
        }
    }

}


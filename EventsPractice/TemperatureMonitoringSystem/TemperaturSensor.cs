namespace EventsPractice
{
    public class TemperaturSensor
    {
        public delegate void TemperatureEventHandler(object source, TemperatureEventArgs temp);
        public event TemperatureEventHandler TemperatureChanged;

        public void TemperaturCheck(Temperature temp)
        {
            if (temp.Temp >= 30)
            {
               
                Console.WriteLine($"Temperature is : {temp.Temp}");
                OnTemperatureChanged(temp);
            }
            else
            {
                Console.WriteLine($"Temperature is : {temp.Temp}");
            }
        }

        protected virtual void OnTemperatureChanged(Temperature temp) 
        {
            if(TemperatureChanged != null)
            {
                TemperatureChanged(this, new TemperatureEventArgs { Temperature = temp.Temp });
            }
        }

    }

}


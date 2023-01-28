namespace Observer
{
    public class WebDisplay : IObserver
    {
        private readonly WeatherStation station;

        public WebDisplay(WeatherStation station)
        {
            this.station = station;
        }

        public void Update()
        {
            Console.WriteLine("Web Display Temproture is " + station.GetTeprature());
        }
    }
}
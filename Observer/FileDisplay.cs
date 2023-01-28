namespace Observer
{
    public class FileDisplay : IObserver
    {
        private readonly WeatherStation station;

        public FileDisplay(WeatherStation station)
        {
            this.station = station;
        }

        public void Update()
        {
            Console.WriteLine("File Display Temproture is " + station.GetTeprature());
        }
    }
}
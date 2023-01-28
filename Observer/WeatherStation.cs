namespace Observer
{
    public class WeatherStation : IObservable
    {
        private byte Temprature { get; set; }
        private readonly List<IObserver> Observers;
        public WeatherStation()
        {
            Observers = new List<IObserver>();
        }

        public void Add(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update();
            }
        }

        public byte GetTeprature()
        {
            return Temprature;
        }

        public void SetTemproture(byte temprature)
        {
            Temprature = temprature;
        }
    }
}
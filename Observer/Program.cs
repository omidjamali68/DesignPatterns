using Observer;

var station = new WeatherStation();
var fileObserver = new FileDisplay(station);
var webObserver = new WebDisplay(station);
station.Add(fileObserver);
station.Add(webObserver);

station.SetTemproture(15);
station.Notify();
// results
// File Display Temproture is 15
// Web Display Temproture is 15

station.SetTemproture(21);
station.Notify();
// results
// File Display Temproture is 21
// Web Display Temproture is 21
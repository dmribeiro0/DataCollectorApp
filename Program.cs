class Program
{
    static void Main()
    {
        var temperature = new Temperature();
        var ph = new PH();
        var humidity = new Humidity();

        var unifesp = new UNIFESPObserver();
        var usp = new USPObserver();
        var ufrgs = new UFRGSObserver();

        temperature.AddObserver(unifesp);
        temperature.AddObserver(usp);
        temperature.AddObserver(ufrgs);

        ph.AddObserver(unifesp);
        ph.AddObserver(usp);
        ph.AddObserver(ufrgs);

        humidity.AddObserver(unifesp);
        humidity.AddObserver(usp);
        humidity.AddObserver(ufrgs);

        var dataCollector = new DataCollector(temperature, ph, humidity);

        Console.WriteLine("=== Coleta 1 ===");
        dataCollector.SetData(27.4, 6.9, 86.0);

        Console.WriteLine();
        
        Console.WriteLine("=== Coleta 2 (USP removida do sensor de umidade) ===");
        humidity.RemoveObserver(usp);
        dataCollector.SetData(28.1, 6.7, 88.5);
    }
}
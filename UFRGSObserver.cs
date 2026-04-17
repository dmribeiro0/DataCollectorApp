class UFRGSObserver : IObserver
{
    public void Update(Subject subject) 
    {
        switch(subject) 
        {
            case Temperature temp:
                Console.WriteLine($"UFRGS recebeu a atualização da temperatura: {temp.GetTemperature()}");
                break;
            case PH ph:
                Console.WriteLine($"UFRGS recebeu a atualização do pH: {ph.GetPH()}");
                break;
            case Humidity hum:
                Console.WriteLine($"UFRGS recebeu a atualização da umidade: {hum.GetHumidity()}");
                break;
        }
    }
}
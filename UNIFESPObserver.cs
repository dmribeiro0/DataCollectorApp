class UNIFESPObserver : IObserver
{
    public void Update(Subject subject) 
    {
        switch(subject) 
        {
            case Temperature temp:
                Console.WriteLine($"UNIFESP recebeu a atualização da temperatura: {temp.GetTemperature()}");
                break;
            case PH ph:
                Console.WriteLine($"UNIFESP recebeu a atualização do pH: {ph.GetPH()}");
                break;
            case Humidity hum:
                Console.WriteLine($"UNIFESP recebeu a atualização da umidade: {hum.GetHumidity()}");
                break;
        }
    }
}
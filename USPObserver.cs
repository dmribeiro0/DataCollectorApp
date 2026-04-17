class USPObserver : IObserver
{
    public void Update(Subject subject) 
    {
        switch(subject) 
        {
            case Temperature temp:
                Console.WriteLine($"USP recebeu a atualização da temperatura: {temp.GetTemperature()}");
                break;
            case PH ph:
                Console.WriteLine($"USP recebeu a atualização do pH: {ph.GetPH()}");
                break;
            case Humidity hum:
                Console.WriteLine($"USP recebeu a atualização da umidade: {hum.GetHumidity()}");
                break;
        }
    }
}
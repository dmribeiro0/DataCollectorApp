class Humidity : Subject
{
    private double humidity;

    public double GetHumidity() 
    {
        return humidity;
    }

    public void SetHumidity(double hum) 
    {
        humidity = hum;
        NotifyObservers();
    }
}
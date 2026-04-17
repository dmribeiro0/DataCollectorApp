class Temperature : Subject
{
    private double temperature;

    public double GetTemperature() 
    {
        return temperature;
    }

    public void SetTemperature(double temp) 
    {
        temperature = temp;
        NotifyObservers();
    }
}
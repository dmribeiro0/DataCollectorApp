class DataCollector
{
    private Temperature temperature;
    private PH pH;
    private Humidity humidity;

    // Construtor que recebe os objetos de sensores como parâmetros
    // Isso aumenta a flexibilidade, permitindo a injeção de dependências e facilitando testes unitários
    public DataCollector(Temperature temp, PH ph, Humidity hum) 
    {
        temperature = temp;
        pH = ph;
        humidity = hum;
    }

    // Construtor padrão que cria instâncias internas dos sensores
    // Embora seja menos flexível, pode ser útil para casos simples onde a configuração dos sensores é fixa
    public DataCollector() 
    {
        temperature = new Temperature();
        pH = new PH();
        humidity = new Humidity();
    }

    public void SetData(double temp, double ph, double hum) 
    {
        temperature.SetTemperature(temp);
        pH.SetPH(ph);
        humidity.SetHumidity(hum);
    }
}
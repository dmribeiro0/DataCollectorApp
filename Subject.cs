class Subject 
{
    private List<IObserver> observers = new List<IObserver>();

    public void AddObserver(IObserver observer) 
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer) 
    {
        observers.Remove(observer);
    }

    public void NotifyObservers() 
    {
        foreach (var observer in observers) 
        {
            observer.Update(this);
        }
    }
}
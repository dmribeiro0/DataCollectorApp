class PH : Subject
{
    private double pH;

    public double GetPH() 
    {
        return pH;
    }

    public void SetPH(double ph) 
    {
        pH = ph;
        NotifyObservers();
    }
}
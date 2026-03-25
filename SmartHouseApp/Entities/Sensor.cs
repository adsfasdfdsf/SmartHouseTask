namespace SmartHomeMVP;

public class Sensor
{
    private string _room;
    
    public Sensor(string room)
    {
        _room = room;
    }

    public double GetReading()
    {
        Random rnd = new Random();
        return rnd.NextDouble() * 100;
    }
}
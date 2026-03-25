namespace SmartHomeMVP;

public class Thermostat
{
    private string _room;
    private int _temperature;
    
    public Thermostat(string room)
    {
        _room = room;
    }

    public void SetTemperature(int temperature)
    {
        _temperature = temperature;
    }

    public string GetStatus()
    {
        return $"{_temperature} degrees";
    }
}
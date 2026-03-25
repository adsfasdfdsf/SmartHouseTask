namespace SmartHomeMVP;

public class BrandADeviceFactory: IDeviceFactory
{
    public Light CreateLight(string room)
    {
        return new Light(room);
    }

    public Thermostat CreateThermostat(string room)
    {
        return new Thermostat(room);
    }
    
    public Sensor CreateSensor(string room)
    {
        return new Sensor(room);
    }
}
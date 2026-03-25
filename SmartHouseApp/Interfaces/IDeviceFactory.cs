namespace SmartHomeMVP;

public interface IDeviceFactory
{
    public Light CreateLight(string room);
    public Thermostat CreateThermostat(string room);
    public Sensor CreateSensor(string room);
}
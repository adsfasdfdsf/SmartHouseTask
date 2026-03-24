using System.ComponentModel;

namespace SmartHomeMVP;

// Контроллер для управления устройствами умного дома
public class SmartHomeController
{

    private static SmartHomeController? _instance;

    private List<object> _devices;

    public static SmartHomeController Instance {
        get {
            if (_instance == null)
                _instance = new SmartHomeController();
            return _instance;
        }
    }

    private SmartHomeController()
    {
        _devices = new List<object>();
    }

    public void RegisterDevice(object device)
    {
        _devices.Add(device);
    }
    
    public void TurnLightOn()
    {
        foreach (object device in _devices)
        {
            if (device is Light)
            {
                (device as Light)?.TurnOn();
            }
        }
    }

    // Метод для выключения света через контроллер
    public void TurnLightOff()
    {
        foreach (object device in _devices)
        {
            if (device is Light)
            {
                (device as Light)?.TurnOff();
            }
        }
    }

    public string GetLightStatus()
    {
        foreach (object device in _devices)
        {
            if (device is Light light)
            {
                return light.GetStatus();
            }
        }
        return "";
    }
}
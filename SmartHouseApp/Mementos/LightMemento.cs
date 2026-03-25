namespace SmartHomeMVP;

public class LightMemento
{
    private bool _savedIsOn;
    private string _savedRoomName;

    public LightMemento(bool isOn, string room)
    {
        _savedIsOn = isOn;
        _savedRoomName = room;
    }

    public bool GetIsOn()
    {
        return _savedIsOn;
    }

    public string GetRoomName()
    {
        return _savedRoomName;
    }
}
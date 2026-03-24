namespace SmartHomeMVP;

public class OffState: ILightState
{
    public string GetStatus()
    {
        return "Off";    
    }
}
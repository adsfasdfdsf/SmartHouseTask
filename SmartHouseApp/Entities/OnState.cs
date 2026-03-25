namespace SmartHomeMVP;

public class OnState: ILightState
{
    public string GetStatus()
    {
        return "On";
    }
}
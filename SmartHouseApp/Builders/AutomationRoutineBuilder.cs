namespace SmartHomeMVP;

public class AutomationRoutineBuilder
{
    private string _description;

    public AutomationRoutineBuilder()
    {
        _description = "";
    }
    
    public AutomationRoutineBuilder AddTurnOnCommand(string device)
    {
        _description += $"Turn on {device}; ";
        return this;
    }

    public AutomationRoutineBuilder AddSetTemperatureCommand(string device, int temp)
    {
        _description += $"Set {device} to {temp}C; ";
        return this;
    }

    public AutomationRoutineBuilder AddLockCommand(string device)
    {
        _description += $"Lock {device}; ";
        return this;
    }

    public AutomationRoutine Build()
    {
        return new AutomationRoutine(_description);
    }
}
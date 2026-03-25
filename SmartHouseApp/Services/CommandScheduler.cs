namespace SmartHomeMVP;

public class CommandScheduler
{
    private List<ICommand> _commands;

    public CommandScheduler()
    {
        _commands = new List<ICommand>();
    }

    public void ScheduleCommand(ICommand command)
    {
        _commands.Add(command);
    }

    public void ExecuteCommands()
    {
        foreach (var command in _commands)
        {
            command.Execute();
        }
    }
}
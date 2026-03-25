using System;

namespace SmartHomeMVP
{
    // Клиентский код, использующий контроллер для управления устройством
    class Program
    {
        static void Main(string[] args)
        {
            IDeviceFactory factory = new BrandADeviceFactory();
            Light livingRoomLight = factory.CreateLight("Living Room");

            // Получаем синглтон-контроллер и регистрируем устройство
            SmartHomeController controller = SmartHomeController.Instance;
            controller.RegisterDevice(livingRoomLight);

            Console.WriteLine("Initial Light Status: " + controller.GetLightStatus());
            controller.TurnLightOn();
            Console.WriteLine("After TurnOn: " + controller.GetLightStatus());
            controller.TurnLightOff();
            Console.WriteLine("After TurnOff: " + controller.GetLightStatus());

            
            // Построение сценария с помощью билдера
            AutomationRoutine routine = new AutomationRoutineBuilder()
                .AddTurnOnCommand("Living Room Light")
                .AddSetTemperatureCommand("Thermostat", 22)
                .AddLockCommand("Front Door")
                .Build();

            // При необходимости можно клонировать сценарий
            AutomationRoutine routineClone = routine.Clone();

            routine.Execute();

            Light light = new Light("Garage");
            ICommand onCommand = new TurnOnCommand(light);
            ICommand offCommand = new TurnOffCommand(light);

            CommandScheduler scheduler = new CommandScheduler();
            scheduler.ScheduleCommand(onCommand);
            scheduler.ScheduleCommand(offCommand);

            // Выполняем все запланированные команды
            scheduler.ExecuteCommands();

            light.TurnOn();
            // Сохраняем текущее состояние
            LightMemento memento = light.CreateMemento();
            Console.WriteLine("Status after TurnOn: " + light.GetStatus());

            light.TurnOff();
            Console.WriteLine("Status after TurnOff: " + light.GetStatus());

            // Восстанавливаем состояние из мементо
            light.Restore(memento);
            Console.WriteLine("Status after Restore: " + light.GetStatus());

            Console.WriteLine("Initial state: " + light.GetStatus());
            
            // Переключаем состояние на On
            light.SetState(new OnState());
            Console.WriteLine("After setting to On: " + light.GetStatus());
            
            // Переключаем состояние на Off
            light.SetState(new OffState());
            Console.WriteLine("After setting to Off: " + light.GetStatus());
            
            Console.ReadLine();
        }
    }
}
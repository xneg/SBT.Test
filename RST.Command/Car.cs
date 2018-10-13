using System;

namespace RST.Command
{
    public class Car : IUnit
    {
        public void ExecuteCommand(ICommand command)
        {
            switch (command)
            {
                case MoveCommand move:
                    Console.WriteLine("Car moved");
                    break;
                default:
                    break;
            }
        }
    }
}

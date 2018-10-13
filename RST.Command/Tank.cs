using System;

namespace RST.Command
{
    public class Tank : IUnit
    {
        public void ExecuteCommand(ICommand command)
        {
            switch (command)
            {
                case MoveCommand move:
                    Console.WriteLine("Tank moved");
                    break;
                case FireCommand fire:
                    Console.WriteLine("Tank fired");
                    break;
                default:
                    break;
            }
        }
    }
}
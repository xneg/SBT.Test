using System;

namespace RST.Command.Extension
{
    public class Helicopter : IUnit
    {
        public void ExecuteCommand(ICommand command)
        {
            switch (command)
            {
                case MoveCommand move:
                    Console.WriteLine("Helicopter moved");
                    break;
                case RotateCommand rotate:
                    Console.WriteLine("Helicopter rotated");
                    break;
                default:
                    break;
            }
        }
    }
}

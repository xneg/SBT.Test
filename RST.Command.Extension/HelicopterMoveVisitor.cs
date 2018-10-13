using System;

namespace RST.Command.Extension
{
    public class HelicopterMoveVisitor : MoveVisitor, IExtendedVisitor
    {
        public void Visit(Helicopter helicopter)
        {
            Console.WriteLine("Helicopter is moving");
        }
    }
}

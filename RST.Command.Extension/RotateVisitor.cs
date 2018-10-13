using System;

namespace RST.Command.Extension
{
    public class RotateVisitor : IExtendedVisitor
    {
        public void Visit(Helicopter helicopter)
        {
            Console.WriteLine("Helicopter is rotating");
        }

        public void Visit(Fence fence)
        {
        }

        public void Visit(Car car)
        {
        }

        public void Visit(Tank tank)
        {
        }
    }
}

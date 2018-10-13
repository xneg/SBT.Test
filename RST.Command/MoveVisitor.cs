using System;

namespace RST.Command
{
    public class MoveVisitor : IUnitVisitor
    {
        public void Visit(Fence fence)
        {
            return;
        }

        public void Visit(Car car)
        {
            Console.WriteLine("Car is moving");
        }

        public void Visit(Tank tank)
        {
            Console.WriteLine("Tank is moving");
        }
    }
}

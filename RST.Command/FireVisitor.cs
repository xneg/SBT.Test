using System;

namespace RST.Command
{
    public class FireVisitor : IUnitVisitor
    {
        public void Visit(Fence fence)
        {
        }

        public void Visit(Car car)
        {
        }

        public void Visit(Tank tank)
        {
            Console.WriteLine("Tank is firing");
        }
    }
}

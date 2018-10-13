namespace RST.Command
{
    public interface IUnitVisitor
    {
        void Visit(Fence fence);

        void Visit(Car car);

        void Visit(Tank tank);
    }
}

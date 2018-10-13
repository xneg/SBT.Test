namespace RST.Command.Extension
{
    public interface IExtendedVisitor : IUnitVisitor
    {
        void Visit(Helicopter helicopter);
    }
}

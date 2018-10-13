namespace RST.Command
{
    public interface IUnit
    {
        void Accept(IUnitVisitor visitor);
    }
}
namespace RST.Command.Extension
{
    public class Helicopter : IUnit
    {
        public void Accept(IUnitVisitor visitor)
        {
            (visitor as IExtendedVisitor)?.Visit(this);
        }
    }
}

namespace RST.Command
{
    public class Fence : IUnit
    {
        public void Accept(IUnitVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
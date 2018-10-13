namespace RST.Command
{
    public class Tank : IUnit
    {
        public void Accept(IUnitVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
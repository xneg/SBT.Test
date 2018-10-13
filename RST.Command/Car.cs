namespace RST.Command
{
    public class Car : IUnit
    {
        public void Accept(IUnitVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

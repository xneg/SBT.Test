namespace RST.Command
{
    public abstract class AbstractCommand
    {
        private IUnitVisitor _visitor;

        public AbstractCommand(IUnitVisitor visitor)
        {
            _visitor = visitor;
        }

        public void Execute(IUnit unit)
        {
            unit.Accept(_visitor);
        }
    }
}

namespace RST.Command
{
    public interface ICommand
    {
        void Execute(IUnit unit);
    }

    public class MoveCommand : AbstractCommand, ICommand
    {
        public MoveCommand(IUnitVisitor visitor = null) : base(visitor ?? new MoveVisitor())
        {
        }
    }

    public class FireCommand : AbstractCommand, ICommand
    {
        public FireCommand(IUnitVisitor visitor = null) : base(visitor ?? new FireVisitor())
        {
        }
    }
}
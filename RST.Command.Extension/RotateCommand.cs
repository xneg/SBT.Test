namespace RST.Command.Extension
{
    public class RotateCommand : AbstractCommand, ICommand
    {
        public RotateCommand() : base(new RotateVisitor())
        {
        }
    }
}

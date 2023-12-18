namespace KlikkerSpill
{
    internal class ExitCommand : ICommand
    {
        public char Character => 'X';

        public void Run()
        {
            Environment.Exit(0);
        }

    }
}

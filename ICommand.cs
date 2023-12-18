namespace KlikkerSpill
{
    internal interface ICommand
    {
        void Run();
        char Character { get; }
    }
}

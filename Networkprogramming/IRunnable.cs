namespace Networkprogramming
{
    internal interface IRunnable
    {
        string Name { get; }
        string Description { get; }
        void Run();
    }
}

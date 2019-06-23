namespace Structural_Adapter
{
    internal interface ILogManager<T> where T : ILogContext
    {
        void WriteTo(ILog log);
    }
}
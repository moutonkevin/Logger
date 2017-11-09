namespace MyLogger.Interfaces
{
    internal interface IWriter
    {
        void Write<TDestination, TContent>(TDestination destination, TContent content);
    }
}
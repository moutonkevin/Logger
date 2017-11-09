namespace MyLogger.Interfaces
{
    internal interface IReader
    {
        TOutput Get<TOutput>(string path) where TOutput : class, new();
    }
}
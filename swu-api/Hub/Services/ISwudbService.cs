namespace SwuApi.Server.Services
{
    public interface ISwudbService
    {
        Task<IReadOnlyDictionary<string, int>> GetDeckListAsync(string url);
    }
}

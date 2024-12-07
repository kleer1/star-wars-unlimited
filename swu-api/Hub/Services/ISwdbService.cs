namespace SwuApi.Server.Services
{
    public interface ISwdbService
    {
        Task<IReadOnlyDictionary<string, int>> GetDeckListAsync(string url);
    }
}

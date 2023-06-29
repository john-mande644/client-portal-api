namespace ClientPortal_API.Services.v1
{
    public interface IGridService<T>
    {
        Task<List<T>> GetItemsAsync(int clientId);
    }
}
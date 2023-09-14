using Cache.Models;

namespace Cache.Interfaces.Services;

public interface IMemoryService
{
    /// <summary>
    /// Получение всех пользователей
    /// </summary>
    /// <returns>Коллекция пользователей</returns>
    public Task<IEnumerable<User>> GetUsersAsync();
}
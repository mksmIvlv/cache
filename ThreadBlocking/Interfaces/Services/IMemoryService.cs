namespace ThreadBlocking.Interfaces.Services;

public interface IMemoryService
{
    /// <summary>
    /// Получение всех пользователей
    /// </summary>
    /// <returns>Коллекция пользователей</returns>
    public Task AddUserInRedisAsync();
}
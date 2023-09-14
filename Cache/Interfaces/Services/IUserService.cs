using Cache.Models;

namespace Cache.Interfaces.Services;

public interface IUserService
{
    /// <summary>
    /// Прочитать файл json с диска и десереализовать в коллекцию объектов
    /// </summary>
    /// <returns>Коллекция пользователей</returns>
    public Task<IEnumerable<User>> DeserializeJsonFileAsync();
}
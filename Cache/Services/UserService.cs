using Cache.Interfaces.Services;
using Cache.Models;
using Newtonsoft.Json;

namespace Cache.Services;

public class UserService: IUserService
{
    #region Поля

    private readonly string _jsonFileUsers = "CollectionUsers.json"; 

    #endregion

    #region Метод

    /// <summary>
    /// Прочитать файл json с диска и десереализовать в коллекцию объектов
    /// </summary>
    /// <returns>Коллекция пользователей</returns>
    public async Task<IEnumerable<User>> DeserializeJsonFileAsync()
    {
        var usersString = await File.ReadAllTextAsync(_jsonFileUsers);
        var collectionUsers = JsonConvert.DeserializeObject<List<User>>(usersString);
        
        return collectionUsers;
    }

    #endregion
}
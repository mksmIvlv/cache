using Cache.Interfaces.Services;
using Cache.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cache.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class HomeController: ControllerBase
{
    #region Поля
    
    private IMemoryService _memoryService;

    #endregion

    #region Конструктор

    public HomeController(IMemoryService memoryService)
    {
        _memoryService = memoryService;
    }

    #endregion

    [HttpGet(Name = "GetUsers") ]
    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        return await _memoryService.GetUsersAsync();
    }
}
using GamesPlay.Models;
using GamesPlay.Services;
using Microsoft.AspNetCore.Mvc;

namespace GamesPlay.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : GenericController<User>
    {
        public UserController(UserService service) : base(service)
        {
        }
    }
}

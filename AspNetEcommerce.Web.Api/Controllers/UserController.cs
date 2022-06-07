using AspNetEcommerce.Business;
using AspNetEcommerce.Data.Entity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetEcommerce.Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet(Name = "GetUsers")]
        public IEnumerable<User> Get()
        {
            return _userService.GetAllUsers();
        }
    }
}
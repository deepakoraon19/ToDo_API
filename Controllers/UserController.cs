using Microsoft.AspNetCore.Mvc;
using ToDo_API.Models;
using VM = ToDo_API.ViewModels;
namespace ToDo_API.Controllers
{
    [ApiController]
    [Route("/user")]
    public class UserController : ControllerBase
    {
        private readonly TODOContext ctx;
        public UserController(TODOContext ctx) => this.ctx = ctx;

        [HttpGet]
        public IEnumerable<User> Get() => ctx.Users.ToList();

        [HttpPost]
        public string Post([FromBody]VM.Users user)
        {
            try
            {
                user.LastUpdatedOn = DateTime.UtcNow;
                user.DateOfBirth = DateTime.UtcNow;

                var x = ctx.Users.Add(Mapper.MapToDm(user));
                ctx.SaveChanges();
                return user.UserId.ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
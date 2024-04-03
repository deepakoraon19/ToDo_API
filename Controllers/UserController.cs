using Microsoft.AspNetCore.Mvc;
using ToDo_API.Models;
using ToDo_API.Services;
using ToDo_API.Utils;
using VM = ToDo_API.ViewModels;
namespace ToDo_API.Controllers
{
    [ApiController]
    [Route("/user")]
    public class UserController : ControllerBase
    {
        private UserService svc;
        public UserController(UserService svc) => this.svc = svc;

        [HttpGet]
        public IEnumerable<VM.Users> Get() => svc.Get();

        [HttpDelete]
        public Reply Delete(string id) => Helper.CreateReply(async () => await svc.Delete(id)).Result;

        [HttpPost]
        public Reply Post([FromBody] VM.Users user) => Helper.CreateReply(async () => await svc.Add(user)).Result;

        [HttpPut]
        public Reply Put([FromBody] VM.Users user) => Helper.CreateReply(async () => await svc.Update(user)).Result;


    }
}
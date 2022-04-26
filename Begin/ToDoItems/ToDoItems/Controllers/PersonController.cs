using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToDoItems.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        //This determins what the action/api method is, needs a meaningful name 
        [HttpGet(Name = "GetPerson")]
        public string Get()
        {
            return "Hello";
        }
    }
}

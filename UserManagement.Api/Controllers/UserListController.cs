using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [Route("api/userlist")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class UserListController : ControllerBase
    {
        [HttpGet]
        [Route("getuser")]
        public async Task<IActionResult> Get()
        {
            var responseTime = "Response Time: " + DateTime.Now.ToString();
            var uerlist = await Task.FromResult(new string[] { "Virat", "Messi", "Ozil", "Lara", "MS Dhoni", responseTime });
            return Ok(uerlist);
        }
    }
}

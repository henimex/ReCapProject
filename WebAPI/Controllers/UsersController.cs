using Business.Abstract;
using Core.Entities.Concrete;
using Entites.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //This area will be managed by AuthController
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("get-by-id")]
        public IActionResult Get(int id)
        {
            var result = _userService.GetById(id);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("get-by-mail")]
        public IActionResult GetByMail(string email)
        {
            var result = _userService.GetUserByMail(email);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        //[HttpPost("add")]
        //public IActionResult Add(User user)
        //{
        //    var result = _userService.Add(user);
        //    if (result.Success) return Ok(result);

        //    return BadRequest(result);
        //}
    }
}
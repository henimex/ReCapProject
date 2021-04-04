using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entites.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCardsController : ControllerBase
    {
        private IUserCardService _userCardService;

        public UserCardsController(IUserCardService userCardService)
        {
            _userCardService = userCardService;
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var result = _userCardService.GetAll();
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("get-all-by-user-id")]
        public IActionResult GetAllByUserId(int id)
        {
            var result = _userCardService.GetAllByUserId(id);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("get-by-card-id")]
        public IActionResult Get(int id)
        {
            var result = _userCardService.GetByCardId(id);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(UserCard userCard)
        {
            var result = _userCardService.Add(userCard);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(UserCard userCard)
        {
            var result = _userCardService.Update(userCard);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(UserCard userCard)
        {
            var result = _userCardService.Delete(userCard);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }
    }
}

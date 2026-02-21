using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("role")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        UserRoleService service;
        public UserRoleController(UserRoleService service)
        {
            this.service = service;
        }
        [HttpGet("all")]
        public IActionResult All()
        {
            var data = this.service.GetAllRole();
            if (data.Count() < 1)
            {
                return NotFound(new
                {
                    message = "No roles found"
                });
            }
            else
            {
                return Ok(data);
            }
        }
        [HttpPost("create")]
        public IActionResult Create(RoleDTO role)
        {
            var data = this.service.CreateRole(role);
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                return BadRequest(new
                {
                    message = "Failed to create role"
                });
            }
        }
    }
}

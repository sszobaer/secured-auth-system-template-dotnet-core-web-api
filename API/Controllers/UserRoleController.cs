using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.Json;

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
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var data = this.service.GetRoleById(id);
            if (data == null)
            {
                return NotFound(new
                {
                    message = "No role found with the given id"
                });
            }
            else
            {
                return Ok(data);
            }
        }
        [HttpPost("create")]
        public IActionResult Create(CreateRoleDTO role)
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
        [HttpPut("{RoleId}")]
        public IActionResult Update([FromBody]CreateRoleDTO role, Guid RoleId)
        {
            var updateData = this.service.UpdateRole(role, RoleId);
            return Ok(updateData);
        }
    }
}

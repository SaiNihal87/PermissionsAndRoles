using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Permissions.Dtos;
using Permissions.Entities;
using Permissions.Repositories;

namespace Permissions.Controllers;

[ApiController]
[Microsoft.AspNetCore.Mvc.Route("api/role")]
public class RoleController : ControllerBase
{
    private readonly IRoleRepository _role;
    public RoleController(IRoleRepository role)
    {
        _role = role;
    }

    [HttpPost]
    
    public async Task<ActionResult> CreateRole([FromBody] RoleCreateDto roleCreateDto)
    {
        var toCreate = new Role{
            Name = roleCreateDto.Name,
            DisplayLabel = roleCreateDto.DisplayLabel,
            Status = roleCreateDto.Status,
            PermissionsIds = roleCreateDto.PermissionsIds
        };
        var createdRole = await _role.CreateRole(toCreate);
        return Ok(roleCreateDto);
    }
}
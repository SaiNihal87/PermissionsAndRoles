using Dapper;
using Microsoft.AspNetCore.Mvc;
using Permissions.Dtos;
using Permissions.Entities;

namespace Permissions.Repositories;

public interface IRoleRepository
{
    Task<List<Role>> GetRoles();
    Task<Role?> GetRoleById(long id);
    Task<Role> CreateRole(Role role);
    Task<bool> UpdateRole(Role role);
    Task<bool> DeleteRole(long id);
}

public class RoleRepository : BaseRepository, IRoleRepository
{
    public RoleRepository(IConfiguration configuration) : base(configuration)
    {
    }

    public async Task<Role> CreateRole(Role role)
    {
        using var connection = DbConnection;
        // await connection.OpenAsync();
        // using var transaction = await connection.BeginTransactionAsync();
        var query = @"INSERT INTO role (name, display_label, status)
                    VALUES (@Name, @DisplayLabel, @Status) RETURNING *";
        var roleCreated = await connection.QueryFirstAsync<Role>(query, role);

        var permissionIds = role.PermissionsIds;
          Console.WriteLine("permissionIds.Count()");
           Console.WriteLine(permissionIds.Count());
        var permissionQuery = @"INSERT INTO role_permission (role_id, permission_id)
                                    VALUES (@RoleId, @PermissionId)";
        foreach(var permission in permissionIds)
        {    
            var permissionId = permission;
            Console.WriteLine("permission");
            Console.WriteLine(permission);
            await connection.QueryAsync(permissionQuery,new{
                RoleId = roleCreated.Id,
                PermissionId = permissionId
            });
        }
        // transaction.Commit();
        return roleCreated;

    }

    public Task<bool> DeleteRole(long id)
    {
        throw new NotImplementedException();
    }

    public async Task<Role?> GetRoleById(long id)
    {
        var query = @"SELECT * FROM role WHERE id = @Id";
        using var connection = DbConnection;
        var role = await connection.QueryFirstOrDefaultAsync(query, new{Id = id});
        return role;
    }

    public Task<List<Role>> GetRoles()
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateRole(Role role)
    {
        throw new NotImplementedException();
    }
}
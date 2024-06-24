#nullable disable

using System.Text.Json.Serialization;

namespace Permissions.Entities;

public record RolePermission
{
    // [JsonPropertyName("role_id")]
    // public long RoleId { get; set; }

    [JsonPropertyName("permission_ids")]
    public int PermissionIds { get; set; }
}
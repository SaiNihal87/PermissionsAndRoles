#nullable disable
using System.Text.Json.Serialization;
using Permissions.Entities;

namespace Permissions.Dtos;

public class RoleDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("display_label")]
    public string DisplayLabel { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("permissions_ids")]
    public List<int> PermissionsIds { get; set; } = null!;
}

public class RoleCreateDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("display_label")]
    public string DisplayLabel { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("permissions_ids")]
    public List<int> PermissionsIds { get; set; } = null!;
}

public class RoleUpdateDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("display_label")]
    public string DisplayLabel { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("permissions_ids")]
    public List<int> PermissionsIds { get; set; } = null!;
}
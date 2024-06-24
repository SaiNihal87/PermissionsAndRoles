#nullable disable
using System.Text.Json.Serialization;

namespace Permissions.Entities;

public record Role
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
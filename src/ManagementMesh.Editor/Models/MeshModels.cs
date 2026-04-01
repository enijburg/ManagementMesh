namespace ManagementMesh.Editor.Models;

public enum ThreadAxis
{
    Vertical = 1,
    Horizontal = 2
}

public enum ThreadOrigin
{
    Start = 0,
    End = 1
}

public sealed class ManagementMeshDocument
{
    public string ProductOrService { get; set; } = "New Product";
    public string ValueObjective { get; set; } = string.Empty;
    public string GovernanceConstraints { get; set; } = string.Empty;
    public string ConsumerNeeds { get; set; } = string.Empty;

    public Dictionary<string, string> VerticalThreadColors { get; set; } = new();
    public Dictionary<string, string> HorizontalThreadColors { get; set; } = new();
    public Dictionary<string, int> VerticalThreadStops { get; set; } = new();
    public Dictionary<string, int> HorizontalThreadStops { get; set; } = new();
    public Dictionary<string, ThreadOrigin> VerticalThreadOrigins { get; set; } = new();
    public Dictionary<string, ThreadOrigin> HorizontalThreadOrigins { get; set; } = new();
}

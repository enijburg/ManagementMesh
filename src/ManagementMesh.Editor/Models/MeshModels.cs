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

    // Vertical threads: independent bars from the top (Start) and bottom (End)
    public Dictionary<string, string> VerticalStartColors { get; set; } = new();
    public Dictionary<string, int>    VerticalStartStops  { get; set; } = new();
    public Dictionary<string, string> VerticalEndColors   { get; set; } = new();
    public Dictionary<string, int>    VerticalEndStops    { get; set; } = new();

    // Horizontal threads: independent bars from the left (Start) and right (End)
    public Dictionary<string, string> HorizontalStartColors { get; set; } = new();
    public Dictionary<string, int>    HorizontalStartStops  { get; set; } = new();
    public Dictionary<string, string> HorizontalEndColors   { get; set; } = new();
    public Dictionary<string, int>    HorizontalEndStops    { get; set; } = new();
}

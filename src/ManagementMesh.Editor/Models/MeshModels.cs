namespace ManagementMesh.Editor.Models;

public enum FitLevel
{
    Gap = 0,
    Candidate = 1,
    Strong = 2
}

public sealed record MeshCell(string Practice, string Technology)
{
    public FitLevel Fit { get; set; } = FitLevel.Candidate;
    public string Note { get; set; } = string.Empty;
}

public sealed class ManagementMeshDocument
{
    public string ProductOrService { get; set; } = "New Product";
    public string ValueObjective { get; set; } = string.Empty;
    public string GovernanceConstraints { get; set; } = string.Empty;
    public string ConsumerNeeds { get; set; } = string.Empty;
    public Dictionary<string, bool> Resources { get; set; } = new();
    public Dictionary<string, bool> Environment { get; set; } = new();
    public Dictionary<string, Dictionary<string, MeshCell>> Matrix { get; set; } = new();
}

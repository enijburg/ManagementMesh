# ManagementMesh

A `.NET 10` Blazor WebAssembly starter that provides a **visual VeriSM management mesh editor**.

## What it includes

- A matrix editor for **Management Practices × Emerging Technologies** with gap/candidate/strong states.
- Pillar selectors for:
  - Resources
  - Environment
  - Management practices (matrix rows)
  - Emerging technologies (matrix columns)
- Stage readiness scoring across the VeriSM-oriented flow:
  - Define
  - Produce
  - Provide
  - Respond
- JSON export/import for collaborative design review and versioning.

## Project path

- `src/ManagementMesh.Editor` - standalone Blazor WebAssembly project targeting `net10.0`.

## Run locally

```bash
dotnet run --project src/ManagementMesh.Editor
```

> Note: The current execution environment used by the agent did not contain the .NET SDK, so runtime validation wasn't possible here.

## Design notes from VeriSM research

To support practical mesh creation, the UI emphasizes:

1. **Context-first capture** (value objective, governance constraints, consumer needs).
2. **Pillar coverage visibility** via explicit resource/environment toggles.
3. **Practice-to-technology fit mapping** to identify strong alignments and gaps.
4. **Lifecycle-oriented readiness** (Define/Produce/Provide/Respond) to keep the mesh value-focused.

These choices are aligned with publicly available VeriSM summaries and training descriptions.

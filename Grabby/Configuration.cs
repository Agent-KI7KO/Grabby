using ECommons.Configuration;

namespace Grabby;

public class Configuration
{
    public string WorkingDirectory { get; set; } = string.Empty;
    public bool DisableAutomaticRevert { get; set; }
    public bool AllowOutsideGpose { get; set; }
    public bool AllowOutsideGposeOwnedPets { get; set; }
    public bool UseLiveSnapshotData { get; set; }
    public bool UsePenumbraIpcResourcePaths { get; set; }
    public bool IncludeVisibleTempCollectionActors { get; set; }

    public bool IsValid()
    {
        return !string.IsNullOrEmpty(WorkingDirectory) && Directory.Exists(WorkingDirectory);
    }

    public void Save()
    {
        EzConfig.Save();
    }
}

namespace Grabby.Services.SnapshotManager;

public interface ISnapshotIndexService
{
    void RefreshSnapshotIndex();
    string? FindSnapshotPathForActor(ICharacter character);
}
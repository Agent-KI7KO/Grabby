namespace Grabby.Features.Packaging;

public static class ModMetadataBuilder
{
    public static ModMetadata BuildSnapshotMetadata(string snapshotName)
    {
        return new ModMetadata
        {
            Name = snapshotName,
            Author = "Grabby Export",
            Description = $"Exported from Grabby on {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss} UTC",
        };
    }
}


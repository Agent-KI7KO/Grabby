using Penumbra.UI.Classes;

namespace Grabby.Features.Pmp.ChangedItems;

public sealed record SnapshotChangedItem(
    string Key,
    string Name,
    string AdditionalData,
    int Count,
    ChangedItemIconFlag Category
);

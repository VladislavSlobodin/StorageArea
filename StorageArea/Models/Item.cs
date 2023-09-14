namespace StorageArea.Models;

public partial class Item
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Count { get; set; }

    public int ContainerId { get; set; }

    public int TypeId { get; set; }

    public double Volume { get; set; }

    public double Weight { get; set; }

    public virtual Container Container { get; set; } = null!;

    public virtual ItemType Type { get; set; } = null!;
}

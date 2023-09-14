using System;
using System.Collections.Generic;

namespace StorageArea.Models;

public partial class Container
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double MaxVolume { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}

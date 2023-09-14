using System;
using System.Collections.Generic;

namespace StorageArea.Models;

public partial class UserRole
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int AccessLevel { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}

using System;
using System.Collections.Generic;

namespace StorageArea.Models;

public partial class User
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public int HashedPassword { get; set; }

    public int RoleId { get; set; }

    public virtual UserRole Role { get; set; } = null!;
}

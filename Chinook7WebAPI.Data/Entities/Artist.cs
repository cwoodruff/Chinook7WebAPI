using System;
using System.Collections.Generic;

namespace Chinook7WebAPI.Data.Entities;

public partial class Artist
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Album> Albums { get; } = new List<Album>();
}

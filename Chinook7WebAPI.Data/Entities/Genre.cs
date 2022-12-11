using System;
using System.Collections.Generic;

namespace Chinook7WebAPI.Data.Entities;

public partial class Genre
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Track> Tracks { get; } = new List<Track>();
}

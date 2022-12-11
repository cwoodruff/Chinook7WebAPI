using System;
using System.Collections.Generic;

namespace Chinook7WebAPI.Data.Entities;

public partial class Album
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int ArtistId { get; set; }

    public virtual Artist Artist { get; set; } = null!;

    public virtual ICollection<Track> Tracks { get; } = new List<Track>();
}

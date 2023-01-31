using Chinook.Domain.Entities;
using Chinook.Domain.Extensions;
using Chinook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Chinook.Data.Repositories;

public class PlaylistRepository : BaseRepository<Playlist>, IPlaylistRepository
{
    public PlaylistRepository(ChinookContext context) : base(context)
    {
    }

    public void Dispose() => _context.Dispose();

    public async Task<PagedList<Playlist>> GetByTrackId(int id, int pageNumber, int pageSize) =>
        await PagedList<Playlist>.ToPagedListAsync(_context.Playlists.Where(c => c.Tracks!.Any(o => o.Id == id))
                .AsNoTrackingWithIdentityResolution(),
            pageNumber,
            pageSize);
}
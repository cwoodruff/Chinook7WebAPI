﻿
using Chinook.Domain.ApiModels;
using Chinook.Domain.Entities;
using Chinook.Domain.Extensions;
using Chinook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Chinook.Data.Repositories;

public class AlbumRepository : BaseRepository<Album>, IAlbumRepository, IDisposable
{
    public AlbumRepository(ChinookContext context) : base(context)
    {
    }

    public void Dispose() => _context.Dispose();

    public async Task<PagedList<Album>> GetByArtistId(int id, int pageNumber, int pageSize) =>
        await PagedList<Album>.ToPagedListAsync(_context.Albums.Where(a => a.ArtistId == id)
                .AsNoTrackingWithIdentityResolution(),
            pageNumber,
            pageSize);
}
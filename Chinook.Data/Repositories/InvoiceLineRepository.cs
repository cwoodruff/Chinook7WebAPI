using Chinook.Domain.Entities;
using Chinook.Domain.Extensions;
using Chinook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Chinook.Data.Repositories;

public class InvoiceLineRepository : BaseRepository<InvoiceLine>, IInvoiceLineRepository
{
    public InvoiceLineRepository(ChinookContext context) : base(context)
    {
    }

    public void Dispose() => _context.Dispose();

    public async Task<PagedList<InvoiceLine>> GetByInvoiceId(int id, int pageNumber, int pageSize) =>
        await PagedList<InvoiceLine>.ToPagedListAsync(_context.InvoiceLines.Where(a => a.InvoiceId == id)
                .AsNoTrackingWithIdentityResolution(),
            pageNumber,
            pageSize);

    public async Task<PagedList<InvoiceLine>> GetByTrackId(int id, int pageNumber, int pageSize) =>
        await PagedList<InvoiceLine>.ToPagedListAsync(_context.InvoiceLines.Where(a => a.TrackId == id)
                .AsNoTrackingWithIdentityResolution(),
            pageNumber,
            pageSize);
}
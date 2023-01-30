using Chinook.Domain.Entities;
using Chinook.Domain.Extensions;
using Chinook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Chinook.Data.Repositories;

public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(ChinookContext context) : base(context)
    {
    }

    public void Dispose() => _context.Dispose();

    public async Task<PagedList<Customer>> GetBySupportRepId(int id, int pageNumber, int pageSize) =>
        await PagedList<Customer>.ToPagedListAsync(_context.Customers.Where(a => a.SupportRepId == id)
            .AsNoTrackingWithIdentityResolution(),
        pageNumber,
        pageSize);
}

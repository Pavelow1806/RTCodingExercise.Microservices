
using Catalog.API.Configuration;
using Catalog.Domain.Requests;

namespace Catalog.API.Services.DataService
{
    public class DataService : IDataService
    {
        private readonly ApplicationDbContext _context;
        public DataService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Plate>> GetPlates(PlatesRequest request, CancellationToken cancellationToken)
        {
            return await _context.Plates
                .OrderByDescending(plate => plate.SalePrice)
                .Skip((request.PageNumber * DataConfiguration.ItemsPerPage) - DataConfiguration.ItemsPerPage)
                .Take(DataConfiguration.ItemsPerPage)
                .Select(plate => new Plate
                {
                    Id = plate.Id,
                    Registration = plate.Registration,
                    PurchasePrice = plate.PurchasePrice,
                    SalePrice = plate.SalePrice,
                    Letters = plate.Letters,
                    Numbers = plate.Numbers,
                    MarkupPrice = plate.SalePrice * DataConfiguration.MarkupMultiplier,
                })
                .ToListAsync(cancellationToken);
        }
    }
}

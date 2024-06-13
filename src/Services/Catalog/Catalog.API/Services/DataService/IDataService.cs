using Catalog.Domain.Requests;

namespace Catalog.API.Services.DataService
{
    public interface IDataService
    {
        Task<List<Plate>> GetPlates(PlatesRequest request, CancellationToken cancellationToken);
    }
}

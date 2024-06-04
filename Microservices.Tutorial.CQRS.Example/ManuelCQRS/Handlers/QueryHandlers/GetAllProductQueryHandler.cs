using Microservices.Tutorial.CQRS.Example.DbContexts;
using Microservices.Tutorial.CQRS.Example.ManuelCQRS.Queries.Requests;
using Microservices.Tutorial.CQRS.Example.ManuelCQRS.Queries.Responses;

namespace Microservices.Tutorial.CQRS.Example.ManuelCQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler
    {
        public List<GetAllProductQueryResponse> GetAllProduct(GetAllProductQueryRequest request)
        {
            return ApplicationDbContext.Products.Select(x => new GetAllProductQueryResponse
            {
                Id = x.Id,
                Name = x.Name,
                Quantity = x.Quantity,
                Price = x.Price,
                CreateTime = x.CreateTime
            }).ToList();
        }
    }
}

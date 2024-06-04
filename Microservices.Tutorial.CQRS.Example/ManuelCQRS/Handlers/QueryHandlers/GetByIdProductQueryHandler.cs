using Microservices.Tutorial.CQRS.Example.DbContexts;
using Microservices.Tutorial.CQRS.Example.ManuelCQRS.Queries.Requests;
using Microservices.Tutorial.CQRS.Example.ManuelCQRS.Queries.Responses;

namespace Microservices.Tutorial.CQRS.Example.ManuelCQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler
    {
        public GetByIdProductQueryResponse GetByIdProduct(GetByIdProductQueryRequest request)
        {
            var product = ApplicationDbContext.Products.FirstOrDefault(x => x.Id == request.ProductId);
            return new GetByIdProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Quantity = product.Quantity,
                Price = product.Price,
                CreateTime = product.CreateTime
            };
        }
    }
}

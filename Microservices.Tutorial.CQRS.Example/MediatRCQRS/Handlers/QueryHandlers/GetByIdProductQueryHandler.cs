using MediatR;
using Microservices.Tutorial.CQRS.Example.DbContexts;
using Microservices.Tutorial.CQRS.Example.MediatRCQRS.Queries.Requests;
using Microservices.Tutorial.CQRS.Example.MediatRCQRS.Queries.Responses;

namespace Microservices.Tutorial.CQRS.Example.MediatRCQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest,GetByIdProductQueryResponse>
    {
        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
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

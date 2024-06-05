using MediatR;
using Microservices.Tutorial.CQRS.Example.DbContexts;
using Microservices.Tutorial.CQRS.Example.MediatRCQRS.Queries.Requests;
using Microservices.Tutorial.CQRS.Example.MediatRCQRS.Queries.Responses;

namespace Microservices.Tutorial.CQRS.Example.MediatRCQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {
        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
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

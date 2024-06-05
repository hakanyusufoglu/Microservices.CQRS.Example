using MediatR;
using Microservices.Tutorial.CQRS.Example.MediatRCQRS.Queries.Responses;

namespace Microservices.Tutorial.CQRS.Example.MediatRCQRS.Queries.Requests
{
    public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
    {
        public Guid ProductId { get; set; }
    }
}

using MediatR;
using Microservices.Tutorial.CQRS.Example.MediatRCQRS.Commands.Responses;

namespace Microservices.Tutorial.CQRS.Example.MediatRCQRS.Commands.Requests
{
    public class DeleteProductCommandRequest : IRequest<DeleteProductCommandResponse>
    {
        public Guid ProductId { get; set; }
    }
}

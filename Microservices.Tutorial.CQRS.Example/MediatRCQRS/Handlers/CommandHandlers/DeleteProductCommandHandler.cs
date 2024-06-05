using MediatR;
using Microservices.Tutorial.CQRS.Example.DbContexts;
using Microservices.Tutorial.CQRS.Example.MediatRCQRS.Commands.Requests;
using Microservices.Tutorial.CQRS.Example.MediatRCQRS.Commands.Responses;

namespace Microservices.Tutorial.CQRS.Example.MediatRCQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            //Product silinecek
            //Product silindikten sonra response dönülecek
            var product = ApplicationDbContext.Products.FirstOrDefault(x => x.Id == request.ProductId);
            if (product == null)
            {
                return new DeleteProductCommandResponse
                {
                    IsSuccess = false
                };
            }

            ApplicationDbContext.Products.Remove(product);
            return new DeleteProductCommandResponse
            {
                IsSuccess = true
            };
        }
    }
}

using MediatR;
using Microservices.Tutorial.CQRS.Example.DbContexts;
using Microservices.Tutorial.CQRS.Example.MediatRCQRS.Commands.Requests;
using Microservices.Tutorial.CQRS.Example.MediatRCQRS.Commands.Responses;
using Microservices.Tutorial.CQRS.Example.Models;

namespace Microservices.Tutorial.CQRS.Example.MediatRCQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {

            //Product oluşturulacak
            //Product oluşturulduktan sonra response dönülecek
            var id = Guid.NewGuid();
            ApplicationDbContext.Products.Add(new Product
            {
                Id = id,
                Name = request.Name,
                Price = request.Price,
                Quantity = request.Quantity,
                CreateTime = DateTime.Now
            });

            return new CreateProductCommandResponse
            {
                ProductId = id,
                IsSuccess = true
            };
        }
    }
}

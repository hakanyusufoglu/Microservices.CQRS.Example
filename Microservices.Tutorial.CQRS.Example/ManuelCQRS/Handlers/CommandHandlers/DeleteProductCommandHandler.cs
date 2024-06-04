using Microservices.Tutorial.CQRS.Example.DbContexts;
using Microservices.Tutorial.CQRS.Example.ManuelCQRS.Commands.Requests;
using Microservices.Tutorial.CQRS.Example.ManuelCQRS.Commands.Responses;

namespace Microservices.Tutorial.CQRS.Example.ManuelCQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler
    {
        public DeleteProductCommandResponse DeleteProduct(DeleteProductCommandRequest request)
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

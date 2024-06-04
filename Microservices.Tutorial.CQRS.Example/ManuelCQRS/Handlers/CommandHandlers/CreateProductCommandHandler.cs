using Microservices.Tutorial.CQRS.Example.DbContexts;
using Microservices.Tutorial.CQRS.Example.ManuelCQRS.Commands.Requests;
using Microservices.Tutorial.CQRS.Example.ManuelCQRS.Commands.Responses;
using Microservices.Tutorial.CQRS.Example.Models;

namespace Microservices.Tutorial.CQRS.Example.ManuelCQRS.Handlers.CommandHandlers
{
    //Producvt oluşturmak için kullanılacak command handler
    public class CreateProductCommandHandler
    {
       public CreateProductCommandResponse CreateProduct(CreateProductCommandRequest request)
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
                ProductId=id,
                IsSuccess = true
            };
        }
    }
}

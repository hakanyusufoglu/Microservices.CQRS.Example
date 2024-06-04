namespace Microservices.Tutorial.CQRS.Example.ManuelCQRS.Commands.Responses
{
    //CreateProductCommandRequest requestine karşılık gelen response
    public class CreateProductCommandResponse
    {
        public Guid ProductId { get; set; }
        public bool IsSuccess { get; set; } 

    }
}

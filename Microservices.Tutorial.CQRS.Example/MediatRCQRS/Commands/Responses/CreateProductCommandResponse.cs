﻿namespace Microservices.Tutorial.CQRS.Example.MediatRCQRS.Commands.Responses
{
    public class CreateProductCommandResponse
    {
        public Guid ProductId { get; set; }
        public bool IsSuccess { get; set; }
    }
}

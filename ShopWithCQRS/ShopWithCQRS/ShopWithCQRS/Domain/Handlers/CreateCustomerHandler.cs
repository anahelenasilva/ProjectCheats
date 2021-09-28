using MediatR;
using ShopWithCQRS.Domain.Command.Requests;
using ShopWithCQRS.Domain.Command.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ShopWithCQRS.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        { 
            //verifica se o cliente já está cadastrado
            //valida os dados
            //insere o cliente
            //envia email de boas vindas

            var response = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Ana Helena",
                Email = "ana@helena.com",
                CreatedAt = DateTime.Now
            };

            return Task.FromResult(response);
        }
    }
}

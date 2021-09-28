using MediatR;
using ShopWithCQRS.Domain.Command.Responses;

namespace ShopWithCQRS.Domain.Command.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email {  get; set; }
    }
}

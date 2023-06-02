using Shop.Domain.Commands.Responses;
using Shop.Domain.Commands.Requests;


namespace Shop.Domain.Handlers;


public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest command);
    }
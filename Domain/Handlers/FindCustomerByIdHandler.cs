using MediatR;
using Shop.Domain.Queries.Requests;
using Shop.Domain.Queries.Responses;


namespace Shop.Domain.Handlers;


public class FindCustomerByIdHandler : IRequestHandler<FindCustomerByIdRequest, FindCustomerByIdResponse>
    {
        //ICustomerRepository _repository;

        // public FindCustomerByIdHandler(ICustomerRepository repository)
        // {
        //     _repository = repository;
        // }
        public Task<FindCustomerByIdResponse> Handle(FindCustomerByIdRequest request, CancellationToken cancellationToken)
        {
            // TODO: Lógica de leitura se houver
            var response = new FindCustomerByIdResponse();
            response.Email = "teste@teste.com";
            response.Name = "teste";
            response.Id = Guid.NewGuid();

            // Retorna o resultado
            return Task.FromResult(response);
        }
    }
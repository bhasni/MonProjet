using System.Collections.Generic;
using System.Threading.Tasks;
using Exercice.Models;
using Exercice.Repositories;

namespace Exercice.Services.Implementations
{
    public class BankAccountService : IBankAccountService
    {
        private readonly IBankAccountRepository _bankAccountRepository;

        public BankAccountService(IBankAccountRepository bankAccountRepository)
        {
            _bankAccountRepository = bankAccountRepository;
        }

        /// <inheritdoc />
        public async Task<long> CreateOperation(long clientId, decimal amount, string operationType)
        {
            //TODO Verify if the client exist
            // Here we have to call a method in the repository which verify if the client exist in the database.

            // Calling the repository to create the operation
            var operationId = await _bankAccountRepository.CreateOperation(clientId, amount, operationType);

            return operationId;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<Operation>> CheckOperations(long clientId)
        {
            //TODO Verify if the client exist
            // Here we have to call a method in the repository which verify if the client exist in the database.

            // Calling the repository to retrieve the operations list
            var clientOperations = await _bankAccountRepository.CheckOperations(clientId);

            return clientOperations;
        }
    }
}

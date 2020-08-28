using System.Collections.Generic;
using System.Threading.Tasks;
using Exercice.Models;
using Exercice.Services;

namespace Exercice.Controllers
{
    /// <summary>
    /// This class contains the methods to manage the bank accounts
    /// </summary>
    public class BankAccountController
    {
        private readonly IBankAccountService _bankAccountService;

        public BankAccountController(IBankAccountService bankAccountService)
        {
            _bankAccountService = bankAccountService;
        }

        public async Task<long> CreateOperation(long clientId, decimal amount, string operationType)
        {
            // Call the service
            var operationId = await _bankAccountService.CreateOperation(clientId, amount, operationType);

            return operationId;
        }
        
        public async Task<IEnumerable<Operation>> CheckOperations(long clientId)
        {

            // Calling the service to retrieve the operations list
            var clientOperations = await _bankAccountService.CheckOperations(clientId);

            return clientOperations;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Exercice.Models;

namespace Exercice.Repositories.Implementations
{
    public class BankAccountRepository : IBankAccountRepository
    {
        /// <inheritdoc />
        public async Task<long> CreateOperation(long clientId, decimal amount, string operationType)
        {
            // TODO Create a sql request to update the account balance by adding or retrieving the account balance according to the operationType

            // TODO Create a sql request to create a new operation
            var creationDate = DateTime.Now;



            var createdOperationId = 1;
            return createdOperationId;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<Operation>> CheckOperations(long clientId)
        {
            //TODO Create a sql request to get from the operation table the list of the operations of the given client

            // I have to create a list to return as an example
            var clientOperations = new List<Operation>()
            {
                new Operation()
                {
                    Date = new DateTime(2020, 6, 15),
                    Amount = 1000,
                    Type = "Deposit"
                },
                new Operation()
                {
                    Date = new DateTime(2020, 6, 30),
                    Amount = 750,
                    Type = "Withdrawal"
                }
            };

            return clientOperations;
        }
    }
}

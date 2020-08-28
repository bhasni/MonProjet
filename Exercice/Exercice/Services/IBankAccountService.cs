using Exercice.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exercice.Services
{
    /// <summary>
    /// Bank Account Service Interface
    /// </summary>
    public interface IBankAccountService
    {
        /// <summary>
        /// This method allows to Deposit money on the client account
        /// </summary>
        /// <param name="clientId">Technical Id of the client on which we will deposit the amount of money</param>
        /// <param name="amount">Value of the amount to deposit on the account</param>
        /// <param name="operationType">Type of the operation (Deposit/ Withdrawal)</param>
        /// <returns>Id of the created operation</returns>
        Task<long> CreateOperation(long clientId, decimal amount, string operationType);

        /// <summary>
        /// This method allows to check the operations on a given client account
        /// </summary>
        /// <param name="clientId">Technical Id of the client</param>
        /// <returns>List of client account operations</returns>
        Task<IEnumerable<Operation>> CheckOperations(long clientId);
    }
}

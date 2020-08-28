using System;

namespace Exercice.Models
{
    /// <summary>
    /// Operation Model
    /// </summary>
    public class Operation
    {
        /// <summary>
        /// Operation date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Operation type (Deposit, Withdrawal)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Value of the amount related to the operation
        /// </summary>
        public decimal Amount { get; set; }
    }
}

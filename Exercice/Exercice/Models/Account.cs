using System;
using System.Collections.Generic;

namespace Exercice.Models
{
    /// <summary>
    /// Account Model
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Technical Id of the account
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Creation date of the account
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Balance of the account
        /// </summary>
        public Balance Balance { get; set; }

        /// <summary>
        /// A flag indicating if the account is active
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// List of operations related to the account
        /// </summary>
        public IEnumerable<Operation> Operations { get; set; }
    }
}

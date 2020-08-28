namespace Exercice.Models
{
    /// <summary>
    /// Client Model
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Technical Id of the client
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Client's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Address of the client
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Telephone number of the client
        /// </summary>
        public string TelNumber { get; set; }

        /// <summary>
        /// Email of the client
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Client's Account
        /// </summary>
        public Account Account { get; set; }
    }
}

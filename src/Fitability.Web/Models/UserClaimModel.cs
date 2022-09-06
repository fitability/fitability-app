namespace Fitability.Web.Models
{
    /// <summary>
    /// This represents the model entity for authenticated user's claim details.
    /// </summary>
    public class UserClaimModel
    {
        /// <summary>
        /// Gets or sets the issuer.
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Gets or sets the original issuer.
        /// </summary>
        public string OriginalIssuer { get; set; }

        /// <summary>
        /// Gets or sets the claim type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the claim value.
        /// </summary>
        public string Value { get; set; }
    }
}
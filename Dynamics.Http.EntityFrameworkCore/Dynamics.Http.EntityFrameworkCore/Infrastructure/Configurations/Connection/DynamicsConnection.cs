﻿namespace Dynamics.Http.EntityFrameworkCore.Infrastructure.Configurations.Connection
{
    /// <summary>
    /// This class contains the configuration required to connect to a Dynamics Environment.
    /// </summary>
    public class DynamicsConnection
    {
        /// <summary>
        /// Get and set the tenant unique identifier.
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// Get and set the client unique identifier.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Get and set the client secret.
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// Get and set the grant type.
        /// </summary>
        public string GrantType { get; set; }

        /// <summary>
        /// Get and set the authority url.
        /// </summary>
        public string AuthorityUrl { get; set; }

        /// <summary>
        /// Get and set the resource.
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// Get and set the version.
        /// </summary>
        public string Version { get; set; }
    }
}

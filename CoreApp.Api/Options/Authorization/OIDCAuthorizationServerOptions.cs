﻿namespace CoreApp.Api.Options.Authorization
{
    public class OIDCAuthorizationServerOptions
    {
        public Client[] Clients { get; set; }

        public CertificateOptions SigningCertificate { get; set; }

        public int AccessTokenExpiration { get; set; }

        public string Audience { get; set; }
    }
}

﻿namespace Xero.Api
{
    public interface IXeroApiSettings
    {
        string BaseUrl { get; }

        string CallbackUrl { get; }

        string ConsumerKey { get; }

        string ConsumerSecret { get; }

        string SigningCertificatePath { get; }

        string SigningCertificatePassword { get; }

        string AppType { get; }

        bool IsPartnerApp { get; }
    }
}

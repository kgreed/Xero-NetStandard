using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Xero.Api
{
    public class XeroApiSettings : IXeroApiSettings
    {
        public IConfigurationSection ApiSettings { get; set; }

        public XeroApiSettings(string settingspath)
        {
           // var realPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, settingspath);
            var realPath = settingspath;
            var builder = new ConfigurationBuilder()
                .AddJsonFile(realPath)
                .Build();

            ApiSettings = builder.GetSection("XeroApi");
        }
        public XeroApiSettings() : this("appsettings.json")
        {
        }

        public string BaseUrl => ApiSettings["BaseUrl"];

        public string CallbackUrl => ApiSettings["CallbackUrl"];

        public string ConsumerKey => ApiSettings["ConsumerKey"];

        public string ConsumerSecret => ApiSettings["ConsumerSecret"];

        public string SigningCertificatePath => ApiSettings["SigningCertPath"];

        public string SigningCertificatePassword => ApiSettings["SigningCertPassword"];

        public string AppType => ApiSettings["AppType"];

        public bool IsPartnerApp => AppType?.Equals("partner", StringComparison.OrdinalIgnoreCase) ?? false;
    }
}

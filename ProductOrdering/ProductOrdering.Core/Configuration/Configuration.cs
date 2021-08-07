using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrdering.Core.Configuration
{
    public interface ISettings
    {
    }
    public class AppConfig : ISettings
    {
        public string AppEmail { get; set; }
        public double ReviewsWeight { get; set; }
        public double LikesWeight { get; set; }
        public double SearchWeight { get; set; }
        public double DaysSincePostWeight { get; set; }
        public string CLOUDINARY_CLOUD_NAME { get; set; }
        public string CLOUDINARY_API_KEY { get; set; }
        public string CLOUDINARY_API_SECRET { get; set; }
        public string CLOUDINARY_API_ENVIRONMENT_VARIABLE { get; set; }
    }
    public class SmtpConfig : ISettings
    {
        public bool EnableSSl { get; set; }
        public int Port { get; set; }
        public string Server { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string From { get; set; }
        public string SenderDisplayName { get; set; }
        public bool UseDefaultCredentials { get; set; }
        //
        public string Host { get; set; }
        public X509CertificateCollection ClientCertificates { get; set; }
        public ICredentialsByHost Credentials { get; set; }
        public SmtpDeliveryFormat DeliveryFormat { get; set; }
        public SmtpDeliveryMethod DeliveryMethod { get; set; }
        public string PickupDirectoryLocation { get; set; }
        public ServicePoint ServicePoint { get; }
        public string TargetName { get; set; }
        public int Timeout { get; set; }
    }
}

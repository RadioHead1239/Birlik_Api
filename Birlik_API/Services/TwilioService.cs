using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Microsoft.Extensions.Configuration;

namespace Birlik_Api.Services
{
    public class TwilioService
    {
        private readonly string _accountSid;
        private readonly string _authToken;
        private readonly string _fromNumber;
        public TwilioService(IConfiguration configuration)
        {
            _accountSid = configuration["Twilio:AccountSid"] ?? throw new ArgumentNullException("AccountSid no configurado");
            var apiKey = configuration["Twilio:ApiKey"] ?? throw new ArgumentNullException("ApiKey no configurado");
            var apiSecret = configuration["Twilio:ApiSecret"] ?? throw new ArgumentNullException("ApiSecret no configurado");
            _fromNumber = configuration["Twilio:FromNumber"] ?? throw new ArgumentNullException("FromNumber no configurado");

            TwilioClient.Init(apiKey, apiSecret, _accountSid);
        }


        /// <summary>
        /// Envía un SMS a un solo número.
        /// </summary>
        public async Task<string> SendSmsAsync(string toNumber, string message)
        {
            var msg = await MessageResource.CreateAsync(
                to: new PhoneNumber(toNumber),
                from: new PhoneNumber(_fromNumber),
                body: message
            );

            return msg.Sid;
        }

        /// <summary>
        /// Envía un SMS a múltiples números de destino.
        /// </summary>
        public async Task<List<string>> SendBulkSmsAsync(IEnumerable<string> toNumbers, string message)
        {
            var sids = new List<string>();

            foreach (var number in toNumbers)
            {
                var msg = await MessageResource.CreateAsync(
                    to: new PhoneNumber(number),
                    from: new PhoneNumber(_fromNumber),
                    body: message
                );
                sids.Add(msg.Sid);
            }

            return sids;
        }

        /// <summary>
        /// Realiza una llamada telefónica a un número.
        /// </summary>
        public async Task<string> MakeCallAsync(string toNumber, string voiceUrl)
        {
            var call = await CallResource.CreateAsync(
                to: new PhoneNumber(toNumber),
                from: new PhoneNumber(_fromNumber),
                url: new Uri(voiceUrl)
            );

            return call.Sid;
        }

        /// <summary>
        /// Realiza llamadas a múltiples números de destino.
        /// </summary>
        public async Task<List<string>> MakeBulkCallsAsync(IEnumerable<string> toNumbers, string voiceUrl)
        {
            var sids = new List<string>();

            foreach (var number in toNumbers)
            {
                var call = await CallResource.CreateAsync(
                    to: new PhoneNumber(number),
                    from: new PhoneNumber(_fromNumber),
                    url: new Uri(voiceUrl)
                );
                sids.Add(call.Sid);
            }

            return sids;
        }
    }
}

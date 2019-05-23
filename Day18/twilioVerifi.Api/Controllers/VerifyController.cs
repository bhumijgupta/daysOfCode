using System;
using Microsoft.AspNetCore.Mvc;
using Twilio;
using Twilio.Rest.Verify.V2.Service;

namespace twilioVerifi.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class VerifyController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {

            const string accountSid = "";
            const string authToken = "";

            TwilioClient.Init(accountSid, authToken);

            var verification = VerificationResource.Create(
                to: "+919003355434",
                channel: "sms",
                pathServiceSid: "VA0e9bff2c70d29ee16ded98a8db8f1baf"
            );

            Console.WriteLine(verification.ToString());

            return "Reached verify route\nMessage sent";
        }

        [HttpGet("{vercode}")]
        public string Get(string vercode)
        {
            var verificationCheck = VerificationCheckResource.Create(
                to: "+919003355434",
                code: vercode,
                pathServiceSid: "VA0e9bff2c70d29ee16ded98a8db8f1baf"
            );

            return verificationCheck.Status;
        }

    }
}
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace twilio_test
{
    class Program
    {
        static void Main(string[] args)
        {
            const string accountSid = "AC9b97a21a9b848df6ffcf59bd1251329b";
            const string authToken = "66531f1a236946301a3c2ba56a1efeb5";

            TwilioClient.Init(accountSid, authToken);
            var message = MessageResource.Create(
                body: "Hello world again",
                from: new Twilio.Types.PhoneNumber("+14232440002"),
                statusCallback: new Uri("https://postb.in/1558432292919-6646893438883"),
                to: new Twilio.Types.PhoneNumber("+919003355434")
            );

            Console.WriteLine(message.Status);
            if (message.ErrorCode == null)
            {
                Console.WriteLine("Successful");
            }
            else
            {
                Console.WriteLine($"Failed with ${message.ErrorMessage}");
            }
        }
    }
}

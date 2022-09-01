using PokeDex.Contracts.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace PokeDex.Functions
{
    public class TimerFunction
    {
        private readonly IEmailService _emailService;
        private readonly ILogger _logger;

        public TimerFunction(
            IEmailService emailService,
            ILoggerFactory loggerFactory)
        {
            _emailService = emailService;
            _logger = loggerFactory.CreateLogger<TimerFunction>();
        }

        [FunctionName("BookRentingReminder")]
        public async Task Run([TimerTrigger("* * * * *")] TimerInfo myTimer)
        {
            try
            {
                await _emailService.Send(
                    "ana.grskovic56@gmail.com",
                    "Pokemon",
                    $"Email sending works!");
            }
            catch (Exception ex)
            {
                _logger.LogError($"C# Timer trigger function executed with error: {ex.Message}");
                throw;
            }
        }
    }
}

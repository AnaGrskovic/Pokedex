using PokeDex.Contracts.Models;
using PokeDex.Contracts.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace PokeDex.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailSettings _settings;
        public EmailService(IOptions<EmailSettings> settings)
        {
            _settings = settings.Value;
        }

        public async Task Send(string to, string subject, string body)
        {
            var sendGridClient = new SendGridClient(_settings.Key);

            var message = new SendGridMessage
            {
                From = new EmailAddress(_settings.From),
                Subject = subject,
                HtmlContent = body,
            };

            message.AddTo(new EmailAddress(to));

            var response = await sendGridClient.SendEmailAsync(message);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Body.ReadAsStringAsync();
                throw new Exception($"Unable to send an email! {error}");
            }
        }
    }
}

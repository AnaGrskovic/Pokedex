namespace PokeDex.Contracts.Models
{
    public class EmailSettings
    {
        public string Key { get; set; }
        public string From { get; set; }

        public EmailSettings(
           string key,
           string from)
        {
            Key = key;
            From = from;
        }

        public EmailSettings()
        {
        }
    }
}

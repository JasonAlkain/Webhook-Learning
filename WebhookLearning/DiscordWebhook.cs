using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebhookLearning
{
    class DiscordWebhook
    {
        private static NameValueCollection WebhookValues = new NameValueCollection();
        private WebClient discordClient;
        private string WebhookAdress { get; set; }
        public bool TTS { get; set; }
        public string UserName { get; set; }
        public string Message { get; set; }
        public string AvatarURL { get; set; }
        public DiscordWebhook(string WebhookURL)
        {
            discordClient = new WebClient();
            WebhookAdress = WebhookURL;
        }
        public void Send()
        {
            try
            {
                WebhookValues.Set("tts", TTS.ToString());
                WebhookValues.Set("username", UserName);
                WebhookValues.Set("avatar_url", AvatarURL);
                WebhookValues.Set("content", Message);
                discordClient.UploadValues(WebhookAdress, WebhookValues);
                discordClient.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :  " + e.ToString());
            }
        }

    }
}

using System;
using System.Collections.Specialized;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using Discord;
using Discord.Webhook;
using Discord.API.Rest;
using Discord.Rest;
using Discord.Net;
using Discord.Logging;

namespace WebhookLearning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string webhookURL = "https://discordapp.com/api/webhooks/{Token}/{link}";
        Window newWin = new Window();

        

        public MainWindow()
        {
            InitializeComponent();

            WebhookURL.Text = webhookURL;
        }

        private void SendMessage(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateURL(object sender, RoutedEventArgs e)
        {

        }

        private void SetURL(object sender, RoutedEventArgs e)
        {
            Handler handler = new Handler();
            handler.webhookURL = WebhookURL.Text;




        }

        
    }

}

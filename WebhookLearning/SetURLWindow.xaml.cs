using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WebhookLearning
{
    /// <summary>
    /// Interaction logic for SetURLWindow.xaml
    /// </summary>
    public partial class SetURLWindow : Window
    {
        public SetURLWindow()
        {
            InitializeComponent();
        }

        private void UpdateWebhookURL(object sender, RoutedEventArgs e)
        {
            mWin.WebhookURL = WebhookURL.Text;
        }
    }
}

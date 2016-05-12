using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Diagnostics;

namespace EncryptionForFunUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Encrypt_EncryptButtonClick_Click(object sender, RoutedEventArgs e)
        {

        }

        private void decrypt_DecryptButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void keyGen_GenerateKeys_Click(object sender, RoutedEventArgs e)
        {

        }

        private void keyGen_SavePrivateKey_Click(object sender, RoutedEventArgs e)
        {

        }

        private void keyGen_SavePublicKey_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

    }
}

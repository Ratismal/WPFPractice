using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Diagnostics;
using Microsoft.Win32;
using System;
using System.IO;

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

        private string LoadFile(string fileDialogTitle)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();       
            openFileDialog.Multiselect= false;
            openFileDialog.Title = fileDialogTitle;
            openFileDialog.Filter = "Text files|*.txt";
            openFileDialog.FilterIndex = 1;

            Nullable<bool> result = openFileDialog.ShowDialog();

            if (result != true)
            {
                return null;
            }

            return File.ReadAllText(openFileDialog.FileName);
        }

        private void encrypt_LoadPlainText_Click(object sender, RoutedEventArgs e)
        {
            encrypt_plain_text.Text = LoadFile("Open Plain Text");
        }

        private void encrypt_LoadPublicKey_Click(object sender, RoutedEventArgs e)
        {
            encrypt_public_key.Text = LoadFile("Open Public Key");
        }

        private void decrypt_LoadPrivateKey_Click(object sender, RoutedEventArgs e)
        {
            decrypt_private_key.Text = LoadFile("Open Private Key");
        }

        private void decrypt_LoadCypherText_Click(object sender, RoutedEventArgs e)
        {
            decrypt_cypher.Text = LoadFile("Open Cypher Text");
        }

        private void SaveTextToFile(string fileText, string fileName, string fileDialogTitle) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = fileDialogTitle;
            saveFileDialog.ShowDialog();
            saveFileDialog.FileName = fileName;
            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.OpenFile()))
                {
                    sw.Write(fileText);
                }
            }
        }
    }
}

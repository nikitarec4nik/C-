using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using задание_1.InterFaces;
using задание_1.models;
using задание_1.Share;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Xml;

namespace задание_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IXmlWorker _worker;
        private readonly ILogger _logger;
        public bool IsFileOpened = false;
        private string _xmlFilePath;
        public MainWindow()
        {
            InitializeComponent();
            _logger = LoggerFactory.Create(builder => builder.SetMinimumLevel
                            (LogLevel.Information)).CreateLogger<MainWindow>();
            _worker = new XmlDocumentWorker(_logger);
        }

        private void buttonFindCountryByName_Click(object sender, RoutedEventArgs e)
        {
            var market = _worker.FindBy(textBoxCountryName.Text);
            PrintCountry(market);
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            PrintCountries(_worker.GetAll());
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDeleteCountryName.Text) || !string.IsNullOrWhiteSpace(textBoxDeleteCountryName.Text))
            {
                _worker.Delete(textBoxDeleteCountryName.Text);
                PrintCountries(_worker.GetAll());
            }
        }
        private void PrintCountry(Market markett)
        {
            textBlockXMLFileContent.Text = "=======Market========" + Environment.NewLine;
            textBlockXMLFileContent.Text += markett?.ToString() ?? "Parking not found";
        }
        private void PrintCountries(List<Market> market)
        {
            textBlockXMLFileContent.Text = "========Tovar=======" + Environment.NewLine;
            foreach (var markett in market)
            {
                textBlockXMLFileContent.Text += markett.ToString();
            }
        }
        private void textBoxCountryName_TextChanged(object sender)
        {
            if (string.IsNullOrEmpty(textBoxCountryName.Text))
            {
                PrintCountries(_worker.GetAll());
            }
        }

        private void buttonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.FullName;
            dialog.DefaultExt = ".xml";
            dialog.Filter = "Xml documents(.xml)|*.xml";
            var result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                _xmlFilePath = dialog.FileName;
                textBlockXMLPathFile.Text = _xmlFilePath;
                _worker.Load(_xmlFilePath);
                PrintCountries(_worker.GetAll());
            }
        }
    }
}

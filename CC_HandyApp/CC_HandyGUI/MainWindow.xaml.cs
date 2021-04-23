namespace CC_HandyGUI
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Windows;
    using CC_HandyApp;
    using CC_HandyClass;
    using Microsoft.Win32;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HandyList list = new HandyList();

        public MainWindow()
        {
            InitializeComponent();
            textBox_hersteller.Focus();
            listView_handy.ItemsSource = this.list;
        }

        private void addHandy_Click(object sender, RoutedEventArgs e)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var rnd = new Random();
            
            Handy h = new Handy();
            h.Producer = textBox_hersteller.Text;
            h.Model = textBox_model.Text;
            h.Price = Convert.ToDouble(textBox_preis.Text);
            h.SerialNumber = new string(chars.Select(c => chars[rnd.Next(chars.Length)]).Take(8).ToArray());
            list.Add(h);

            listView_handy.Items.Refresh();

            textBox_hersteller.Text = string.Empty;
            textBox_model.Text = string.Empty;
            textBox_preis.Text = string.Empty;
            textBox_hersteller.Focus();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Handy File (.bin)|*.bin; | HandyFile (.xml)|*.xml; ";
            if (saveFileDialog.ShowDialog() == true)
            {
                string pathName = saveFileDialog.FileName;
                FileInfo fInfo = new FileInfo(pathName);
                string extension = fInfo.Extension;
                if (extension == ".bin")
                {
                    list.ConnectSerializer(new Binary<HandyList>());
                    list.Serialize(pathName);
                }
                if (extension == ".xml")
                {
                    list.ConnectSerializer(new Xml<HandyList>());
                    list.Serialize(pathName);
                }
            }
        }

        private void loadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog loadFileDialog = new OpenFileDialog();
            loadFileDialog.Filter = "Handy File|*.bin;*.xml;";
            loadFileDialog.FilterIndex = 0;
            if (loadFileDialog.ShowDialog() == true)
            {
                string pathName = loadFileDialog.FileName;
                FileInfo fInfo = new FileInfo(pathName);
                string extension = fInfo.Extension;
                if (extension == ".bin")
                {
                    list.ConnectSerializer(new Binary<HandyList>());
                    list.Deserialize(pathName);
                }
                if (extension == ".xml")
                {
                    list.ConnectSerializer(new Xml<HandyList>());
                    list.Deserialize(pathName);
                }
            }
            listView_handy.Items.Refresh();
        }

        private void restButton_Click(object sender, RoutedEventArgs e)
        {
            this.list.Clear();
            listView_handy.Items.Refresh();
        }
    }
}
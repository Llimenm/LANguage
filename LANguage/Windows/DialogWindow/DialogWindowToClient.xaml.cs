using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace LANguage.DialogWindow
{
    /// <summary>
    /// Логика взаимодействия для DialogWindowToClient.xaml
    /// </summary>
    public partial class DialogWindowToClient : Window
    {
        public string pathToPhoto = null;
        LanguageDB db = new LanguageDB();
        public DialogWindowToClient()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            if (pathToPhoto != null)
            {
                try
                {
                    photo.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(pathToPhoto);
                }
                catch
                {

                }
            }
            switch (genderBox.Text)
            {
                case "1":
                    genderBox.Text = "Мужской";
                    break;

                case "2":
                    genderBox.Text = "Женский";
                    break;
            }
        }
    }
}

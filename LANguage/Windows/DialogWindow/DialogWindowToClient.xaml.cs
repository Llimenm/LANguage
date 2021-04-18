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
        public string pathToPhoto = null; // Путь до фото пользователя
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
        /// <summary>
        /// Событие, при котором выставляется изображение и пол пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

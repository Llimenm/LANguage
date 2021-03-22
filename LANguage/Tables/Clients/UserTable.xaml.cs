using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using LANguage.Windows;
using LANguage.DialogWindow;
namespace LANguage.Tables
{
    public partial class UserTable : Page
    {
        LanguageDB db = new LanguageDB();
        Client selectedItem = null;
        DialogWindowToClient dialogWindow;
        public UserTable()
        {
            InitializeComponent();
            db.Client.Load();
            listBoxTableClient.ItemsSource = db.Client.Local.ToBindingList();


        }

        private void createTupleButton_Click(object sender, RoutedEventArgs e) // Кнопка добавления клиента
        {
            dialogWindow = new DialogWindowToClient();
            Client itemToAdd = new Client();
            dialogWindow.windowGrid.DataContext = itemToAdd;
            if (dialogWindow.ShowDialog() == true)
            {
                itemToAdd.ID = db.Client.OrderByDescending(o => o.ID).FirstOrDefault().ID + 1;
                itemToAdd.RegistrationDate = DateTime.Today;
                db.Client.Add(itemToAdd);
                try
                {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (DbEntityValidationResult validationError in ex.EntityValidationErrors)
                    {
                        MessageBox.Show("Object: " + validationError.Entry.Entity.ToString() + "\n");
                        foreach (DbValidationError err in validationError.ValidationErrors)
                        {
                            MessageBox.Show(err.ErrorMessage);
                        }
                    }
                }
            }

        }

        private void deleteTupleButton_Click(object sender, RoutedEventArgs e) // Кнопка удаления клиента
        {
            if (MessageBox.Show("Вы хотите удалить запись?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes && selectedItem != null)
            {
                Client itemForRemove = db.Client.Where(o => o.ID == selectedItem.ID).FirstOrDefault();
                try
                {
                    db.Client.Remove(itemForRemove);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Запись не может быть удалена, т.к. используется в других таблицах", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
                

        }

        public void listBoxTableClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedItem = listBoxTableClient.SelectedItem as Client;
        } // Выбор нужного клиента для манипуляций

        private void changeTupleButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedItem != null)
            {
                dialogWindow = new DialogWindowToClient();
                dialogWindow.windowGrid.DataContext = db.Client.Where(o => o.ID == selectedItem.ID).FirstOrDefault();
                dialogWindow.pathToPhoto = @"..\..\Tables\Clients\" + db.Client.Where(o => o.ID == selectedItem.ID).FirstOrDefault().PhotoPath;
                if (dialogWindow.ShowDialog() == true)
                {
                    db.SaveChanges();
                }
            }
        }//Кнопка измениния данных выбранного клиента

        private void openVisitsTableButton_Click(object sender, RoutedEventArgs e) 
        {
            if (selectedItem != null)
            {
                ClientsServices visits = new ClientsServices();
                db.ClientService.Load();
                visits.listBoxTableClientsServices.ItemsSource = db.ClientService.Local.ToBindingList().Where(o => o.ClientID == selectedItem.ID);
                visits.ShowDialog();
            }

        } // Кнопка открытия посещений выбранного клиента
    }
}

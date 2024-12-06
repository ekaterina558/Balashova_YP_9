using Balashova_YP_9.ApplicationData;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Balashova_YP_9.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageClient.xaml
    /// </summary>
    public partial class PageClient : Page
    {
        private RegistraciaClienta _currentRegistraciaClienta = new RegistraciaClienta();
        public PageClient(RegistraciaClienta selectedRegistraciaClienta)
        {
            InitializeComponent();
            if (selectedRegistraciaClienta != null)
                _currentRegistraciaClienta = selectedRegistraciaClienta;

            DataContext = _currentRegistraciaClienta;
            
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder err0rs = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentRegistraciaClienta.Surname))
                err0rs.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_currentRegistraciaClienta.Name))
                err0rs.AppendLine("Укажите имя");
            if (string.IsNullOrWhiteSpace(_currentRegistraciaClienta.Otchestvo))
                err0rs.AppendLine("Укажите отчество");
            if (string.IsNullOrWhiteSpace(_currentRegistraciaClienta.NomerTelefona))
                err0rs.AppendLine("Укажите номер телефона");

            if (err0rs.Length > 0)
            {
                MessageBox.Show(err0rs.ToString());
                return;
            }
            //добавление
            if (_currentRegistraciaClienta.ID == 0)
                ObshestvoEntities.GetContext().RegistraciaClienta.Add(_currentRegistraciaClienta);

            //обработка вариант выпада/записи данных
            try
            {
                ObshestvoEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

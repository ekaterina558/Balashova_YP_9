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
    /// Логика взаимодействия для NaznachenieZapisi.xaml
    /// </summary>
    public partial class NaznachenieZapisi : Page
    {
        private ZapisNaPriem _currentZapisNaPriem = new ZapisNaPriem();
        public NaznachenieZapisi(ZapisNaPriem selectedzapisNaPriem)
        {
            InitializeComponent();
            if (selectedzapisNaPriem != null)
                _currentZapisNaPriem = selectedzapisNaPriem;

            DataContext = _currentZapisNaPriem;
            
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder err0rs = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentZapisNaPriem.Surname))
                err0rs.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_currentZapisNaPriem.Name))
                err0rs.AppendLine("Укажите имя");
            if (string.IsNullOrWhiteSpace(_currentZapisNaPriem.Otchestvo))
                err0rs.AppendLine("Укажите отчество");
           

            if (err0rs.Length > 0)
            {
                MessageBox.Show(err0rs.ToString());
                return;
            }
            //добавление
            if (_currentZapisNaPriem.ID == 0)
                ObshestvoEntities.GetContext().ZapisNaPriem.Add(_currentZapisNaPriem);

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

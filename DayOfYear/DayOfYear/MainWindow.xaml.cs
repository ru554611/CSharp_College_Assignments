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

namespace DayOfYear
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //создаем новый экземпляр класса
        public TheDayOfYear doy = new TheDayOfYear();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            //строковый массив, в котором будет храниться распарсенная дата
            //первый элемент массива = год в формате YYYY
            //второй элемент массива = месяц в формате MM
            //третий элемент массива = месяц в формате DD
            string[] YMD = new string[3];
            
            //в строку х будем передавать значение введенное пользователем
            string x;
            x = DTPicker.Text;

            //разделяем строку х на год, месяц и день используя в качестве разделителя -
            for (int i = 0; i < 3; i++)
            {
                YMD=x.Split(new Char[] { '-' });
            }

            //пробуем конвертировать элементы массива из строковых в целые, если удалось запускаем метод расчета количества дней
            //если не удалось - выдаем ошибку
            //в случае отработки метода присваиваем возвращаемый результат в лэйбл
            try
            {
                lblNumOfdays.Content = doy.CalculateDayOfYear(Convert.ToInt32(YMD[0]), Convert.ToInt32(YMD[1]), Convert.ToInt32(YMD[2]));
            }
            catch
            {
                MessageBox.Show("Ops!");
            }
        }


    }
}

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lib_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Lib_8_class lib_8_Class = new Lib_8_class();
        int[] mas;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Input(object sender, RoutedEventArgs e)
        {
            
            
            string result = "";
            int get_number;
            try
            {

                if (int.TryParse(input_number.Text, out get_number))
                {
                    mas = lib_8_Class.Create(get_number);
                    for(int i = 0; i < mas.Length; i++)
                    {
                        result = result + mas[i].ToString() + " ";
                    }
                    outputMas.Text = result;
                    outputMax.Text = lib_8_Class.MaxNumber(mas).ToString();
                }
                else
                {
                    MessageBox.Show("Введено неправильное значение");
                }
            }
            catch (Exception ex) { MessageBox.Show($"Произошла ошибка:\nВозможно вы ввели отрицаиельное число.\nКод ошибки:\n{ex}"); }
        }

       

        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Тимофеева Виктория \r\nГруппа ИСП-31 \r\nВариант №8 \r\nЗадание: Найти максимум из n целых случайных чисел X, распределенных в диапазоне от 0 \r\nдо n. Вывести на экран на одной строке сгенерированные числа, на другой строке \r\nрезультат.");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
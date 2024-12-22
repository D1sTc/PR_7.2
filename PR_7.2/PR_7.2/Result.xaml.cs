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
using System.Windows.Shapes;

namespace PR_7._2
{
    /// <summary>
    /// Логика взаимодействия для Result.xaml
    /// </summary>
    public partial class Result : Window
    {
        public Result(double areaResult, double middleLineResult, double diagonalResult)
        {
            InitializeComponent();

            // Отображаем результаты на соответствующих текстовых блоках
            AreaTextBlock.Text = $"Площадь: {areaResult}";
            MiddleLineTextBlock.Text = $"Средняя линия: {middleLineResult}";
            DiagonalTextBlock.Text = $"Диагональ: {diagonalResult}";
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Закрывает окно результатов
        }
    }
}

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
    /// Логика взаимодействия для Input.xaml
    /// </summary>
    public partial class Input : Window
    {
        public double AreaResult { get; private set; }
        public double MiddleLineResult { get; private set; }
        public double DiagonalResult { get; private set; }

        public Input()
        {
            InitializeComponent();
        }

        private void Area_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Area_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void MiddleLine_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void MiddleLine_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void Diagonal_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Diagonal_Unchecked(object sender, RoutedEventArgs e)
        {

        }
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(SideA.Text, out double sideA) &&
                double.TryParse(SideB.Text, out double sideB) &&
                double.TryParse(SideC.Text, out double sideC) &&
                double.TryParse(H.Text, out double height))
            {
                if (Area.IsChecked == true)
                {
                    AreaResult = ((sideA + sideB) / 2) * height;
                }

                if (MiddleLine.IsChecked == true)
                {
                    MiddleLineResult = (sideA + sideB) / 2;
                }

                if (Diagonal.IsChecked == true)
                {
                    DiagonalResult = Math.Sqrt(sideA * sideA + height * height);
                    DiagonalResult = Math.Round(DiagonalResult, 3); // Округление до 3 знаков после ,
                }

                Result resultWindow = new Result(AreaResult, MiddleLineResult, DiagonalResult);
                resultWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные значения.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

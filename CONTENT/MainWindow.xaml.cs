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

namespace CONTENT
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateMoney = Convert.ToDouble(rate.Text);
            double sumMoney = Convert.ToDouble(sum.Text);
            double resDouble = rateMoney * sumMoney;
            resSum.Text = resDouble.ToString();
        }
        

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
          
            double rateMoney = Convert.ToDouble(rate1.Text);
            double sumMoney = Convert.ToDouble(sum1.Text);
            double resDouble = rateMoney * sumMoney;
            resSum1.Text = resDouble.ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double rateMoney = Convert.ToDouble(rate2.Text);
            double sumMoney = Convert.ToDouble(sum2.Text);
            double resDouble = rateMoney * sumMoney;
            resSum2.Text = resDouble.ToString();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateMoney = Convert.ToDouble(rate3.Text);
            double sumMoney = Convert.ToDouble(sum3.Text);
            double resDouble = rateMoney * sumMoney;
            resSum3.Text = resDouble.ToString();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            double length = Convert.ToDouble(ini.Text);
            double resDouble = length * 0.0254;
            cnvrt.Text = resDouble.ToString();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            double length = Convert.ToDouble(ini1.Text);
            double resDouble = length * 0.3048;
            cnvrt1.Text = resDouble.ToString();
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            double length = Convert.ToDouble(ini2.Text);
            double resDouble = length * 1609;
            cnvrt2.Text = resDouble.ToString();
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            double length = Convert.ToDouble(ini3.Text);
            double resDouble = length * 1067;
            cnvrt3.Text = resDouble.ToString();
        }
    }
}

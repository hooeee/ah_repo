using InnerExceptionApp.Good;
using InnerExceptionApp.Models;
using InnerExceptionApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace InnerExceptionApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Member> datas { get; set; } = new ObservableCollection<Member> { };
        private GoodService GoodService = new GoodService();
        private AntiService AntiService = new AntiService();

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.GoodService.함수("123", 1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.AntiService.함수("123", 1);
        }
    }
}

using Microsoft.Practices.ServiceLocation;
using SimpleListBoxUsageDemonstration.ViewModel;
using System.Windows;

namespace SimpleListBoxUsageDemonstration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var mainViewModel = ServiceLocator.Current.GetInstance<MainViewModel>();
            mainViewModel.SampleList.Add("test");
        }
    }
}
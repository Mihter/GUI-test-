using GUI.ViewModel;
using System.Windows;


namespace GUI.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindowChess.xaml
    /// </summary>
    public partial class MainWindowChess : Window
    {

        public MainWindowChess()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}

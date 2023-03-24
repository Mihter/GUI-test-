using GUI.ViewModel;
using System.Windows.Controls;


namespace GUI.View
{
    /// <summary>
    /// Логика взаимодействия для PageBoardChess.xaml
    /// </summary>
    public partial class PageBoardChess : Page
    {

        public PageBoardChess()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

    }
}

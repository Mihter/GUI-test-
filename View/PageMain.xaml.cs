using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;




namespace GUI.View
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// Это самая первая страница с которой и будет начинатся игра.
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }


        private void ButtonMainChess(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageMainChess());
        }

        private void ButtonMainPacMan(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageMainPacMan());
        }
        private void ButtonMainSnake(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageMainSnake());
        }
    }
}

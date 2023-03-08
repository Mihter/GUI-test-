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

namespace GUI
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

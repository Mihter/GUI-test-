using System.Windows;
using GUI.View;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// MainFrame рамка с которой и слеплена первая страница PageMain.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new PageMain();
        }
    }
}

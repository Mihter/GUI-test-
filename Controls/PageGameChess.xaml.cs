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

namespace GUI.Controls
{
    /// <summary>
    /// Логика взаимодействия для PageGameChess.xaml
    /// </summary>
    public partial class PageGameChess : UserControl
    {
        public static readonly DependencyProperty PieceProperty = DependencyProperty.Register("Piece", typeof(State), typeof(PageGameChess));

        public State Piece
        {
            get => (State)GetValue(PieceProperty);
            set => SetValue(PieceProperty, value);
        }

        public PageGameChess()
        {
            InitializeComponent();
        }
    }
}

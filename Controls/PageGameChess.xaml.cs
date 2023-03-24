using System.Windows;
using System.Windows.Controls;

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

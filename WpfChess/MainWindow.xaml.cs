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

namespace WpfChess
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            chessBoard.Rows = 8;
            chessBoard.Columns = 8;

            for(int i = 0; i< 32; i++)
            {
                Rectangle r1 = new Rectangle();
                r1.Fill = Brushes.Black;
                chessBoard.Children.Add(r1);
            }

        }
    }
}

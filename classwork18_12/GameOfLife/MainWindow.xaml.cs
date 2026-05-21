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
using System.Windows.Threading;
using GameOfLife.Core;
namespace GameOfLife
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Game _game;
        private Border[,] _cells;
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            _game = new Game();
            _cells = new Border[_game.Rows, _game.Cols];
            CreateGameGrid();
            UpdateVisuals();

            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(200)
            };
            timer.Tick += TimerTick;
        }
        private void TimerTick(object sender, EventArgs e)
        {
            _game.NextGeneration();
            UpdateVisuals() ;
        }
        private void CreateGameGrid()
        {
            gameGrid.Children.Clear();
            gameGrid.Rows = _game.Rows;
            gameGrid.Columns = _game.Cols;
            for (int i = 0; i< _game.Rows; i++)
            {
                for (int j = 0;  j < _game.Cols; j++)
                {
                    Border border = new Border
                    {
                        Background = Brushes.Gray,
                        BorderBrush = Brushes.DarkGray,
                        BorderThickness = new Thickness(0.3)

                    };

                    int iCaptured = i , jCaptured = j;
                    border.MouseLeftButtonDown += (sender, e) => CellClick(iCaptured, jCaptured);
                    _cells[i,j] = border;
                    gameGrid.Children.Add(border);
                }
            }
        }
        private void UpdateVisuals()
        {
            for (int i = 0; i < _game.Rows; i++)
            {
                for (int j = 0; j < _game.Cols; j++)
                {
                    if (_game.Grid[i,j])
                    {
                        _cells[i,j].Background = Brushes.Yellow;
                    }
                    else
                    {
                        _cells[i, j].Background = Brushes.Black;
                    }
                }
            }
        }
        private void CellClick(int row, int col)
        {
            if (timer.IsEnabled) return;
            _game.ToggleCell(row, col);
            UpdateVisuals();
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void StartClick(object sender, RoutedEventArgs e) 
        {
            timer.Start();
        }
        private void StopClick(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }
        private void ResetClick(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            _game.Clear();
            UpdateVisuals() ;
        }
    }
}

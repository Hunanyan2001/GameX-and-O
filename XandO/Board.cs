using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XandO
{
    public class Board
    {
        private int Rows;
        private int Columns;
        private Label[,] BlockControls;
        public Board(Grid BaseGrid)
        {
            Rows = BaseGrid.RowDefinitions.Count;
            Columns = BaseGrid.ColumnDefinitions.Count;
            BlockControls = new Label[Rows, Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {

                    BlockControls[i, j] = new Label();
                    BlockControls[i, j].Background = Brushes.Red;
                    BlockControls[i, j].BorderBrush = Brushes.Green;
                    BlockControls[i, j].BorderThickness = new Thickness(1, 1, 1, 1);
                    Grid.SetColumn(BlockControls[i, j], j);
                    Grid.SetRow(BlockControls[i, j], i);
                    BaseGrid.Children.Add(BlockControls[i, j]);
                }
            }
        }
    }
}

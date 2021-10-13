using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenhouseMeter
{
    public static class MapController
    {
        /// <summary>
        /// Принимает указатель на map и двумерную матрицу, которую необходимо отобразить с указанеием x, y положения каждой точки
        /// плоскости относительно базы
        /// </summary>
        /// <param name="map">dgv указатель на карту</param>
        /// <param name="values">двумерный массив дынных с указанем положения каждой точки</param>
        public static void UpdateMap(DataGridView map, double[,] values)
        {
            try
            {
                map.Rows.Clear();
                int height = values.GetLength(0);
                int width = values.GetLength(1);

                int rowHeight = (map.Size.Height - 40) / (height - 1);
                int columnWidth = (map.Size.Width - 45) / (width - 1);

                var (max, min) = Get2DMaxMinValue(values);

                map.ColumnCount = width - 1;
                for (int c = 0; c < width - 1; c++)
                {
                    map.Columns[c].Width = columnWidth;
                    map.Columns[c].SortMode = DataGridViewColumnSortMode.NotSortable;
                    map.Columns[c].HeaderText = values[0, c + 1].ToString();
                }

                for (int r = 0; r < height - 1; r++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(map);
                    row.HeaderCell.Value = values[r + 1, 0].ToString();
                    for (int c = 0; c < width - 1; c++)
                    {
                        row.Cells[c].Value = values[r + 1, c + 1];
                        row.Cells[c].Style.BackColor = GetMapColor(values[r + 1, c + 1], min, max);
                    }

                    row.Height = rowHeight;

                    map.Rows.Add(row);
                }
            }
            catch (Exception) { }
        }

        private static (double, double) Get2DMaxMinValue(double[,] values)
        {
            double max = double.MinValue;
            double min = double.MaxValue;

            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    var value = values[i, j];

                    max = Math.Max(value, max);

                    min = Math.Min(value, min);
                }
            }

            return (max, min);
        }

        private static Color GetMapColor(double value, double min, double max)
        {
            Color firstColour = Color.DarkRed;
            Color secondColour = Color.LightBlue;

            int rOffset = firstColour.R;
            int gOffset = firstColour.G;
            int bOffset = firstColour.B;

            int deltaR = Math.Abs(firstColour.R - secondColour.R);
            int deltaG = Math.Abs(firstColour.G - secondColour.G);
            int deltaB = Math.Abs(firstColour.B - secondColour.B);

            double val = (value - min) / (max - min);
            int r = rOffset + Convert.ToByte(deltaR * (1 - val));
            int g = gOffset + Convert.ToByte(deltaG * (1 - val));
            int b = bOffset + Convert.ToByte(deltaB * (1 - val));

            return Color.FromArgb(255, r, g, b);
        }
    }
}

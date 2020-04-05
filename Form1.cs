

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace labFigures
{
    public partial class Canvas : Form
    {
        public Figure figures;
        public Bitmap bmp;

        //Массив цветов для того, чтобы не использовать switch case
        Color[] colors = new Color[5];
        
        public Canvas()
        {
            InitializeComponent();
            figures = new Figure();
            colors[0] = Color.Red;
            colors[1] = Color.Black;
            colors[2] = Color.Blue;
            colors[3] = Color.Green;
            colors[4] = Color.Yellow;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            figures.list.Clear();
            if (bmp != null)
            {
                bmp.Dispose();
                bmp = null;
            }
            picture.Image = null;
        }

        private void DrawBtn_Click(object sender, EventArgs e)
        {
            if (figures.list.Count == -1)
            {
                MessageBox.Show("Список пуст");
            }
            else
            {
                try
                {
                    if (bmp == null)
                        bmp = new Bitmap(picture.Width, picture.Height);

                    int err = figures.Draw(bmp);
                    if (err == 0)
                        MessageBox.Show("Ошибка");
                    picture.Image = bmp;
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            try
            {
                int x, y;
                x = Convert.ToInt32(x1Box.Text);
                y = Convert.ToInt32(y1Box.Text);
                // Генерирование исключения на случай, если цвет не выбран
                if (comboBoxColor.SelectedIndex == -1)
                    throw new IndexOutOfRangeException();
                figures.list.Add(new Point(x, y, colors[comboBoxColor.SelectedIndex]));
                MessageBox.Show("Фигура добавлена");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void BtnLine_Click(object sender, EventArgs e)
        {
            try
            {
                int x1, y1, x2, y2;
                x1 = Convert.ToInt32(x1Box.Text);
                y1 = Convert.ToInt32(y1Box.Text);
                x2 = Convert.ToInt32(x2Box.Text);
                y2 = Convert.ToInt32(y2Box.Text);
                // Генерирование исключения на случай, если цвет не выбран
                if (comboBoxColor.SelectedIndex == -1)
                    throw new IndexOutOfRangeException();
                figures.list.Add(new Line(x1, y1, x2, y2, colors[comboBoxColor.SelectedIndex]));
                MessageBox.Show("Фигура добавлена");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void BtnSquare_Click(object sender, EventArgs e)
        {
            try
            {
                int x1, y1, len;
                x1 = Convert.ToInt32(x1Box.Text);
                y1 = Convert.ToInt32(y1Box.Text);
                len = Convert.ToInt32(lenBox.Text);
                // Генерирование исключения на случай, если цвет не выбран
                if (comboBoxColor.SelectedIndex == -1)
                    throw new IndexOutOfRangeException();
                figures.list.Add(new Square(x1, y1, len, colors[comboBoxColor.SelectedIndex]));
                MessageBox.Show("Фигура добавлена");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void BtnRect_Click(object sender, EventArgs e)
        {
            try
            {
                int x1, y1, x2, y2;
                x1 = Convert.ToInt32(x1Box.Text);
                y1 = Convert.ToInt32(y1Box.Text);
                x2 = Convert.ToInt32(x2Box.Text);
                y2 = Convert.ToInt32(y2Box.Text);
                // Генерирование исключения на случай, если цвет не выбран
                if (comboBoxColor.SelectedIndex == -1)
                    throw new IndexOutOfRangeException();
                figures.list.Add(new Rect(x1, y1, x2, y2, colors[comboBoxColor.SelectedIndex]));
                MessageBox.Show("Фигура добавлена");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void BtnCircle_Click(object sender, EventArgs e)
        {
            try
            {
                int x1, y1, r;
                x1 = Convert.ToInt32(x1Box.Text);
                y1 = Convert.ToInt32(y1Box.Text);
                r = Convert.ToInt32(radBox.Text);
                // Генерирование исключения на случай, если цвет не выбран
                if (comboBoxColor.SelectedIndex == -1)
                    throw new IndexOutOfRangeException();
                figures.list.Add(new Circle(x1, y1, r, colors[comboBoxColor.SelectedIndex]));
                MessageBox.Show("Фигура добавлена");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void BtnEllipse_Click(object sender, EventArgs e)
        {
            try
            {
                int x1, y1, a, b;
                x1 = Convert.ToInt32(x1Box.Text);
                y1 = Convert.ToInt32(y1Box.Text);
                a = Convert.ToInt32(radBox.Text);
                b = Convert.ToInt32(rad2Box.Text);
                // Генерирование исключения на случай, если цвет не выбран
                if (comboBoxColor.SelectedIndex == -1)
                    throw new IndexOutOfRangeException();
                figures.list.Add(new Ellipse(x1, y1, a, b, colors[comboBoxColor.SelectedIndex]));
                MessageBox.Show("Фигура добавлена");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

    }
}

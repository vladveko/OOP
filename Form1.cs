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
using ShapeClass;

namespace labFigures
{
    public partial class Canvas : Form
    {
        public Figure figures;
        public Bitmap bmp;

        // Массив цветов для того, чтобы не использовать switch case
        Color[] colors = new Color[5];

        // Буферные переменные для предварительной отрисовки
        int x1Val, y1Val, x2Val, y2Val;

        // Переменная статуса отрисовки
        bool draw = false;

        // Список полных названий доступных фигур
        List<Type> Data = new List<Type>();

        // Тип фигуры, которую в данный момент рисуем
        Type currClassType;
        
        public Canvas()
        {
            InitializeComponent();

            figures = new Figure();

            colors[0] = System.Drawing.Color.Red;
            colors[1] = System.Drawing.Color.Black;
            colors[2] = System.Drawing.Color.Blue;
            colors[3] = System.Drawing.Color.Green;
            colors[4] = System.Drawing.Color.Yellow;

            // Устанавливаем фильтры для диалоговых окон
            openDialog.Filter = "DAT Files (*.dat)|*.dat|Dll Files (*.dll)|*.dll";
            openDialog.FilterIndex = 0;
            openDialog.DefaultExt = "dat";

            saveDialog.Filter = "DAT Files (*.dat)|*.dat";
            saveDialog.FilterIndex = 0;
            saveDialog.DefaultExt = "dat";
            //

            // Создаем список доступных фигур
            List <Type> classes = new List<Type>();
            classes = ClassEnumenator.GetClasses<Shape>(Assembly.GetExecutingAssembly());

            foreach(Type type in classes)
            {
                // И добавляем их в комбобокс
                FiguresComboBox.Items.Add(type.Name);
                Data.Add(type);
            }

            picture.BackColor = System.Drawing.Color.White;
        }


        private void Picture_MouseUp(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                // Фиксируем конечные координаты второй точки
                x2Val = e.X;
                y2Val = e.Y;

                draw = false;

                // Создаем объект класса
                Shape obj = (Shape)Activator.CreateInstance(currClassType, new object[] {x1Val, y1Val, x2Val, y2Val, colors[Color.SelectedIndex], Fill.Checked});
                // Добавляем фигуру в список 
                figures.list.Add(obj);

                picture.Invalidate();
            }
        }

        private void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                x2Val = e.X;
                y2Val = e.Y;

                picture.Invalidate();
            }
            
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.Cancel)
                return;
            
            // получаем выбранный файл
            string filename = openDialog.FileName;

            // Загружаем список фигур из файла
            List<Shape> newshapes = FileManager.UploadFile(filename);
            // Добавляем загруженный список к уже существующему
            figures.list.AddRange(newshapes);

            picture.Invalidate();
        }

        private void BtnLibrary_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string filename = openDialog.FileName;
            try
            {
                // Достаем классы из dll
                List<Type> classes = ClassEnumenator.GetClasses<Shape>(Assembly.LoadFile(filename));

                foreach (Type type in classes)
                {
                    // И добавляем их в комбобокс
                    FiguresComboBox.Items.Add(type.Name);
                    Data.Add(type);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveDialog.FileName;

            FileManager.SaveFile(figures.list, filename);
        }


        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (!draw)
            {
                int figureIndex = FiguresComboBox.SelectedIndex;
                if (figureIndex != -1 && Color.SelectedIndex != -1)
                {
                    currClassType = Data[figureIndex];

                    x1Val = e.X;
                    y1Val = e.Y;
                    draw = true;
                }
            }
        }

        private void Picture_Paint(object sender, PaintEventArgs e)
        {
            figures.Draw(e.Graphics);

            if (currClassType != null)
            {
                // Получаем метод предварительной отрисовки
                MethodInfo method = currClassType.GetMethod("Preview");

                // И вызываем его 
                method.Invoke(null, new object[] { new PointF(x1Val, y1Val), new PointF(x2Val, y2Val), e.Graphics, colors[Color.SelectedIndex], Fill.Checked});    
            }
        }
    }
}

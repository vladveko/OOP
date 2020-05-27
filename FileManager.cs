using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Reflection;
using ShapeClass;

namespace labFigures
{
    public static class FileManager
    {
        public static void SaveFile(List<Shape> list, string FileName) 
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, list);
                }

                MessageBox.Show("File saved.");
            }
            catch
            {
                MessageBox.Show("Error occurred.");
            }
        }

        public static List<Shape> UploadFile(string FileName)
        {
            List<Shape> shapes = new List<Shape>();

            //try
            //{
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
                {
                    shapes = (List<Shape>)formatter.Deserialize(fs);
                }

                MessageBox.Show("File uploaded.");
            //}
            //catch
            //{
            //    MessageBox.Show("Error occurred.");
            //}

            return shapes;
        }
    }
}

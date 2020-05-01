using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace labFigures
{
    public static class ClassEnumenator
    {
        // Метод для определения классов, к-рые наследуются от Shape
        // Это и есть классы доступных фигур
        public static List<Type> GetClasses<T>(Assembly asm) where T : class
        {
            List<Type> classes = new List<Type>();
            foreach (Type type in asm.GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T))))
            {
                classes.Add(type);
            }

            return classes;
        }
    }
}

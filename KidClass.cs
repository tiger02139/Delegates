using System;

namespace Delegates
{
    public class KidClass<T> where T : struct
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public KidClass()
        {

        }

        public KidClass(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public string strTypeParameterType
        {
            get { return typeof(T).ToString(); }
        }

        public T CreateInstanceOfParameterType()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }

        public void PrintKidInfo()
        {
            Console.WriteLine("Kid info: Name: {0}, Age: {1}", Name, Age);
        }

        public void PrintAllInfo()
        {
            Console.WriteLine($"Kid info: Name: {Name}, Age: {Age}");
            Console.WriteLine($"Type info: Type: {strTypeParameterType}");
        }
    }
}

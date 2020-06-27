using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название вашего продукта: ");
            string _Name = Console.ReadLine();
            Console.WriteLine("Название продукта: " + _Name);
            HeirClass heirClass = new HeirClass();
            Console.WriteLine("Срок годности: " + heirClass._Age(1) + " мес.");
            Console.WriteLine("Тип продукта: " + heirClass._Type());
            Console.WriteLine("Класс продукта: " + heirClass._Class());
            Console.ReadLine();
        }
    }
    class ClassButterfly
    {
        #region Поля и инкапсуляция
        public string _Name;    //имя
        public string _Type;    //тип
        public string _Class;   //класс
        public byte _Age;       //возраст
        #region инкапсуция
        public string Type
        {
            get; private set;
        }
        public string Class
        {
            get; private set;
        }
        public byte Age
        {
            get; private set;
        }
        public string Name
        {
            get; private set;
        }
        #endregion
        #endregion
        #region Перегруженные конструкторы
        ClassButterfly() { }
        public ClassButterfly(string _Type, string _Class)
        {
            this._Type = _Type;
            this._Class = _Class;
        }
        public ClassButterfly(byte _Age)
        {
            this._Age = _Age;
        }
        #endregion
        #region Статичные и виртуальные методы
        public static string TypeMetod()
        {
            return "Рожь";
        }
        public static string ClassMetod()
        {
            return "Зерновые";
        }
        public virtual byte AgeMetod()
        {
            return 1;
        }
        #endregion
    }
    #region Реализация интерфейса
    class HeirClass : IObject
    {
        public string _Type()
        {
            return "Рожь";
        }
        public string _Class()
        {
            return "Зерновые";
        }
        public byte _Age(byte age)
        {
            return age;
        }
    }
    #endregion

    #region Интерфейс
    public interface IObject
    {
        string _Type();
        string _Class();
        byte _Age(byte age);
    }
    #endregion
}
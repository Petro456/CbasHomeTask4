using System;

namespace CbasHomeTask4
{
  public abstract  class  AbstractHandler
    {
        public abstract void Open();

        public abstract void Create();

        public abstract void Chenge();

        public abstract void Save();
        
    }

    class XMLHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Change XML");
        }

        public override void Create()
        {
            Console.WriteLine("Create XML");
        }

        public override void Open()
        {
            Console.WriteLine("Open XML");
        }

        public override void Save()
        {
            Console.WriteLine("Save XML"); ;
        }
    }
    class TXTHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Change TXT");
        }

        public override void Create()
        {
            Console.WriteLine("Create TXT");
        }

        public override void Open()
        {
            Console.WriteLine("Open TXT");
        }

        public override void Save()
        {
            Console.WriteLine("Save TXT"); ;
        }
    }
    class DOCHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Change DOC");
        }

        public override void Create()
        {
            Console.WriteLine("Create DOC");
        }

        public override void Open()
        {
            Console.WriteLine("Open DOC");
        }

        public override void Save()
        {
            Console.WriteLine("Save DOC"); ;
        }
    }
    internal class Program
    {
        /*Задание 2 

        Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: Создайте класс AbstractHandler.
        В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). Создать производные классы XMLHandler, 
        TXTHandler, DOCHandler от базового класса AbstractHandler. Написать программу, которая будет выполнять определение документа 
        и для каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа. */

        static void Main(string[] args)
        {
            String format;

            AbstractHandler abstractHandler=new TXTHandler();

            Console.WriteLine("Введіть формат тексту");
            format= Console.ReadLine();

            if (format == "DOC")
            {
                AbstractHandler abstractHandler3 = new DOCHandler();
                abstractHandler3.Open();
                abstractHandler3.Save();
                abstractHandler3.Chenge();
                abstractHandler3.Create();
            }
            else if (format == "TXT")
            {
                AbstractHandler abstractHandler1 = new TXTHandler();
                abstractHandler1.Open();
                abstractHandler1.Save();
                abstractHandler1.Chenge();
                abstractHandler1.Create();

            }
            else if (format == "XML")
            {
                AbstractHandler abstractHandler2 = new XMLHandler();
                abstractHandler2.Open();
                abstractHandler2.Save();
                abstractHandler2.Chenge();
                abstractHandler2.Create();
            }
            else
                Console.WriteLine("Ви ввели не вірний формат");


            Console.ReadKey();
        }
    }
}

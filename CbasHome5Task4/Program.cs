using System;

namespace CbasHome5Task4
{
    public abstract class OllDocument
    {
        public abstract string Content { set; get; }


        public abstract void Show();



    }

   public class Title: OllDocument
    {
        string content;

        public override string Content
        {
           get
            {
                if (content != null)
                    return content;
                else
                    return "Заголовок отсутствует.";
            }
            set
            {
                content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    class Footer:OllDocument
    {
        string content;

        public override string Content
        {
             get
            {
                if (content != null)
                    return content;
                else
                    return "Нижний колонтитул отсутствует.";
            }
            set
            {
                content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    //class Document
    //{
    //    // Поля
    //    Title title;
    //    Body body;
    //    Footer footer;
    //    public Document()
    //    {
    //        OllDocument document = new Title();
    //        document.Content = null;
    //        document.Show();
    //    }        
    //    public Document(Title title, Body body, Footer footer)
    //    {
    //        this.title = title;
    //        this.body = body;
    //        this.footer = footer;
    //    }

        //public void Show()
        //{
        //    this.title.Show();
        //    this.body.Show();
        //    this.footer.Show();
        //}
    //}
    class Body: OllDocument
    {
        string content;

        public override string Content
        {
             get
            {
                if (content != null)
                    return content;
                else
                    return "Тело документа отсутствует.";
            }
            set
            {
                content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }


    internal class Program
    {
        /*Задание 5

        Используя Visual Studio, создайте проект по шаблону Console Application. 
        Требуется: Изменить 12 пример первого урока (работа с документом) и создать 
        общий абстрактный класс для всех частей документа.*/

        static void Main(string[] args)
        {

           // Document document = new Document();
          
            
           OllDocument document = new Title();           
           document.Content = "Контракт";
            document.Show();

            OllDocument document1  =new Body();
            document1.Content = "Тело контракта...";
            document1.Show();

            OllDocument document2 = new Footer();
            document2.Content = "Директор: Иванов И.И.";
            document2.Show();




            // OllDocument body = new Body();
            // body.Content = "Тело контракта...";


            // OllDocument footer = new Footer();
            // footer.Content = "Директор: Иванов И.И.";


            //Title title = new Title();
            //title.Content = "Контракт";

            //Body body = new Body();
            //body.Content = "Тело контракта...";

            //Footer footer = new Footer();
            //footer.Content = "Директор: Иванов И.И.";

            //Document document = new Document(title, body, footer);
            //document.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}

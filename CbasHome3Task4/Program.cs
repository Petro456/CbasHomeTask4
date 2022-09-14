using System;

namespace CbasHome3Task4
{
    /*Задание 3 

        Используя Visual Studio, создайте проект по шаблону Console Application. Требуется:
    Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода 
    void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно. 
    Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. Написать программу, 
    которая выполняет проигрывание и запись. */
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();

    }

    interface IRecodable
    {
        void Record();
        void Pause();

        void Stop();

    }
    public class Player : IPlayable, IRecodable
    {
        public void Pause()
        {
            Console.WriteLine("Pause song");
        }

        public void Play()
        {
            Console.WriteLine("Play song");
        }

        public void Record()
        {
            Console.WriteLine("Record song");
        }

        public void Stop()
        {
            Console.WriteLine("Stop song");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player();

            player.Play();
            (player as IPlayable).Stop();
           
            player.Record();
            (player as IRecodable).Stop();

            Console.ReadKey();
        }
    }
}

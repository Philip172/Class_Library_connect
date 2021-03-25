using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Class_Library_connect
{
    public static class Connect
    {
        // порт для приема входящих запросов
        public static int port = 8005;

        // IP адрес игрока
        public static readonly IPAddress IPAddress = IPAddress.Parse("127.0.0.1");
    }

    public static class Players_data
    {
        //Деньги Игроков
        public static int[] moneys = new int[3] { 0, 0, 0, };

        //Идентификаторы игроков
        public static string[] players = new string[] { "_money1", "_money2", "_money3" };
    }
}

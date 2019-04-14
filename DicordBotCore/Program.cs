using System;
using DicordBotCore.Storage;
using Discord.WebSocket;

namespace DicordBotCore
{
    internal class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Olá, Discord");      
        }
    }
}


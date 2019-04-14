using System;
using DicordBotCore.Discord;
using DicordBotCore.Discord.Entities;
using Discord.WebSocket;

namespace DicordBotCore
{
    internal class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Olá, Discord");

            var discordBotConfig = new EscravoBotConfig
            {
                Token = "",
                SocketConfig = SocketConfig.GetDefault()
            };
        }


        
    }
}


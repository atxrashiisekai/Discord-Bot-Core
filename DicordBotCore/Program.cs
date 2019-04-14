using System;
using DicordBotCore.Discord;
using DicordBotCore.Discord.Entities;

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

            var connection = Unity.Resolve<Connection>();

        }


        
    }
}


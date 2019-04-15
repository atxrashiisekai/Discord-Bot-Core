using System;
using System.Threading.Tasks;
using DicordBotCore.Discord;
using DicordBotCore.Discord.Entities;
using DicordBotCore.Storage;
using Discord.WebSocket;

namespace DicordBotCore
{
    internal class Program
    {
        private static async Task Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Olá, Discord");


            var storage = Unity.Resolve<IDataStorage>();

            var connection = Unity.Resolve<Connection>();
            await connection.ConnectAsync(new EscravoBotConfig
            {
                Token = storage.RestoreObject<string>("Config/BotToken")
            });

        }


        
    }
}


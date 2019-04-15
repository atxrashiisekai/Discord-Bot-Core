﻿using System;
using System.Threading.Tasks;
using DicordBotCore.Discord.Entities;
using Discord;
using Discord.WebSocket;


namespace DicordBotCore.Discord
{
    public class Connection
    {
        private readonly DiscordSocketClient _client;
        private readonly DiscordLogger _logger;

        public Connection(DiscordLogger logger, DiscordSocketClient client)
        {
            _logger = logger;
            _client = client;
        }


        internal async Task ConnectAsync(EscravoBotConfig config)
        {
              _client.Log += _logger.Log;

            await _client.LoginAsync(TokenType.Bot, config.Token);
            await _client.StartAsync();

            await Task.Delay(-1);
        }
    }
}
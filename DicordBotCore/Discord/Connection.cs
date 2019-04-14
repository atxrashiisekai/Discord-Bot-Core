using System;
using System.Threading.Tasks;
using DicordBotCore.Discord.Entities;
using Discord;
using Discord.WebSocket;


namespace DicordBotCore.Discord
{
    public class Connection
    {
        private DiscordSocketClient _client;
        private DiscordLogger _logger;


        public Connection(DiscordLogger logger)
        {
            _logger = logger;
        }


        internal async Task ConnectAsync(EscravoBotConfig config)
        {
            _client = new DiscordSocketClient(config.SocketConfig);

            _client.Log += _logger.Log;
        }
    }
}
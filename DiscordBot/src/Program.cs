using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace DiscordBot
{
    class Program
    {
        public const string TOKEN = "OTAyMDgwNzUyMTgxNzE5MDQw.YXZOKw.tcEQx0ebHFINaBZ068q9euv_vrQ";
        private DiscordSocketClient _client;

        // EntryPoint
        static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();
        public async Task MainAsync()
        {
            _client = new DiscordSocketClient(new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Info,
            });

            _client.Log += Log;

            await _client.LoginAsync(TokenType.Bot, TOKEN);
            await _client.StartAsync();

            await Task.Delay(-1);
        }

        private Task Log(LogMessage arg)
        {
            Debug.Log(arg.Message);
            return Task.CompletedTask;
        }
    }
}

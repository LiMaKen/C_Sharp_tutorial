using System;
using Discord;
using Discord.WebSocket;
using Discord.Commands;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Discord.Net;
using Newtonsoft.Json;
using Color = Discord.Color;
using System.Reflection;
using System.Collections.Generic;
using System.Threading;
using System.Collections.Specialized;

namespace Discord
{
    public class DiscordBot
    {
        public DiscordBot() { }
        static void Main() => StartDiscordBot().GetAwaiter().GetResult();

        private static DiscordSocketClient client;
        private static CommandService commands;
        private static IServiceProvider services;
        private static string token = "MTE3NDIxNjAwNTIxMjQzODU2OA.GILK-J.2wmIw-0Be649Mk8AOXndNqnsOSTcocGRbETAHE";

        public static async Task StartDiscordBot()
        {
            try
            {
                var configuracoes = new DiscordSocketConfig()
                {
                    GatewayIntents = GatewayIntents.Guilds | GatewayIntents.GuildMessages
                };
                client = new DiscordSocketClient(configuracoes);
                commands = new CommandService();
                services = new ServiceCollection()
                    .AddSingleton(client)
                    .AddSingleton(commands)
                    .BuildServiceProvider();

                client.Log += DiscordBotLog;

                client.Ready += BotIsReady;

                await client.LoginAsync(TokenType.Bot, token);

                await client.StartAsync();
                await Task.Delay(Timeout.Infinite);

            }
            catch (Exception) { }
        }

        public async static Task BotIsReady()
        {
            await client.SetGameAsync("với 151 người khác trên Vnrgames.com");

            var guild = client.GetGuild(1172830218700988476);

            var commands = new List<SlashCommandBuilder>
    {
        new SlashCommandBuilder().WithName("whitelisttest").WithDescription("Đây là lệnh kiểm tra Whitelist của chúng tôi!"),
    };

            foreach (var commandBuilder in commands)
            {
                try
                {
                    await guild.CreateApplicationCommandAsync(commandBuilder.Build());
                }
                catch (HttpException exception)
                {
                    var json = JsonConvert.SerializeObject(exception.Errors, Formatting.Indented);
                    Console.WriteLine(json);
                }
            }

            client.SlashCommandExecuted += SlashCommandHandler;
        }

        private static async Task SlashCommandHandler(SocketSlashCommand command)
        {
            switch (command.Data.Name)
            {
                case "whitelisttest":
                    await HandleWhitelistTestCommand(command);
                    break;

            }

        }
        public static async Task Notification(string message)
        {
            try
            {
                var embedBuilder = new EmbedBuilder()
                .WithTitle("Thông Báo")
                .WithDescription($"{message}!")
                .WithImageUrl("https://id.vnrgames.com/images/logoklein.png")
                .WithColor(Color.Green)
                .WithCurrentTimestamp();
                ulong id = 1174215400842592347; // 3
                var chnl = client.GetChannel(id) as IMessageChannel; // 4
                await chnl.SendMessageAsync(embed: embedBuilder.Build()); // 5
            }
            catch (Exception e)
            {
                Console.WriteLine("error", $"[Notification]: " + e.ToString());
            }
        }
        private static async Task HandleWhitelistTestCommand(SocketSlashCommand command)
        {
            try
            {
                var embedBuilder = new EmbedBuilder()
               .WithAuthor(command.User)
               .WithTitle("Whitelisttest")
               //.WithDescription($"Danh sách người chơi có trong whitelist: \n {CheckName()}")
               .WithImageUrl("https://id.vnrgames.com/images/logoklein.png")
               .WithColor(Color.Green)
               .WithCurrentTimestamp();

                await command.RespondAsync(embed: embedBuilder.Build());
            }
            catch (Exception e)
            {
                Console.WriteLine("error", $"[Notification]: " + e.ToString());
            }

        }
       
        public static Task DiscordBotLog(LogMessage message)
        {
            Console.WriteLine(message.ToString());
            return Task.CompletedTask;
        }
        public static async Task InstallCommandsAsync()
        {
            client.MessageReceived += HandleCommandAsync;
            await commands.AddModulesAsync(Assembly.GetEntryAssembly(), null);
        }
        public static async Task HandleCommandAsync(SocketMessage pMessage)
        {
            var message = (SocketUserMessage)pMessage;
            if (message == null) return;
            int argPos = 0;
            if (!message.HasCharPrefix('!', ref argPos)) return;
            var context = new SocketCommandContext(client, message);
            var result = await commands.ExecuteAsync(context, argPos, null);
            if (!result.IsSuccess)
                await context.Channel.SendMessageAsync(result.ErrorReason);
        }
        

    }
}
using System;

using Telegram.Bot;

namespace AntiFloodTelegramBot

{
    class Program
    {
        static TelegramBotClient Bot;

        static void Main(string[] args)
        {
            Bot = new TelegramBotClient("1670447707:AAHshrI-pis_i6cXIRkxsjF9I4hBzOanDRw");

            Bot.OnMessage += Bot_OnMessage;

            var me = Bot.GetMeAsync().Result;

            Console.WriteLine(me.FirstName);

            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            var message = e.Message;
            
            string name = $"{message.From.FirstName} {message.From.LastName}";

            Console.WriteLine($" {name} sended message: '{message.Text}'");
        }
    }
}
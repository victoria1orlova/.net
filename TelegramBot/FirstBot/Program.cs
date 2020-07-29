using System;
using Telegram.Bot;

namespace FirstBot
{
    class Program
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("1379242676:AAElTeOUGJv21teEWtMTBGRanL5cKJzvQuk");

        static void Main(string[] args)
        {
            Bot.OnMessage += Bot_OnMessage;
            Bot.OnMessageEdited += Bot_OnMessage;

            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.TextMessage)
            {
                if (e.Message.Text == "How are you?")
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Fine, thank you) And you?");
                else if (e.Message.Text == "Good morning)")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Good morning, " + e.Message.Chat.Username);
                }
                else
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, @"Usage:                            
                       How are you?                            
                       Good morning!
                        ");
                }
            }
        }
    }
}
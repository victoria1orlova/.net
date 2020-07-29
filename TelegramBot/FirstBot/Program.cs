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
            Console.WriteLine(" -= Telegram Bot started =-");
            Console.WriteLine("Press Enter to stop this bot...");
            Console.ReadLine();
            Bot.StopReceiving();
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.TextMessage)
            {
                var text = "I did not understand you?";

                if (e.Message.Text == "Hi")
                {
                    text = $"Hello, {e.Message.Chat.FirstName}!";
                } else if (e.Message.Text == "How are you?")
                {
                    text = "Fine, thanks)))))))";
                }
                else if (e.Message.Text == "Good morning)")
                {
                    text = $"Good morning, {e.Message.Chat.Username}";
                } else if(e.Message.Text == "What are you do?")
                {
                    text = "Nothint, do you want solve some task?";
                }
                else if (e.Message.Text == "Okay))))")
                {
                    text = "2+2=...";
                }
                else if (e.Message.Text == "4")
                {
                    text = "Good job!";
                }

                Bot.SendTextMessageAsync(e.Message.Chat.Id, text);
            }
        }
    }
}
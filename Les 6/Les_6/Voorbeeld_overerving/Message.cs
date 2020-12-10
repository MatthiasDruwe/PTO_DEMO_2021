using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_overerving
{
    class Message
    {
        string sender;
        string content;
        DateTime date;
        string receiver;

        public Message(string sender, string content, DateTime date, string receiver)
        {
            this.sender = sender;
            this.content = content;
            this.date = date;
            this.receiver = receiver;
        }

        public Message()
        {

        }

        public string Content { get => content; protected set => content = value; }
        public DateTime Date { get => date; protected set => date = value; }
        public string Sender { get => sender; protected set => sender = value; }
        public string Receiver { get => receiver; protected set => receiver = value; }

        public string Display()
        {
            return content;
        }

        protected void DoSomething()
        {
            Console.WriteLine("I'm doing something");

        }

        public void Send()
        {
            Console.WriteLine("Message send!");
        }
    }
}

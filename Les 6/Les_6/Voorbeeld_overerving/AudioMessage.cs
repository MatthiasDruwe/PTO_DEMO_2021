using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_overerving
{
    class AudioMessage: Message
    {
        string audioURL;

        public AudioMessage(string sender, DateTime date, string receiver, string audioURL):
            base(sender, "Dit is eigenlijk een audiomessage", date, receiver)
        {
            this.audioURL = audioURL;
        }

        public string AudioURL { get => audioURL; set => audioURL = value; }

        public void PlayMessage()
        {
            Console.WriteLine("Messages playing");
        }
    }
}

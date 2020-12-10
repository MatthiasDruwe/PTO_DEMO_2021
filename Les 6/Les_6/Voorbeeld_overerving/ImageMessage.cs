using System;


namespace Voorbeeld_overerving
{
    class ImageMessage : Message
    {

        string imagePath;

        public ImageMessage(string sender, string content, DateTime date, string receiver, string imagePath) :
            base(sender, content, date, receiver)
        {
            this.imagePath = imagePath;
        }

        public ImageMessage(string imagePath)
        {
            this.imagePath = imagePath;
        }

        public string ImagePath { get => imagePath; set => imagePath = value; }

        public string LoadImage()
        {
            return imagePath;
        }

        public string Display()
        {
            return "Ik ben een imageMessage";
        }

        public override string ToString()
        {
            return "Ik ben een imageMessage";
        }
    }
}

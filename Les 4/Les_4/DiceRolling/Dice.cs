using System;
using System.Windows.Media.Imaging;

namespace DiceRolling
{
    /// <summary>
    /// Dit is een dobbelsteen klasse die een random getal tussen 1 en 6 terug geeft.
    /// </summary>
    class Dice
    {
        // Private members / class attributes / class variables
        private int rolledNumber;
        private BitmapImage image;
        private string name;

        // Constructor 
        public Dice(string name)
        {
            this.name = name;
        }

        public Dice()
        {

        }

        // Properties / getters & setters
        public int RolledNumber
        {
            get { return rolledNumber; }
        }

        public BitmapImage Image
        {
            get { return image; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Methodes (public & private)
        public void Roll()
        {
            Random random = new Random();
            int newNumber;
            do
            {
                newNumber = random.Next(1, 7);

            } while (newNumber == rolledNumber);
            rolledNumber = newNumber;

            SetImage(rolledNumber);
        }

        private void SetImage(int number)
        {
            string url = "";

            switch (number)
            {
                case 1:
                    url = "/Images/Alea_1.png";
                    break;
                case 2:
                    url = "/Images/Alea_2.png";
                    break;
                case 3:
                    url = "/Images/Alea_3.png";
                    break;
                case 4:
                    url = "/Images/Alea_4.png";
                    break;
                case 5:
                    url = "/Images/Alea_5.png";
                    break;
                case 6:
                    url = "/Images/Alea_6.png";
                    break;
            }

            if (url != "")
            {
                Uri resourceUri = new Uri(url, UriKind.Relative);
                image = new BitmapImage(resourceUri);
            }
        }
    }
}

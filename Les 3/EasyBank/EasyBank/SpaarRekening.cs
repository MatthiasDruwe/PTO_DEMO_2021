using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBank
{
    class SpaarRekening: Rekening
    {
        public SpaarRekening(string naam): base(naam)
        {

        }

        public new void ToonMenu()
        {
            char keuze;
            do
            {
                Console.Clear();
                Console.WriteLine("a. Storten.");
                Console.WriteLine("b. Check saldo.");
                Console.WriteLine("c. Bekijk laatste 10 verrichtingen");
                Console.WriteLine("d. Terug naar hoofdmenu.");

                keuze = Convert.ToChar(Console.ReadKey().KeyChar.ToString().ToLower());
                Console.WriteLine();

                VoerActieUit(keuze);
                Console.ReadKey();
            } while (keuze != 'd');
        }

        private void VoerActieUit(char keuze)
        {
           
            if (keuze == 'a')
            {
                GeldStorten();
            }
            else if (keuze == 'b')
            {
                ToonSaldo();
            }
            else if (keuze == 'c')
            {
                ToonVerrichting();
            }
        }
    }
}

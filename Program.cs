using System;
using Bogus;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace MyBanker
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Velkommen til kortoprettelsessystemet.");
            Console.WriteLine();

            //Instatiating a list for each type og card
            List<VisaCard> visaCards = new List<VisaCard>();
            List<MasterCard> masterCards = new List<MasterCard>();
            List<MaestroCard> maestroCards = new List<MaestroCard>();
            List<VisaElectronCard> visaElectronCards = new List<VisaElectronCard>();
            List<DebitCard> debitCards = new List<DebitCard>();


            //Creating 5 pcs of each card type by instantiating a new object of each credicard in a loop of 5,
            //and afterwards adding them to their respective Lists
            for (int i = 0; i < 5; i++)
            {
                VisaCard visaCard = new VisaCard();
                visaCards.Add(visaCard);
                MasterCard masterCard = new MasterCard();
                masterCards.Add(masterCard);
                MaestroCard maestroCard = new MaestroCard();
                maestroCards.Add(maestroCard);
                VisaElectronCard visaElectron = new VisaElectronCard();
                visaElectronCards.Add(visaElectron);
                DebitCard debitCard = new DebitCard();
                debitCards.Add(debitCard);

            }

            //GuiPrincessing a bit together with my pink unicorn
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------Der er nu oprettet følgende visa/dankort-----------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.Write("{0,-22}", $"Kunde navn");
            Console.Write("{0,10}", $"reg nr.");
            Console.Write("{0,12}", $"Kontonummer");
            Console.Write("{0,18}", $"Kort type");
            Console.Write("{0,22}", $"Kortnummer");
            Console.Write("{0,15}", $"Mdr. limit");
            Console.Write("{0,12}", $"Kredit");
            Console.Write("{0,18}", $"Udstedt d.");
            Console.Write("{0,18}", $"Gyldig til\n");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");


            //Printing all VisaCards
            foreach (var card in visaCards)
            {
                Console.Write("{0,-22}", $"{card.CardHolder}");
                Console.Write("{0,10}", $"{card.RegNumber}");
                Console.Write("{0,12}", card.AccountNumber.ToString("D10"));
                Console.Write("{0,18}", $"{card.CardType}");
                Console.Write("{0,22}", $"{card.Prefix} {card.CardNumber}");
                Console.Write("{0,15}", $"{card.MonthlyLimit}");
                Console.Write("{0,12}", $"{card.CreditMax}");
                Console.Write("{0,18}", $"{card.CreationDate.ToShortDateString()}");
                Console.Write("{0,18}", $"{card.ExpireDate.ToShortDateString()}\n");
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();


            //GuiPrincessing a bit together with my pink unicorn
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------Der er nu oprettet følgende MasterCards--------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.Write("{0,-22}", $"Kunde navn");
            Console.Write("{0,10}", $"reg nr.");
            Console.Write("{0,12}", $"Kontonummer");
            Console.Write("{0,18}", $"Kort type");
            Console.Write("{0,22}", $"Kortnummer");
            Console.Write("{0,16}", $"Daglig limit");
            Console.Write("{0,15}", $"Mdr. limit");
            Console.Write("{0,12}", $"Kredit");
            Console.Write("{0,18}", $"Udstedt d.");
            Console.Write("{0,18}", $"Gyldig til\n");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------");


            //Printing all Mastercards
            foreach (var card in masterCards)
            {
                Console.Write("{0,-22}", $"{card.CardHolder}");
                Console.Write("{0,10}", $"{card.RegNumber}");
                Console.Write("{0,12}", card.AccountNumber.ToString("D10"));
                Console.Write("{0,18}", $"{card.CardType}");
                Console.Write("{0,22}", $"{card.Prefix} {card.CardNumber}");
                Console.Write("{0,16}", $"{card.DailyLimit}");
                Console.Write("{0,15}", $"{card.MonthlyLimit}");
                Console.Write("{0,12}", $"{card.CreditMax}");
                Console.Write("{0,18}", $"{card.CreationDate.ToShortDateString()}");
                Console.Write("{0,18}", $"{card.ExpireDate.ToShortDateString()}\n");
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();


            //GuiPrincessing a bit together with my pink unicorn
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------Der er nu oprettet følgende Maestro kort---------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.Write("{0,-22}", $"Kunde navn");
            Console.Write("{0,10}", $"reg nr.");
            Console.Write("{0,12}", $"Kontonummer");
            Console.Write("{0,18}", $"Kort type");
            Console.Write("{0,22}", $"Kortnummer");
            Console.Write("{0,18}", $"Udstedt d.");
            Console.Write("{0,18}", $"Gyldig til\n");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");


            //Printing all Maestrocards
            foreach (var card in maestroCards)
            {
                Console.Write("{0,-22}", $"{card.CardHolder}");
                Console.Write("{0,10}", $"{card.RegNumber}");
                Console.Write("{0,12}", card.AccountNumber.ToString("D10"));
                Console.Write("{0,18}", $"{card.CardType}");
                Console.Write("{0,22}", $"{card.Prefix} {card.CardNumber}");
                Console.Write("{0,18}", $"{card.CreationDate.ToShortDateString()}");
                Console.Write("{0,18}", $"{card.ExpireDate.ToShortDateString()}\n");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();


            //GuiPrincessing a bit together with my pink unicorn
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------Der er nu oprettet følgende VisaElectron kort--------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
            Console.Write("{0,-22}", $"Kunde navn");
            Console.Write("{0,10}", $"reg nr.");
            Console.Write("{0,12}", $"Kontonummer");
            Console.Write("{0,18}", $"Kort type");
            Console.Write("{0,22}", $"Kortnummer");
            Console.Write("{0,15}", $"Mdr. limit");
            Console.Write("{0,18}", $"Udstedt d.");
            Console.Write("{0,18}", $"Gyldig til\n");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");


            //Printing all VisaElectron cards
            foreach (var card in visaElectronCards)
            {
                Console.Write("{0,-22}", $"{card.CardHolder}");
                Console.Write("{0,10}", $"{card.RegNumber}");
                Console.Write("{0,12}", card.AccountNumber.ToString("D10"));
                Console.Write("{0,18}", $"{card.CardType}");
                Console.Write("{0,22}", $"{card.Prefix} {card.CardNumber}");
                Console.Write("{0,15}", $"{card.MonthlyLimit}");
                Console.Write("{0,18}", $"{card.CreationDate.ToShortDateString()}");
                Console.Write("{0,18}", $"{card.ExpireDate.ToShortDateString()}\n");
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();


            //GuiPrincessing a bit together with my pink unicorn
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------Der er nu oprettet følgende Hævekort--------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.Write("{0,-22}", $"Kunde navn");
            Console.Write("{0,10}", $"reg nr.");
            Console.Write("{0,12}", $"Kontonummer");
            Console.Write("{0,18}", $"Kort type");
            Console.Write("{0,22}", $"Kortnummer");
            Console.Write("{0,18}", $"Udstedt d.\n");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");


            //Printing all debitCards
            foreach (var card in debitCards)
            {
                Console.Write("{0,-22}", $"{card.CardHolder}");
                Console.Write("{0,10}", $"{card.RegNumber}");
                Console.Write("{0,12}", card.AccountNumber.ToString("D10"));
                Console.Write("{0,18}", $"{card.CardType}");
                Console.Write("{0,22}", $"{card.Prefix} {card.CardNumber}");
                Console.Write("{0,18}", $"{card.CreationDate.ToShortDateString()}\n");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace MyBanker
{
    public abstract class Card//Mother of the classes
    {
        //Instantiating an instance of a random object to be used all over the class
        static Random rand = new Random();


        #region Fields
        private string cardType;
        private string cardHolder;
        private byte cardDigits;
        private int prefix;
        private string cardNumber;
        private int regNumber;
        private ulong accountNumber;
        private DateTime creationDate;
        #endregion


   

        #region Properties
        public string CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }

        public string CardHolder
        {
            get { return cardHolder; }
            set { cardHolder = value; }
        }

        public byte CardDigits
        {
            get { return cardDigits; }
            set { cardDigits = value; }
        }

        public int Prefix
        {
            get { return prefix; }
            set { prefix = value; }
        }

        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        public int RegNumber
        {
            get { return regNumber; }
            set { regNumber = value; }
        }

        public ulong AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }
        #endregion

        #region Constructors
        public Card()
        {
            //Nothing to see here
        }
        #endregion




        #region Methods

        //Creating a new random customer name by using the Bogus NuggetPackage. It is great for creating a lot of different fake data to run tests with
        public virtual void CreateCardHolder()
        {
            CardHolder = new Faker().Person.FullName;
        }

        //Method to select random prefit for each type og card, and add it to the card when the card is created
        public virtual void CreatePrefix()
        {
            //Adding the data to be used in the logic into a couple of arrays and variables
            int visaPrefix = 4;
            int[] masterCardPrefixes = { 51, 52, 53, 54, 55 };
            int[] maestroPrefixes = { 5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763 };
            int[] visaElectronPrefixes = { 4026, 417500, 4508, 4844, 4913, 4917 };
            int debitPrefix = 2400;

            if (CardType == "Visa/Dankort")
            {
                Prefix = visaPrefix;//This is just easy
            }
            if (CardType == "Mastercard")
            {
                int index = rand.Next(masterCardPrefixes.Length);//Selecting random value from the array
                Prefix = masterCardPrefixes[index];
            }
            if (CardType == "Maestro")
            {
                int index = rand.Next(maestroPrefixes.Length);//Selecting random value from the array
                Prefix = maestroPrefixes[index];
            }
            if (CardType == "Visa Electron")
            {
                int index = rand.Next(visaElectronPrefixes.Length);//Selecting random value from the array
                Prefix = visaElectronPrefixes[index];
            }
            if (CardType == "Hævekort")
            {
                Prefix = debitPrefix;//Another easy one
            }
        }


        //Method to create the cardnumber. This method is also called from within each creditcard class taking attributes from bothe them self and mother classes
        public virtual void CreateCardNumber()
        {//taking the base 10 logarithm, adding 1, and rounding it down. then substracting it from the cardDigits and putting it into the variable
            int randomCardNumberLength = (int)(CardDigits - Math.Floor(Math.Log10(Prefix) + 1));
            string stringcardNumber = "";//Creating an empty string to the variable
            for (int i = 0; i < randomCardNumberLength; i++)
            {
                stringcardNumber += rand.Next(0, 9).ToString();//Adding a new number for each randomNumberLength and converting it to a string
            }
            CardNumber = stringcardNumber;//Adding the string to the CardNumber
        }


        //Creating accountnumber for for each creditCard and is called from within each creditCard class using it.
        //I could also have convertet this to a string, but the attributes was already created, so I went with the ulong to to time pressure
        public virtual void CreateAccountNumber()
        {
            string stringaccountNumber = "";
            for (int i = 0; i < 10; i++)
            {
                stringaccountNumber += rand.Next(0, 9).ToString();//Looping 10 times adding a new random number between 0 and 9 to the treing.
            }
            AccountNumber = Convert.ToUInt64(stringaccountNumber);//Converting the string into an ulong for easy use.
        }


        //Setting the creation date for each card. This method is called from within each creditcard class
        public virtual void SetCreationDate()
        {
            CreationDate = DateTime.Now;
        }

        #endregion
    }
}

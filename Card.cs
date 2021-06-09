using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace MyBanker
{
    public class Card
    {
        public static Random rand = new Random();

        #region Fields
        private string cardType;
        private string cardHolder;
        private byte cardDigits;
        private int prefix;
        private ulong cardNumber;
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

        public ulong CardNumber
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

        }
        #endregion

        #region Methods

        public virtual void CreateCardHolder()
        {
            CardHolder = new Faker().Person.FullName;
        }

        public virtual void CreatePrefix()
        {
            int visaPrefix = 4;
            int[] masterCardPrefixes = { 51, 52, 53, 54, 55 };
            int[] maestroPrefixes = { 5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763 };
            int[] visaElectronPrefixes = { 4026, 417500, 4508, 4844, 4913, 4917 };
            int debitPrefix = 2400;
            if (CardType == "Visa/Dankort")
            {
                Prefix = visaPrefix;
            }
            if (CardType == "Mastercard")
            {
                int index = rand.Next(masterCardPrefixes.Length);
                Prefix = masterCardPrefixes[index];
            }
            if (CardType == "Maestro")
            {
                int index = rand.Next(maestroPrefixes.Length);
                Prefix = maestroPrefixes[index];
            }
            if (CardType == "Visa Electron")
            {
                int index = rand.Next(visaElectronPrefixes.Length);
                Prefix = visaElectronPrefixes[index];
            }
            if (CardType == "Hævekort")
            {
                Prefix = debitPrefix;
            }
        }

        public virtual void CreateCardNumber()
        {
            int randomCardNumberLength = (int)(CardDigits + 1 - Math.Floor(Math.Log10(Prefix) + 1));
            CardNumber = Convert.ToUInt64(rand.Next((int)Math.Pow(10, randomCardNumberLength), (int)Math.Pow(10, randomCardNumberLength + 1) - 1));
        }

        public virtual void CreateAccountNumber()
        {
            
            AccountNumber = Convert.ToUInt64(rand.Next(1, (int)Math.Pow(10, 10)));
        }

        #endregion
    }
}

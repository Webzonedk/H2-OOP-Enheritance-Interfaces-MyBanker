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
        //private byte cardDigits;
        //private ulong cardNumber;
        //private int prefix;
        //private ulong accountNumber;
        //private DateTime creationDate;
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

        //public byte CardDigits
        //{
        //    get { return cardDigits; }
        //    set { cardDigits = value; }
        //}

        //public ulong CardNumber
        //{
        //    get { return cardNumber; }
        //    set { cardNumber = value; }
        //}

        //public int Prefix
        //{
        //    get { return prefix; }
        //    set { prefix = value; }
        //}

        //public ulong AccountNumber
        //{
        //    get { return accountNumber; }
        //    set { accountNumber = value; }
        //}

        //public DateTime CreationDate
        //{
        //    get { return creationDate; }
        //    set { creationDate = value; }
        //}
        //#endregion

        #region Constructors
        public Card()
        {
            CardType = SelectCardType();
            CardHolder = CreateCardHolder();
            //this.cardDigits = cardDigits;
            //this.cardNumber = cardNumber;
            //this.prefix = prefix;
            //this.accountNumber = accountNumber;
            //this.creationDate = creationDate;
        }
        #endregion

        #region Methods
        public virtual void CreateCard()
        {
            CardType = SelectCardType();
            CardHolder = CreateCardHolder();
        }

        public virtual string SelectCardType()
        {
            string[] cardTypes = { "Visa/Dankort", "Mastercard", "Maestro", "Visa Electron", "Hævekort" };
            int index = rand.Next(cardTypes.Length);
            return cardTypes[index];

        }

        public virtual string CreateCardHolder()
        {
            return new Faker().Person.FullName;
        }


        public virtual int CreatePrefix()
        {
            int visaPrefix = 4;
            int[] masterCardPrefixes = {51, 52, 53, 54, 55};
            int[] maestroPrefixes = {5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763};
            int[] visaElectronPrefixes = {4026, 417500, 4508, 4844, 4913, 4917};
            int debitPrefix = 2400;
            if (CardType == "Visa/Dankort")
            {
                return visaPrefix;
            }
            if (CardType == "Mastercard")
            {
                int index = rand.Next(masterCardPrefixes.Length);
                return masterCardPrefixes[index];
            }
            if (CardType == "Maestro")
            {
                int index = rand.Next(maestroPrefixes.Length);
                return maestroPrefixes[index];
            }
            if (CardType == "Visa Electron")
            {
                int index = rand.Next(visaElectronPrefixes.Length);
                return visaElectronPrefixes [index];
            }
            if (CardType == "Hævekort")
            {
                return debitPrefix;
            }
            else
            {
            return 0;
            }
        }

        public virtual void CreateCardNumber()
        {

        }


        #endregion
    }
}

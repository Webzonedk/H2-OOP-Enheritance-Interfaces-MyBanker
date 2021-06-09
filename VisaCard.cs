using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class VisaCard : Expire, ICredit //Enherit from CardClass and connected to the interface ICredit
    {
        #region Fields
        private int monthlyLimit;
        private int creditMax;
        #endregion



        #region Properties
        public int MonthlyLimit
        {
            get { return monthlyLimit; }
            set { monthlyLimit = value; }
        }

        public int CreditMax
        {
            get { return creditMax; }
            set { creditMax = value; }
        }
        #endregion


        //Setting the hardcoded attributes and calling the methods from the motherclasses to create the rest
        #region Constructors
        public VisaCard()
        {
            CardType = "Visa/Dankort";
            CreateCardHolder();//Calling from Card class
            CardDigits = 16;
            CreatePrefix();//Calling from Card class
            CreateCardNumber();//Calling from Card class
            RegNumber = 3520;
            CreateAccountNumber();//Calling from Card class
            TimeToLive = 60;
            SetCreationDate();//Calling from Card class
            SetExpireryDate();//Calling from ExpireClass
            MonthlyLimit = 25000;
            CreditMax = 20000;
        }
        #endregion



        #region Methods
        public void CheckBalance()
        {
           //Her the balance of the card is being checked
        }

        public void CheckCreditMax()
        {
            //Here the Credit would be checked to ensure that the credit is not being broken
        }

        #endregion
    }
}

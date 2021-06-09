using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class MasterCard : Expire, ICredit //Enherit from CardClass and connected to the interface ICredit
    {
        #region Fields
        private int monthlyLimit;
        private int dailyLimit;
        private int creditMax;



        #endregion



        #region Properties
        public int MonthlyLimit
        {
            get { return monthlyLimit; }
            set { monthlyLimit = value; }
        }

        public int DailyLimit
        {
            get { return dailyLimit; }
            set { dailyLimit = value; }
        }

        public int CreditMax
        {
            get { return creditMax; }
            set { creditMax = value; }
        }
        #endregion



        #region Constructors
        public MasterCard()
        {
            CardType = "Mastercard";
            CreateCardHolder();//Calling from Card class
            CardDigits = 16;
            CreatePrefix();//Calling from Card class
            CreateCardNumber();//Calling from Card class
            RegNumber = 3520;
            CreateAccountNumber();//Calling from Card class
            TimeToLive = 60;
            SetCreationDate();//Calling from Card class
            SetExpireryDate();//Calling from Expire class
            MonthlyLimit = 30000;
            DailyLimit = 5000;
            CreditMax = 40000;
        }

        #endregion

        #region Methods
        public void CheckMonthlyUse()
        {
            //Here the monthly use is being calculated
        }
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

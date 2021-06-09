using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class VisaElectronCard : Expire, IDebit
    {
        #region Fields
        private int monthlyLimit;


        #endregion



        #region Properties
        public int MonthlyLimit
        {
            get { return monthlyLimit; }
            set { monthlyLimit = 10000; }
        }


        #endregion



        #region Constructors
        public VisaElectronCard()
        {
            CardType = "Visa Electron";
            CreateCardHolder();
            CardDigits = 16;
            CreatePrefix();
            CreateCardNumber();
            RegNumber = 3520;
            CreateAccountNumber();
            TimeToLive = 60;
            MonthlyLimit = 10000;
        }
        #endregion



        #region Methods
        public void CheckBalance()
        {
            //Her the balance of the card is being checked
        }

        public void CheckMonthlyLimit()
        {

        }

        #endregion
    }
}

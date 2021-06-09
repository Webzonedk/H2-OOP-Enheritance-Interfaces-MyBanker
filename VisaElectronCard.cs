using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class VisaElectronCard : Expire, IDebit //Enherit from CardClass and connected to the interface Idebit
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
            CreateCardHolder();//Calling from Card class
            CardDigits = 16;
            CreatePrefix();//Calling from Card class
            CreateCardNumber();//Calling from Card class
            RegNumber = 3520;
            CreateAccountNumber();//Calling from Card class
            TimeToLive = 60;
            SetCreationDate();//Calling from Card class
            SetExpireryDate();//Calling from Expire class
            MonthlyLimit = 10000;
        }
        #endregion



        #region Methods
        public void CheckBalance()
        {
            //Her the balance of the card is being checked as a part of the Interface
        }

        public void CheckMonthlyLimit()
        {
            //Not implemented as there is no functional bank account
        }

        #endregion
    }
}

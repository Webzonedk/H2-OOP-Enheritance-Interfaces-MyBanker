﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class VisaCard : Expire, ICredit
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



        #region Constructors
        public VisaCard()
        {
            CardType = "Visa/Dankort";
            CreateCardHolder();
            CardDigits = 16;
            CreatePrefix();
            CreateCardNumber();
            RegNumber = 3520;
            CreateAccountNumber();
            TimeToLive = 60;
            SetExpireryDate();
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
            //Here the Credit is being checked to ensure that the credit is not being broken
        }

        #endregion
    }
}

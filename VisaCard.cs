using System;
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
            TimeToLive = 60;
            MonthlyLimit = 25000;
            CreditMax = 20000;
        }

        #endregion



        #region Methods
        public void CheckBalance()
        {
            throw new NotImplementedException();
        }

        public void CheckCreditMax()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

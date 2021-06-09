using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class MasterCard : Expire, ICredit
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
            TimeToLive = 60;
            MonthlyLimit = 30000;
            DailyLimit = 5000;
            CreditMax = 40000;
        }

        #endregion

        #region Methods

        public void ChechDailyBalance()
        {

        }
        public void ChechMonthlyBalance()
        {

        }


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

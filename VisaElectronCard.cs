using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class VisaElectronCard : Expire, ICredit
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
            TimeToLive = 60;
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

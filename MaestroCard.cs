using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class MaestroCard : Expire, ICredit
    {
        #region Fields
  
        #endregion



        #region Properties
  
        #endregion



        #region Constructors
        public MaestroCard()
        
        {
            TimeToLive = 68;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class DebitCard : Card, IDebit
    {
        #region Fields

        #endregion



        #region Properties

        #endregion



        #region Constructors
        public DebitCard()
        {

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

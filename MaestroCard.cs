using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class MaestroCard : Expire, IDebit
    {
        #region Fields
  
        #endregion



        #region Properties
  
        #endregion



        #region Constructors
        public MaestroCard()
        
        {
            CardType = "Maestro";
            CreateCardHolder();
            CardDigits = 19;
            CreatePrefix();
            CreateCardNumber();
            RegNumber = 3520;
            CreateAccountNumber();
            TimeToLive = 68;
        }

        #endregion



        #region Methods
        public void CheckBalance()
        {
            //Her the balance of the card is being checked
        }



        #endregion
    }
}

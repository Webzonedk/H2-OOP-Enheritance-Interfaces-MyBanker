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
            CardType = "Hævekort";
            CreateCardHolder();
            CardDigits = 16;
            CreatePrefix();
            CreateCardNumber();
            RegNumber = 3520;
            CreateAccountNumber();
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

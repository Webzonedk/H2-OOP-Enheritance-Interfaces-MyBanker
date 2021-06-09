using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class DebitCard : Card, IDebit //Enherit from CardClass and connected to the interface Idebit
    {
        #region Fields

        #endregion



        #region Properties

        #endregion



        #region Constructors
        public DebitCard()
        {
            CardType = "Hævekort";
            CreateCardHolder();//Calling from Card class
            CardDigits = 16;
            CreatePrefix();//Calling from Card class
            CreateCardNumber();//Calling from Card class
            RegNumber = 3520;
            CreateAccountNumber();//Calling from Card class
            SetCreationDate();//Calling from Card class

        }
        #endregion





        #region Methods
        public void CheckBalance()
        {
            //Her the balance of the card is being checked as a part of the Interface
        }

        #endregion
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class MaestroCard : Expire, IDebit //Enherit from CardClass and connected to the interface Idebit
    {
        #region Fields
  
        #endregion



        #region Properties
  
        #endregion



        #region Constructors
        public MaestroCard()
        
        {
            CardType = "Maestro";
            CreateCardHolder();//Calling from Card class
            CardDigits = 19;
            CreatePrefix();//Calling from Card class
            CreateCardNumber();//Calling from Card class
            RegNumber = 3520;
            CreateAccountNumber();//Calling from Card class
            TimeToLive = 68;
            SetCreationDate();//Calling from Card class
            SetExpireryDate();//Calling from Expire class
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

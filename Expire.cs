using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Expire : Card //Enherit from the Card class
    {
        #region Fields
        private byte timeToLive;
        #endregion
        private DateTime expireDate;




        #region Properties
        public byte TimeToLive
        {
            get { return timeToLive; }
            set { timeToLive = value; }
        }
        public DateTime ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }
        #endregion



        #region Constructors
        public Expire()
        {
       
        }
        #endregion
        //Adding Expire date to those card who inherit from the Expire class
        //This methos is called from within the singe creditcard class wich have cards with expire dates
        #region Methods
        public virtual void SetExpireryDate()
        {
            ExpireDate = DateTime.Now.AddMonths(TimeToLive);
        }
        #endregion
    }
}

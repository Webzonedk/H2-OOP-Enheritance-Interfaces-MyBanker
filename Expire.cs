using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Expire : Card
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

        #region Methods
        public virtual void SetExpireryDate()
        {
            ExpireDate = DateTime.Now.AddMonths(TimeToLive);
        }
        #endregion
    }
}

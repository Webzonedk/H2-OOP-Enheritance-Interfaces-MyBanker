using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    //Interface to be able to access CreditCards and create methods just for them without interfering with the rest of the classes
    public interface ICredit
    {
        public void CheckBalance();

        public void CheckCreditMax();

    }
}

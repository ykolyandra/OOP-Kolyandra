using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Code
{
    public abstract class User_Abstract
    {
        public abstract decimal CalculatePay(City sender_town, City receiver_town, double weight);
        public void CheckPostBox()
        {

            throw new NotImplementedException();
        }
    }
}

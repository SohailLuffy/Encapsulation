using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecapsulation
{
    class Account
    {
        int AccountBalance = 1000;
        public int Balance
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("You cannot pass");
                }
                else
                {

                    AccountBalance = value;
                }
            }
            get
            {
                return AccountBalance;
            }
        }

    }
}
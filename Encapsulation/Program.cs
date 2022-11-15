using System.Security.Principal;

namespace Ecapsulation
{

    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();
            myAccount.Balance = 10000;
            Console.WriteLine("Your account balance is:" + myAccount.Balance);

            Console.ReadLine();

        }
    }
}

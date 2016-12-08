using System;

namespace _18November2016
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter operation type"); //withdraw, deposit, balance enquiry
            var operationType = Console.ReadLine();
            Console.WriteLine("Enter account type"); // active, close, in-operative
            var accountType = Console.ReadLine();
            var operationStatus = string.Empty;
            var accountStatus = string.Empty;

            if (string.IsNullOrWhiteSpace(operationType) && string.IsNullOrWhiteSpace(accountType.ToUpper())) return;
            
            var accountTypeObj = GetAccountType(accountType);


            if (accountTypeObj != null)
            {
                switch (operationType.ToUpper())
                {
                    case "WITHDRAW":
                    {
                        operationStatus = accountTypeObj.WithDraw();
                        accountStatus = accountTypeObj.accountStatus();
                        break;
                    }

                    case "DEPOSIT":
                    {
                        operationStatus = accountTypeObj.WithDraw();
                        accountStatus = accountTypeObj.accountStatus();
                        break;
                    }

                    case "BALANCEENQUIRY":
                    {
                        operationStatus = accountTypeObj.WithDraw();
                        accountStatus = accountTypeObj.accountStatus();
                        break;
                    }

                }
            }
            
            Console.WriteLine(operationStatus);
            Console.WriteLine(accountStatus);
            Console.ReadLine();

        }

        private static ITransactions GetAccountType(string accountType)
        {
            switch (accountType.ToUpper())
            {
                case "ACTIVE":
                {
                    return new Active();
                }
                case "CLOSED":
                {
                    return new Closed();
                }

                case "INOPERATIVE":
                {
                    return new InOperative();
                }
               
            }
            return null;
        }
    }
}


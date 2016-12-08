namespace _18November2016
{
    interface IAtmProcess
    {
        Active active();

        Closed Closed();

        InOperative InOperative();
    }

    interface ITransactions
    {
        string WithDraw();

        string Deposit();

        string BalanceEnquiry();

        string accountStatus();
    }

    public abstract class Account : ITransactions
    {
        public virtual string WithDraw()
        {
            return true.ToString();
        }

        public virtual string Deposit()
        {
            return true.ToString();
        }

        public virtual string BalanceEnquiry()
        {
            return true.ToString();
        }

        public virtual string accountStatus()
        {
            throw new System.NotImplementedException();
        }
    }

    public class InOperative : Account
    {
        private string _accountStatus = "In-Operative";

        public override string WithDraw()
        {
            _accountStatus = "Active";
            return base.WithDraw();
        }

        public override string Deposit()
        {
            _accountStatus = "Active";
            return base.Deposit();
        }
        public override string accountStatus()
        {
            return _accountStatus;
        }
    }


    public class Closed : Account
    {
        public override string WithDraw()
        {
            return false.ToString();
        }

        public override string Deposit()
        {
            return false.ToString();
        }

        public override string BalanceEnquiry()
        {
            return false.ToString();
        }
        public override string accountStatus()
        {
            return "Closed";
        }
    }


   public class Active : Account
    {
       public override string accountStatus()
       {
           return "Active";
       }
    }


   

   
}

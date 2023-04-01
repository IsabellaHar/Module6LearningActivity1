namespace Module6LA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBankAccount = new BankAccount(1234567890, "Isabella", 100.00);
            Console.WriteLine(myBankAccount.Owner + ", your bank account has a balance of " + myBankAccount.Balance);
            myBankAccount.MakeDeposit(100);
            myBankAccount.MakeWithdrawal(-50);
            Console.WriteLine(myBankAccount.Owner + ", your bank account has a balance of " + myBankAccount.Balance);
        }
    }

    public class BankAccount
    {
        public int AccountNumber { get; }    //property for the account number
        public string Owner { get; set; }   //property for the owner

        public decimal Balance { get; }        //property for the balance 

        public BankAccount(int accountNumber, string owner, decimal initialBalance)    //The class constructor
        {

            AccountNumber = accountNumber;    //account number is passed in
            Owner = owner;                    //owner is passed in
            if (initialBalance < 0)            //if initial balance is negative, display error message
            { 
                Console.WriteLine("Error: the Initial Balance must be positive"); 
            } //end if
            else
            {
                Balance = initialBalance;      //if the initial balance is positive, set it as the bank account's balance
            } //end else
        } //end constructor


        //Method to make a deposit into the bank baccount
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount > 0)                         //if the amount of the deposit is positive, add it to the balance
            {
                Balance = Balance + amount;
            }
            else
            {
                Console.WriteLine("Error: deposits must be positive");  //if the amount of the desposit is negative, write an error message.
            }
        }  //end make deposit

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (withdrawal > 0)      //if the amount of the withdrawn is positive, write an error message.
            {
                Console.WriteLine("Error: withdrawals must be negative");
            } else
            {
                if ((Balance + withdrawal) < 0)    //if the withdrawal will overdraw the account, write an error message.
                {
                    Console.WriteLine("Error: you cannot withdraw more than the balance");
                } else
                {
                    Balance = Balance + withdrawal;   //if the withdrawal is all OK, deduct it from the balance.
                }
            }
        }

    } //end of bank account class

}
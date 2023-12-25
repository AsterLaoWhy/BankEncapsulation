namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount();
            bankAccount.Deposit(300.00);
            bankAccount.GetBalance();
        }
    }
}

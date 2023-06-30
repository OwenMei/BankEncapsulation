namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, you must be new here! What's your name?");
            var name = Console.ReadLine() ?? "";
            BankAccount account1 = (name != "")? new BankAccount(name) : new BankAccount();
            
            Console.WriteLine($" Welcome, {account1.userName}, you have $100 in your bank account. What would you like to do today? Deposit(D) or Withdraw(W)");

            var choice = Console.ReadLine() ?? "D";

            if(choice.ToUpper() == "D") 
            {
                Console.WriteLine("How much would you like to deposit?");
                var depAmount = (double.TryParse(Console.ReadLine(), out double num)) ? num : 0;
                account1.deposit(depAmount);
                Console.WriteLine($"you now have ${account1.getBalance()} in your bank account");
            }
            else if(choice.ToUpper() == "W")
            {

                Console.WriteLine("How much would you like to withdraw?");
                var witAmount = (double.TryParse(Console.ReadLine(), out double num)) ? num : 0;
                if(account1.getBalance() > witAmount)
                {
                    account1.withdraw(witAmount);
                    Console.WriteLine($"you now have ${account1.getBalance()} in your bank account");
                }
                else
                {
                    Console.WriteLine("you do not have enough money in your bank account");
                }
            }
        }
    }
}

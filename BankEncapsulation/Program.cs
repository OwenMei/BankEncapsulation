namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            Console.WriteLine("What would you like to do today? Deposit(D) or Withdraw(W)");

            var choice = Console.ReadLine() ?? "D";

            if(choice.ToUpper() == "D") 
            {
                Console.WriteLine("How much would you like to deposit?");
                var depAmount = (int.TryParse(Console.ReadLine(), out int num)) ? num : 0;
                account1.deposit(depAmount);
                Console.WriteLine($"you now have ${account1.getBalance()} in your bank account");
            }
            else if(choice.ToUpper() == "W")
            {
                Console.WriteLine("How much would you like to withdraw?");
                
                var witAmount = (int.TryParse(Console.ReadLine(), out int num)) ? num : 0;
                account1.withdraw(witAmount);
                Console.WriteLine($"you now have ${account1.getBalance()} in your bank account");
            }
        }
    }
}

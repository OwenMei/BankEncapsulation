namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            Console.WriteLine("How much would you like to deposit");
            var depAmount = (int.TryParse(Console.ReadLine(), out int num))? num : 0;
            account1.deposit(depAmount);
            Console.WriteLine($"you now have ${account1.getBalance()} in your bank account");
        }
    }
}

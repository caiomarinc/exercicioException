using ExercicioPropostoException.Entities;
using ExercicioPropostoException.Entities.Exceptions;
using System.Globalization;

namespace ExercicioPropostoException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int accNumber = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string accHolder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double accInitialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                double accWithdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("");

                Account account = new Account
                {
                    Number = accNumber,
                    Holder = accHolder,
                    Balance = accInitialBalance,
                    WithdrawLimit = accWithdrawLimit
                };

                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(withdraw);
                Console.WriteLine("New Balance: " + account.Balance);
            }
            catch (DomainException ex)
            {
                Console.WriteLine("Withdraw Error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error!: " + ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected Error!");
            }
        }
    }
}
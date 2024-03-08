using ExercicioPropostoException.Entities.Exceptions;

namespace ExercicioPropostoException.Entities;
internal class Account
{
    public int Number { get; set; }
    public string Holder { get; set; }
    public double Balance { get; set; }
    public double WithdrawLimit { get; set; }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (WithdrawLimit < amount)
        {
            throw new DomainException("Amount exceeds your withdraw limit.");
        }
        if (Balance < amount) 
        {
            throw new DomainException("Amount exceeds your balance.");
        }
        Balance -= amount;
    }
}

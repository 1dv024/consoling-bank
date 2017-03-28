using System;

namespace ConsolingBank
{
    /// <summary>
    /// Represents the main place where the program starts the execution.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The starting point of the application.
        /// </summary>
        static void Main()
        {
            Account account1 = new Account("Sparkap Ital", 15672, 2559.37);
            Account account2 = new Account("Fatti Glapp", 78153, 17.12);
            Account account3 = new Account("Massap Engar", 93781, 15869435.98);

            Console.WriteLine($"{account1.Name} försöker sätta in en summa mindre än 0.");
            try
            {
                account1.Deposit(-100);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            account1.DisplayAccount();

            Console.WriteLine($"\n{account1.Name} sätter in pengar.");
            account1.Deposit(441.50);
            account1.DisplayAccount();

            Console.WriteLine($"\n{account1.Name} tar ut pengar.");
            account1.Withdraw(980, 23.5);
            account1.DisplayAccount();

            Console.WriteLine($"\n{account2.Name} försöker ta ut 10000 kr.");
            try
            {
                account2.Withdraw(10000, 23.5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            account2.DisplayAccount();

            Console.WriteLine("\nRänta sätts in");
            account1.AddInterest();
            account2.AddInterest();
            account3.AddInterest();

            Console.WriteLine("\nAlla konton");
            account1.DisplayAccount();
            account2.DisplayAccount();
            account3.DisplayAccount();
            Console.WriteLine();
        }
    }
}

using System;
using NUnit.Framework;

namespace ConsoleApp1.cursoNunit
{
    public class BankAccount
    {
        public int Balance { get; private set; 
        }
        public BankAccount(int startingBalance)
        {
            Balance = startingBalance;
        }

        public void Deposit(int amount){
            
        }
        public void Withdraw(int amount){
            
        }
    }



    [TestFixture]
    public class BankAccountClass{
        [Test]
        public void BankAccountShouldDeposit(){
            
        }
    }
}

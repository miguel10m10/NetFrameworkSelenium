using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{

    //INTERFACE LOG
    public interface Ilog
    {
        void Write(String msg);
    }

    //IMPLEMENTO LA INTERFACE LOG
    public class ConsoleLog : Ilog
    {
        public void Write(String msg)
        {
            Console.WriteLine(msg);
        }
    }

    //CLASE BANK  ACCOUNT QUE TIENE UN METODO LLAMADO BALANCE
    public class BankAccount
    {
        public int Balance
        {
            get;
            set;
        }

        //CONSTRUCTOR BANK ACCOUNT
        private readonly Ilog log;

        public BankAccount(Ilog log)
        {
            this.log = log;
        }

        //METODO DEPOSITO
        public void deposit(int amount)
        {
            log.Write($"Depositing {amount}");
            Balance += amount;
        }
        //TEST
        [TestFixture]
        public class BankAccountTests
        {
            private BankAccount ba;

            //TEST
            [Test]
            public void Test5DepositIntegrationTest()
            {
                ba = new BankAccount(new ConsoleLog()) { Balance = 100 };
                ba.deposit(100);
                Assert.That(ba.Balance, Is.EqualTo(200));
            }
        }
    }
}

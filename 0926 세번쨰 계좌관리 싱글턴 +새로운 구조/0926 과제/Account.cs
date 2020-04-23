using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0926_과제
{
    class Account : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }

        public Account(string n, int id, int b)
        {
            Name = n;
            Id = id;
            Balance = b;
        }

        public void AddMoney(int money)
        {
            Balance += money;
        }

        public void MinMoney(int money)
        {
            if (money < 0 || Balance < money)
                throw new Exception("출금액을 확인해주십시오");

            Balance -= money;
        }

        public void Print()
        {
            Console.WriteLine("[계좌번호] " + Id);
            Console.WriteLine("[이름] " + Name);
            Console.WriteLine("[잔액] " + Balance);
  
        }

        public override string ToString()
        {
            string temp = string.Format("[{0}] 계좌 : {1} 잔액 : {2}", Name, Id, Balance);
            return temp;
        }

        public int CompareTo(object obj)
        {
            Account acc = obj as Account;
            if (acc == null)
                throw new Exception("잘못된 객체 전달");

            return Name.CompareTo(acc.Name);
        }
    }

    class BalanceComparaer : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return y.Balance - x.Balance;
        }
    }

    class IDComparaer : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return x.Id - y.Id;
        }
    }
}

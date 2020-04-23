using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0926_과제
{
    class Control
    {
        List<Account> acc = new List<Account>();

        static Control con;
        public static Control Instance
        {
            get
            {
                return con;
            }
        }
        
        static Control()
        {
            con = new Control();
        }

        private Control()
        {
        }

        public void InputAccount(int id,int balance)
        {
            for (int i = 0; i < acc.Count; i++)
            {
                Account mem = acc[i];
                if (mem.Id == id)
                {
                    mem.AddMoney(balance);
                    return;
                }
            }
            throw new Exception("없쥬");
        }
        public void OutputAccount(int id, int balance)
        {
            for (int i = 0; i < acc.Count; i++)
            {
                Account mem = acc[i];
                if (mem.Id == id)
                {
                    mem.MinMoney(balance);
                    return;
                }
            }
            throw new Exception("없쥬");
        }

        public bool DelAccount(int id)
        {
            for (int i = 0; i < acc.Count; i++)
            {
                Account mem = acc[i];
                if (mem.Id == id)
                {
                    acc.Remove(mem);
                    return true;
                }
                   
            }
            return false;
        }
        public Account SelectAccount(int id)
        {
                for (int i = 0; i < acc.Count; i++)
                {
                    Account mem = acc[i];
                    if (mem.Id==id)
                        return mem;
                }
            throw new Exception("없쥬");

        }

        public void SortAccount(string idx)
        {
            switch(idx)
            {
                case "1": acc.Sort(new IDComparaer()); break;
                case "2": acc.Sort(); break;
                case "3": acc.Sort(new BalanceComparaer()); break;
                default: break;
            }
        }

        public void SelectAllAccount(out List<Account> mem)
        {
            mem = acc;
        }

        public bool AddAccount(Account mem)
        {
            try
            {
                acc.Add(mem);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}

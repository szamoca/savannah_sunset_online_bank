using LionKingBankAccount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LionKingBankAccount.ViewModels
{
    public class BankAccounts
    {
        public static List<BankAccount> Accounts = new List<BankAccount>
        {
            new BankAccount("Simba", 2000, "Lion", true, false),
            new BankAccount("Scar", 1200.58f, "Lion", false, true),
            new BankAccount("Rafiki", 10256.98f, "Mandrill", false, false),
            new BankAccount("Ed", 0, "Hyena", false, true),
            new BankAccount("Pumbaa", 502, "Warthog", false, false),
            new BankAccount("Timon", 52, "Meerkat", false, false),
            new BankAccount("Zazu", 25688, "Hornbill", false, false)
        };
    }
}

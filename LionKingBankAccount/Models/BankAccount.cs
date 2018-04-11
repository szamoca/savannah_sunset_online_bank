using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LionKingBankAccount.Models
{
    public class BankAccount
    {
        private int id;
        private static int idCounter = 1;
        private string name;
        private float balance;
        private string animalType;
        private string currency;
        private bool isKing;
        private bool isBad;

        public BankAccount(string name, float balance, string animalType, bool isKing, bool isBad)
        {
            id = idCounter++;
            this.name = name;
            this.balance = balance;
            this.animalType = animalType;
            currency = "¢himp";
            this.isKing = isKing;
            this.isBad = isBad;
        }

        public string Name { get => name; set => name = value; }
        public float Balance { get => balance; set => balance = value; }
        public string AnimalType { get => animalType; set => animalType = value; }
        public string Currency { get => currency; }
        public int ID { get => id; }
        public bool IsKing { get => isKing; }
        public bool IsBad { get => isBad; }

        public string FormatBalance()
        {
            return Balance.ToString("N2");
        }

        public float IncreaseByDonation()
        {
            if (IsKing)
            {
                Balance += 100;
                return Balance;
            }
            else
            {
                Balance += 10;
                return Balance;
            }
        }
    }
}

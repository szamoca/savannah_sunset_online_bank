using LionKingBankAccount.Models;
using LionKingBankAccount.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LionKingBankAccount.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        [Route("simba")]
        public IActionResult Simba()
        {
            var simba = new BankAccount("Simba", 2000f, "Lion", true, false);
            
            return View(simba);
        }

        [HttpGet]
        [Route("/")]
        public IActionResult All()
        {
            return View(BankAccounts.Accounts);
        }

        [HttpPost]
        [Route("donate/{id}")]
        public IActionResult Donate(int id)
        {
            BankAccounts.Accounts[BankAccounts.Accounts.FindIndex(acc => acc.ID == id)].IncreaseByDonation();
            return RedirectToAction("All");
        }

        [HttpPost]
        [Route("add-account")]
        public IActionResult AddAccount (string Name, float Balance, string AnimalType, bool IsKing, bool IsBad)
        {
            BankAccounts.Accounts.Add(new BankAccount(Name, Balance, AnimalType, IsKing, IsBad));
            return RedirectToAction("All");
        }
    }
}

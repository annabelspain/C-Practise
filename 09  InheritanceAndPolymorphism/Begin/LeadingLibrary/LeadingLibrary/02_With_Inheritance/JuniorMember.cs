using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingLibrary
{
    public class JuniorMember : Member
    {


        public JuniorMember(string name, int age, int membershipNumber) :
        base(name, age, membershipNumber)
        {
        }

        public override bool Borrow(Book book)
        {
            return (book.Category == BookCategory.Children);    
        }

        //public decimal CashFund { get; set; }
        //public override void PayFine(decimal fine)
        //{
        //        CashFund -= fine;
        //}

        private decimal CashFund { get; set; } // Now private
        public override void PayFine(decimal fine)
        {
            CashFund -= fine;
        }
        public override void SetFineLimit(decimal amount)
        {
            CashFund = amount;
        }
        public override decimal GetFineCredit()
        {
            return CashFund;
        }



    }

}

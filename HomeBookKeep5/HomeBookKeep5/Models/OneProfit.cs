using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBookKeep5.Models
{
    public class OneProfit
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Sum { get; set; }
        public string Comment { get; set; }

        public int IncomeCatId { get; set; }
        public int IncomeSubCatId { get; set; }
        public int PurseId { get; set; }

        public IncomeCat IncomeCat { get; set; }
        public IncomeSubCat IncomeSubCat { get; set; }
        public Purse Purse { get; set; }
    }
}

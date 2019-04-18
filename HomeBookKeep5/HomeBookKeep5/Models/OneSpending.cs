using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBookKeep5.Models
{
    public class OneSpending
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Sum { get; set; }
        public decimal Quantity { get; set; }
        public string Comment { get; set; }

        public int CostCatId { get; set; }
        public int CostSubCatId { get; set; }
        public int PurseId { get; set; }
        public int UnitId { get; set; }

        public CostCat CostCat { get; set; }
        public CostSubCat CostSubCat { get; set; }
        public Purse Purse { get; set; }
        public Unit Unit { get; set; }
    }
}

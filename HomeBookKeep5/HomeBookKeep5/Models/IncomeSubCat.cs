using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBookKeep5.Models
{
    public class IncomeSubCat
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int IncomeCatId { get; set; }
        public IncomeCat IncomeCat { get; set; }
    }
}

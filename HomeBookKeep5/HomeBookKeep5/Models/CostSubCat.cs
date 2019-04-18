using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBookKeep5.Models
{
    public class CostSubCat
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CostCatId { get; set; }
        public CostCat CostCat { get; set; }
    }
}

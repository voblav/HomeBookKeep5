﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBookKeep5.Models
{
    public class CostCat
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<CostSubCat> CostSubCats { get; set; }
    }
}

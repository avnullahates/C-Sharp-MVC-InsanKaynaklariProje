﻿using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.VM
{
    public class PersonnelAll
    {
        public Permit  Permit { get; set; }

        public List<Personnel> Personnels { get; set; }

        public Personnel Personnel { get; set; }

        public Advance Advance { get; set; }

        public Manager Manager { get; set; }

        public Expense Expense { get; set; }

    }
}

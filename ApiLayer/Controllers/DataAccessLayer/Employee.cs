﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLayer.Controllers.DataAccessLayer
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}

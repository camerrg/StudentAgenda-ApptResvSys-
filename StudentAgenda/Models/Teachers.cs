﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAgenda.Models
{
    public class Teachers
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int ClassId { get; set; }

        public Classes Classes { get; set; }
    }
}
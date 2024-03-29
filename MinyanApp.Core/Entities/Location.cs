﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinyanApp.Core.Entities
{
    public class Location
    {
        public int Id { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public double? Accuracy { get; set; }

        public double? Distance { get; set; }

        public DateTime? DateTime { get; set; }
    }
}
